using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yechtch.IMS.Manager
{
    public partial class MonitorItemListForm : Form
    {
        public MonitorItemListForm()
        {
            InitializeComponent();
            gdvMonitorItem.AutoGenerateColumns = false;
        }

        private void MonitorItemListForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //string key = txtKey.Text.Trim();

            //IMSDBHelper<monitoritem> helper = new IMSDBHelper<monitoritem>();
            //IList<monitoritem> list =null;
            //if (!string.IsNullOrEmpty(key))
            //{
            //    list = helper.FindList(x => x.companycode.ToLower().Contains(key.ToLower())
            //    || x.ProjectCode.ToLower().Contains(key.ToLower())
            //    || x.MonitorCode.ToLower().Contains(key.ToLower())
            //    || x.MonitorItemCode.ToLower().Contains(key.ToLower())
            //    || x.MonitorItemName.ToLower().Contains(key.ToLower()));

            //}


            //gdvMonitorItem.DataSource = list;
        }

        private void gdvMonitorItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            //{
            //    DataGridViewRow dataGridViewRow = gdvMonitorItem.CurrentRow;
            //    MonitorItem selected = dataGridViewRow.DataBoundItem as MonitorItem;
            //    if (selected != null)
            //    {

             
            //        MonitorItemForm monitorItemForm = new MonitorItemForm();
            //        monitorItemForm.MonitorItemId = selected.Id.ToString();
            //        monitorItemForm.ShowDialog();

            //    }
            //}
        }
    }
}
