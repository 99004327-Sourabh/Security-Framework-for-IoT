using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserApp
{
    public partial class ControlIOT : Form
    {
        Db obj = null;
        public ControlIOT()
        {
            InitializeComponent();
        }


        private void ControlIOT_Load(object sender, EventArgs e)
        {
            obj = new Db();
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            bool flag;
            if (OSXStyleToggleSwitch.Checked)
                flag = obj.IOTCommand(Program.sessionkey, "1");
            else
                flag = obj.IOTCommand(Program.sessionkey, "0");

            if (flag)
                MessageBox.Show("Command submitted successfully", "IOT command", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error while submitting command , check internet & try again", "IOT command", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
