using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserApp.UserRolesApi;
namespace UserApp
{
    public partial class CheckStatus : Form
    {
        //Db obj = null;
        UserRoles obj;
        public CheckStatus()
        {
            InitializeComponent();
        }

        private void CheckStatusBtn_Click(object sender, EventArgs e)
        {
            string user = Environment.UserName;
            string macid = Mac.GetMacAddress();
            string mac = Environment.MachineName;

            if ( obj.isApproved(user,macid,mac))
            {
                DialogResult res = MessageBox.Show("Your request approved , Download certificates ?", "Certificate", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    //this.Height = this.Height + 300;
                    //this.Top = this.Top - 100;
                    //lblPrvKey.Text = obj.PrivateKey();
                    //lblSha.Text = obj.Certificate();
                }
            }
            else
                MessageBox.Show("Your request is still pending, plz wait..!!", "Certificate", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void CheckStatus_Load(object sender, EventArgs e)
        {
            obj = new UserRoles();
        }

        private void picDownloadBtn_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("privatekey.xml" , lblPrvKey.Text);
            MessageBox.Show("Private key downloaded successfully", "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Height = this.Height - 300;
            this.Top = this.Top + 100;
        }
    }
}
