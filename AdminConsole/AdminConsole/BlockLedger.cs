using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AdminConsole.AdminDb;
namespace AdminConsole
{
    public partial class BlockLedger : Form
    {
        public BlockLedger()
        {
            InitializeComponent();
        }

        AdminDb.AdminDb obj;
        //Db obj;
        AdlerChecksum Adler = null;
        ArrayList compromisedList;
        private void BlockLedger_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            obj = new AdminDb.AdminDb();
            compromisedList = new ArrayList();
            Adler = new AdlerChecksum();
            LoadEntries();
        }

        private void LoadEntries()
        {
            compromisedList.Clear();
            lstBlockView.Items.Clear();
            DataTable buffer = obj.GetBlockEntries();
            for (int i = 0; i < buffer.Rows.Count; i++)
            {
                string id = buffer.Rows[i]["id"].ToString();
                ListViewItem L = new ListViewItem(id);

                string key = buffer.Rows[i]["sessionkey"].ToString();
                L.SubItems.Add(key);

                string cmd = buffer.Rows[i]["iotcmd"].ToString();
                L.SubItems.Add(cmd);

                string stamp = buffer.Rows[i]["timestamp"].ToString();

                L.SubItems.Add(stamp);

                string hval = buffer.Rows[i]["hash"].ToString();

                string data = key + "," + cmd + ","+ stamp;
                byte[] iotdata = ASCIIEncoding.ASCII.GetBytes(data);
                Adler.MakeForBuff(iotdata);
                string hashval = Adler.ChecksumValue.ToString();

                if (hashval != hval)
                {
                    L.BackColor = Color.Red;
                    compromisedList.Add(id);
                }

                lstBlockView.Items.Add(L);
            }
            if (compromisedList.Count != 0)
                BtnRecover.Enabled = true;
        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {
            try
            {
                obj.recoveryData(compromisedList.ToArray());
                LoadEntries();
                MessageBox.Show("Records recovered safely to original state", "Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnRecover.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error while recovering" + err.ToString(), "Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
