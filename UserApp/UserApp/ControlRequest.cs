using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using UserApp.UserRolesApi;
namespace UserApp
{
    public partial class ControlRequest : Form
    {
        Db obj = null;
        Thread th;
        int refid;
        public ControlRequest()
        {
            InitializeComponent();
        }

        private void BtnRequest_Click(object sender, EventArgs e)
        {
            int id = -1;
            string user = Environment.UserName;
            string macid = Mac.GetMacAddress();
            string ip = Mac.GetLocalIp();
            string mac = Environment.MachineName;

            if (obj.AddControlRequest(ref id))
            {
                BtnFindControlRequest.Enabled = false;
                picNextButton.Image = null;
                picNextButton.Tag = "0";  // so that user should not click next pic button
                BtnFindControlRequest.Enabled = true;
                th = new Thread(new ParameterizedThreadStart(UpdateLog));
                th.Start( id.ToString());
            }
            else
            {
                Log.Items.Add("Something went wrong, try later");
            }
        }

        private void UpdateLog(object arg)
        {
            string id = (string)arg;
            Log.Items.Add("Secure request submitted...");
            System.Threading.Thread.Sleep(1000);
            Log.Items.Add("Request id returned from server");
            lblRequestId.Text = id;
            System.Threading.Thread.Sleep(1000);
            Log.Items.Add("Waiting for OTP from server");
            System.Threading.Thread.Sleep(5000);
            Log.Items.Add("Check status using find status button");
            BtnFindControlRequest.Enabled = true;
        }

        private void ControlRequest_Load(object sender, EventArgs e)
        {
            obj = new Db();
            ListBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void BtnFindControlRequest_Click(object sender, EventArgs e)
        {
            string skey="";
            Db obj = new Db();
            bool res = obj.ValidateToGetSessionKey(lblRequestId.Text);
            skey = obj.SessionKey;
            if (res)
            {
                Log.Items.Add("OTP generated and match found");
                string key = "xx" + skey.Substring(2);
                Log.Items.Add("Session key generated (" + key + ") [No app shows session key for demo purpose last 2 digit shown]");
                picNextButton.Image = Image.FromFile("up.png");
                picNextButton.Tag = skey;
            }
            else
            {
                picNextButton.Image = Image.FromFile("down.png");
                Log.Items.Add("Failed to match certificates");
                picNextButton.Tag = "0"; 
            }
        }

        private void picNextButton_Click(object sender, EventArgs e)
        {
            string status = (string)picNextButton.Tag;
            if (status != "0")
            {
                Program.sessionkey = status;
                ControlIOT frm = new ControlIOT();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sorry you are not authenticated to grant access for IOT model", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
