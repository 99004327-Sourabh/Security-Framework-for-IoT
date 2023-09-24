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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtDateTime.Text = DateTime.Now.ToString();
            TxtUsername.Text = Environment.UserName;
            TxtIpAddress.Text = Mac.GetLocalIp();
            TxtMacId.Text = Mac.GetMacAddress();
            TxtMacName.Text = Environment.MachineName;
        }

        private void BtnRequest_Click(object sender, EventArgs e)
        {
            UserRolesApi.UserRoles db = new UserRolesApi.UserRoles();
            //UserRoles db = new UserRoles();
            bool flag = db.AddRequest(TxtUsername.Text, TxtMacId.Text ,  TxtIpAddress.Text, TxtMacName.Text, DateTime.Now.ToString());
            if (flag)
                MessageBox.Show("Your request submitted successfully , plz wait until approved", "Registeration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("You have already registered , can't register again", "Registeration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
