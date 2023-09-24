using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using AdminConsole.AdminDb;
namespace AdminConsole
{
    public partial class CertificateManager : Form
    {
        Thread th;
        Db obj;
        public CertificateManager()
        {
            InitializeComponent();
        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (BtnStartStop.Text.StartsWith("Start"))
            {
                th = new Thread(new ThreadStart(Run));
                th.Start();
                BtnStartStop.Text = "Stop service";
            }
            else
            {
                th.Abort();
                BtnStartStop.Text = "Start service";
            }
        }

        private void Run()
        {
            while (th.IsAlive)
            {
                obj.ProcessRequest();
                Thread.Sleep(3000);
            }
        }

        private void CertificateManager_Load(object sender, EventArgs e)
        {
            obj = new Db();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (th != null)
                th.Abort();

            Application.ExitThread();
        }
    }
}
