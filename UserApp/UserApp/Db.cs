using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using SecureLib;
using Amazon.S3;
using Amazon.S3.Model;
using System.IO;
namespace UserApp
{
    class Db
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adap;
        private string pvkey, certificate, sessionkey;
        SHA384Managed shaM = null;
        AmazonS3Client _s3ClientObj = null;
        AdlerChecksum Adler = null;
        public Db()
        {
            shaM = new SHA384Managed();
            con = new MySqlConnection("server=sg2nlmysql35plsk.secureserver.net;database=webfrmwrk;user id=usrwebfrmwrk;pwd=C$e1q0z4;port=3306");
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            adap = new MySqlDataAdapter(cmd);
            _s3ClientObj = new AmazonS3Client("AKIAJ44WE5JXBHVBVLZQ", "1iqkFwN5d1B+/Pntk9oIb62+fShSx7PJ+RRKgfp3", Amazon.RegionEndpoint.APSouth1);
            Adler = new AdlerChecksum();
        }

        public bool AddRequest(string username, string macid, string ipaddress, string macname, string date)
        {
            bool flag = true;
            try
            {
                string sql = string.Format("select count(*) from request where username = '{0}' and macid='{1}' and ipaddress= '{2}' and macname = '{3}'", username, macid, ipaddress, macname);
                cmd.CommandText = sql;
                int c = int.Parse(cmd.ExecuteScalar().ToString());
                if (c != 0) flag = false;
                else
                {
                    sql = string.Format("insert into request ( username , macid , ipaddress , macname , datetime ) values ( '{0}' , '{1}' , '{2}' , '{3}', '{4}' )", username, macid, ipaddress, macname, date);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    flag = true;
                }
            }
            catch (Exception e)
            {
                flag = false;
            }
            return flag;
        }

        public bool isApproved()
        {
            string user = Environment.UserName;
            string macid = Mac.GetMacAddress();
            string mac = Environment.MachineName;

            bool status = false;

            string sql = string.Format("select * from request where username='{0}' and macid='{1}' and macname='{2}' and status='Y'", user, macid, mac);
            adap.SelectCommand.CommandText = sql;
            DataTable buffer = new DataTable();
            adap.Fill(buffer);
            if (buffer.Rows.Count != 0)
            {
                pvkey = buffer.Rows[0]["privatekey"].ToString();
                certificate = buffer.Rows[0]["certificate"].ToString();
                status = true;
            }
            return status;
        }

        public string Certificate
        {
            get { return certificate; }
        }

        public string PrivateKey
        {
            get { return pvkey; }
        }

        public bool AddControlRequest( ref int id)
        {
            bool status = true;
            try
            {
                string user = Environment.UserName;
                string macid = Mac.GetMacAddress();
                string ip = Mac.GetLocalIp();
                string mac = Environment.MachineName;

                byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(user + macid + ip + mac);
                data = shaM.ComputeHash(data, 0, data.Length);
                string hashkey = System.Text.ASCIIEncoding.ASCII.GetString(data, 0, data.Length);

                string sql = string.Format("insert into controlrequest( securekey) values ( @p1 )");
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@p1", hashkey);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select max(reqid) from controlrequest";
                id = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception e)
            {
                status = false;
            }
            return status;
        }

        public string SessionKey
        {
            get { return sessionkey; }
        }

        public bool ValidateToGetSessionKey( string reqid )
        {
            bool res = false;
            try
            {
                string sql = string.Format("select * from controlrequest where reqid = {0}", reqid);
                adap.SelectCommand.CommandText = sql;
                DataTable buffer = new DataTable();
                adap.Fill(buffer);
                byte[] encryotp = (byte[])buffer.Rows[0]["encryotp"];
                string sha = buffer.Rows[0]["securekey"].ToString();
                sessionkey = buffer.Rows[0]["sessionkey"].ToString();
                adap.SelectCommand.CommandText = string.Format("select privatekey from request where certificate = @p1");
                adap.SelectCommand.Parameters.AddWithValue("@p1", sha);
                DataTable prvbuffer = new DataTable();
                adap.Fill(prvbuffer);
                adap.SelectCommand.Parameters.Clear();
                string privatekey = prvbuffer.Rows[0][0].ToString().Trim();

                byte[] otp_by_user = DataHandler.Decrypt(encryotp, privatekey);
                string otp = System.Text.ASCIIEncoding.ASCII.GetString(otp_by_user);
                otp = otp.Replace("\0", string.Empty);

                cmd.CommandText = string.Format("select count(*) from controlrequest where otp = '{0}' and reqid = {1}", otp, reqid);
                if (int.Parse(cmd.ExecuteScalar().ToString()) != 0)
                    res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }

        public bool IOTCommand(string key, string command)
        {
            bool flag = true;
            try
            {
                MySqlConnection con = new MySqlConnection("server=148.72.232.170;database=secureprotocol;user id=usrsecurepro;pwd=E#sq691e;port=3306");
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

               // Random rnd = new Random();
                //key = rnd.Next().ToString();
                
                string stamp = DateTime.Now.ToString();

                string data = key + "," + command+","+stamp;
                byte[] iotdata = ASCIIEncoding.ASCII.GetBytes(data);
                Adler.MakeForBuff(iotdata);
                string hashval = Adler.ChecksumValue.ToString();
                
                string sql = string.Format("insert into iotcommand( sessionkey , iotcmd , hash , timestamp ) values ( '{0}','{1}','{2}' ,'{3}')", key, command, hashval, stamp);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                sql = string.Format("select max(id) from iotcommand");
                cmd.CommandText = sql;

                int id = int.Parse(cmd.ExecuteScalar().ToString());
                sql = string.Format("insert into iotblockledger( id , sessionkey,iotcmd ,timestamp) values({0},'{1}','{2}','{3}')", id, key, command,stamp);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                flag = false;
            }
            return flag;
        }
    }
}
