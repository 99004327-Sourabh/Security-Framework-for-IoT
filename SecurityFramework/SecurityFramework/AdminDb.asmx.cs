using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using SecureLib;
using System.Reflection;
using Amazon.S3;
using Amazon.S3.Model;
using System.IO;
using System.Collections;
using System.Web;
using System.Web.Services;
using Newtonsoft;
using Newtonsoft.Json;
namespace SecurityFramework
{
    /// <summary>
    /// Summary description for AdminDb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AdminDb : System.Web.Services.WebService
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adap;
        AdlerChecksum Adler;
        SHA384Managed shaM = null;
        AmazonS3Client _s3ClientObj = null;

        string cstring = "server=sg2nlmysql35plsk.secureserver.net;database=webfrmwrk;user id=usrwebfrmwrk;pwd=C$e1q0z4;port=3306";

        #region FTP details
        //njsempire.com/keys ( folder )
        //keyuser
        //Vb*ag498
        #endregion

        public AdminDb()
        {
            shaM = new SHA384Managed();
            con = new MySqlConnection(cstring);
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            adap = new MySqlDataAdapter(cmd);
            Adler = new AdlerChecksum();
            _s3ClientObj = new AmazonS3Client("AKIAJ44WE5JXBHVBVLZQ", "1iqkFwN5d1B+/Pntk9oIb62+fShSx7PJ+RRKgfp3", Amazon.RegionEndpoint.APSouth1);
        }

        [WebMethod]
        public string GetToApprove()
        {
            MySqlConnection con = new MySqlConnection(cstring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string sql = "select reqid,username,macid,ipaddress,macname,datetime from request where status = 'N'";
            adap.SelectCommand.CommandText = sql;
            DataTable buffer = new DataTable();
            adap.Fill(buffer);
            buffer.TableName = "RequestTable";
            con.Close();
            return Newtonsoft.Json.JsonConvert.SerializeObject(buffer);
        }

        [WebMethod]
        public DataTable GetBlockEntries()
        {
            MySqlConnection con = new MySqlConnection(cstring);
            
             con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string sql = "select * from iotcommand";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.SelectCommand.CommandText = sql;
            DataTable buffer = new DataTable();
            adap.Fill(buffer);
            con.Close();
            //System.Windows.Forms.MessageBox.Show(buffer.Rows.Count.ToString());
            buffer.TableName = "iotcommand";
            return buffer;
        }

        [WebMethod]
        public bool Approve(string id)
        {
            string sql = "update request set status = 'Y' where reqid = " + id;
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery() != 0 ? true : false;
        }

        [WebMethod]
        public bool Delete(string id)
        {
            string sql = "delete from request where reqid = " + id;
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery() != 0 ? true : false;
        }

        [WebMethod]
        public bool UpdateCertificate(string reqid, string keys)
        {
            bool flag = true;
            try
            {
                byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(keys);
                data = shaM.ComputeHash(data, 0, data.Length);
                string privatekey = string.Empty, publickey = string.Empty, hashkey = string.Empty;
                hashkey = System.Text.ASCIIEncoding.ASCII.GetString(data, 0, data.Length);

                DataHandler.GenerateKeys(ref privatekey, ref publickey);

                string sql = string.Format("update request set certificate=@p1 , privatekey=@p2 , publickey = @p3 where reqid = @p4", hashkey, privatekey, publickey, reqid);
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@p1", hashkey);
                cmd.Parameters.AddWithValue("@p2", privatekey);
                cmd.Parameters.AddWithValue("@p3", publickey);
                cmd.Parameters.AddWithValue("@p4", reqid);
                cmd.ExecuteNonQuery();
                Approve(reqid);
            }
            catch (Exception e)
            {
                flag = false;
            }
            return flag;
        }

        [WebMethod]
        public bool ProcessRequest()
        {
            // expire session keys > 60 sec
            cmd.CommandText = "DELETE FROM controlrequest WHERE TIMESTAMPDIFF( SECOND , verifiedstamp , NOW() ) >= 180 AND STATUS = 'Y'";
            cmd.ExecuteNonQuery();

            string sql = string.Format("select * from controlrequest where reqid = ( select max( reqid ) from controlrequest where status = 'N' )");
            adap.SelectCommand.CommandText = sql;
            DataTable buffer = new DataTable();
            adap.Fill(buffer);
            if (buffer.Rows.Count != 0)
            {
                string securekey = buffer.Rows[0]["securekey"].ToString(); // get sha from where request recv
                string reqid = buffer.Rows[0]["reqid"].ToString();  // get request id 

                sql = string.Format("select * from request where certificate = '{0}' and status = 'Y'",securekey);
                //adap.SelectCommand.Parameters.AddWithValue("@px", securekey);
                adap.SelectCommand.CommandText = sql;
                DataTable credbuffer = new DataTable();
                adap.Fill(credbuffer);
                adap.SelectCommand.Parameters.Clear();

                if (credbuffer.Rows.Count != 0) // means securekey exists and machine is also authenticated by admin
                {
                    Random rnd = new Random();
                    string otp = rnd.Next(1001, 9999).ToString();  // 4 digit otp 
                    string skey = rnd.Next(1001, 9999).ToString();  // 4 digit session key
                    string publickey = credbuffer.Rows[0]["publickey"].ToString();
                    byte[] enc_otp = DataHandler.Encrypt(Encoding.Unicode.GetBytes(otp), publickey);
                    //string enc_str = ASCIIEncoding.ASCII.GetString(enc_otp, 0, enc_otp.Length);
                    sql = string.Format("update controlrequest set encryotp = @p1 , otp = @p3 where reqid =" + reqid);
                    cmd.Parameters.AddWithValue("@p1", enc_otp);
                    cmd.Parameters.AddWithValue("@p3", otp);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.CommandText = "update controlrequest set status = 'Y' , sessionkey = @p1 where reqid = " + reqid;
                    cmd.Parameters.AddWithValue("@p1", skey);
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }

        [WebMethod]
        public void recoveryData(ArrayList ids)
        {
            MySqlConnection con = new MySqlConnection(cstring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            for (int i = 0; i < ids.Count; i++)
            {
                string id = ids[i].ToString();
                adap.SelectCommand.CommandText = "select * from iotblockledger where id=" + id;
                DataTable recoverrec = new DataTable();
                adap.Fill(recoverrec);

                string key = recoverrec.Rows[0]["sessionkey"].ToString();
                string iotcmd = recoverrec.Rows[0]["iotcmd"].ToString();
                string stamp = recoverrec.Rows[0]["timestamp"].ToString();

                string sql = string.Format("update iotcommand set sessionkey='{0}',iotcmd='{1}',timestamp='{2}' where id={3}", key, iotcmd, stamp, id);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
