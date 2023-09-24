using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using AdminConsole.AdminDb;
using Newtonsoft.Json;
namespace AdminConsole
{
    public partial class Form1 : Form
    {
        //AdminDb.AdminDb obj = null;
        Db obj = null;
        AdlerChecksum Adler;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new Db();
            RefreshRequest();
            Adler = new AdlerChecksum();
        }

        private void RefreshRequest()
        {
            //string json = obj.GetToApprove();
            DataTable buffer = obj.GetToApprove();
            //DataTable buffer = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            if (buffer.Rows.Count != 0)
            {
                for (int row = 0; row < buffer.Rows.Count; row++)
                {
                    ListViewItem item = new ListViewItem(buffer.Rows[row]["username"].ToString());
                    item.Tag = buffer.Rows[row]["reqid"].ToString();
                    item.SubItems.Add(buffer.Rows[row]["macid"].ToString());
                    item.SubItems.Add(buffer.Rows[row]["ipaddress"].ToString());
                    item.SubItems.Add(buffer.Rows[row]["macname"].ToString());
                    item.SubItems.Add(buffer.Rows[row]["datetime"].ToString());
                    ListViewRequest.Items.Add(item);
                }
            }
        }

        private void processRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                string reqid = ((ListViewItem)ListViewRequest.SelectedItems[0]).Tag.ToString();
                string keys = ListViewRequest.SelectedItems[0].SubItems[0].Text + ListViewRequest.SelectedItems[0].SubItems[1].Text + ListViewRequest.SelectedItems[0].SubItems[2].Text + ListViewRequest.SelectedItems[0].SubItems[3].Text;
                if (obj.UpdateCertificate(reqid, keys))
                    ListViewRequest.Items.RemoveAt(ListViewRequest.SelectedIndices[0]);
                else
                    MessageBox.Show("Something went wrong during approval, please try later", "Response", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void deleteRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                string reqid = ((ListViewItem)ListViewRequest.SelectedItems[0]).Tag.ToString();
                if (obj.Delete(reqid))
                {
                    ListViewRequest.Items.RemoveAt(ListViewRequest.SelectedIndices[0]);
                    MessageBox.Show("Request deleted successfully !!", "Response", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Something went wrong during approval, please try later", "Response", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshRequest();
        }
    }
}
