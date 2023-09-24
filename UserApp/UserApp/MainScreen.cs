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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void registerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void checkStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckStatus frm = new CheckStatus();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sendRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlRequest frm = new ControlRequest();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();

            Application.ExitThread();
        }
    }
}
