using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminConsole
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void serviceManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CertificateManager frm = new CertificateManager();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void dataValidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlockLedger frm = new BlockLedger();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
