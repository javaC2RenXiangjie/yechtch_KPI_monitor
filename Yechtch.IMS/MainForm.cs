using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yechtch.IMS.Manager;

namespace Yechtch.IMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void 客户设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm frm = new CompanyForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 项目配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectForm frm = new ProjectForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 监控配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorForm frm = new MonitorForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 监控项配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorItemForm frm = new MonitorItemForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 数据源配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBConfigForm frm = new DBConfigForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 监控项管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorItemListForm frm = new MonitorItemListForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
