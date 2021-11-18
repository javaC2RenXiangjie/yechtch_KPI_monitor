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
    public partial class MonitorForm : Form
    {
        public MonitorForm()
        {
            InitializeComponent();
            gdvMonitor.AutoGenerateColumns = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMonitor();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InitialForm();
        }

        private void InitialForm()
        {
            txtId.Text = string.Empty;

            cbCompanyCode.SelectedIndex = -1;
            cbProject.SelectedIndex = -1;

            txtMonitorCode.Text = string.Empty;
            txtMonitorName.Text = string.Empty;
            txtDesc.Text = string.Empty;


            cbCompanyCode.Enabled = true;
            cbProject.Enabled = true;

            txtMonitorCode.Enabled = true;
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            InitialCompany();
            LoadMonitor();
        }

        private void LoadMonitor()
        {
            string key = txtSearch.Text.Trim();

            IMSDBHelper<monitor> monitorDbHelper = new IMSDBHelper<monitor>();
            IList<monitor> list;
            if(!string.IsNullOrEmpty(key))
            { 
                list = monitorDbHelper.FindList(x => x.companycode.Contains(key) || x.projectcode.Contains(key) || x.monitorcode.Contains(key) || x.name.Contains(key));

            }
            else
            {
                list = monitorDbHelper.FindList(x => x.id>0);
            }

            gdvMonitor.DataSource = list;


        }

        private void InitialCompany()
        {
            IMSDBHelper<company> companyDbHelper = new IMSDBHelper<company>();
            var list = companyDbHelper.FindList(x => x.id>0);
            if (list != null && list.Count > 0)
            {
                cbCompanyCode.DataSource = list;
                cbCompanyCode.ValueMember = "companycode";
                cbCompanyCode.DisplayMember = "companyname";
            }
            cbCompanyCode.SelectedIndex = -1;
        }

        private void InitialMonitorGroup(string companycode)
        {
            IMSDBHelper<project> db = new IMSDBHelper<project>();
            var list = db.FindList(x => x.CompanyCode == companycode);
            if (list== null)
            {
                list = new List<project>();
            }

            cbProject.DataSource = list;
            cbProject.ValueMember = "projectcode";
            cbProject.DisplayMember = "projectname";

            cbProject.SelectedIndex = -1;
        }

        private void gdvMonitor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = gdvMonitor.CurrentRow;
                monitor selected = dataGridViewRow.DataBoundItem as monitor;
                if (selected != null)
                {

                    txtId.Text = selected.id.ToString();

                    cbCompanyCode.SelectedValue = selected.companycode;
                    InitialMonitorGroup(selected.companycode);

                    cbProject.SelectedValue = selected.projectcode;

                    txtMonitorCode.Text = selected.monitorcode;
                    txtMonitorName.Text = selected.name;
                    txtDesc.Text = selected.desc;

                    ////判断下是否有关联，如果已经有关联则不可以修改
                    //IMSDBHelper<monitoritem> monitoritemDbHelper = new IMSDBHelper<monitoritem>();
                    //var list = monitoritemDbHelper.FindList(x => x.companycode == selected.CompanyCode && x.monitorgroupcode == selected.groupcode && x.monitorcode == selected.monitorcode);
                    //if (list != null && list.Count > 0)
                    //{
                    //    cbCompanyCode.Enabled = false;
                    //    cbProject.Enabled = false;
                    //    txtMonitorCode.Enabled = false;
                    //}
                    //else
                    //{
                    //    cbCompanyCode.Enabled = true;
                    //    cbProject.Enabled = true;
                    //    txtMonitorCode.Enabled = true;
                    //}
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbCompanyCode.SelectedIndex < 0)
            {
                MessageBox.Show("请选择公司名称");
                return;
            }

            if (cbProject.SelectedIndex < 0)
            {
                MessageBox.Show("请选择项目名称");
                return;
            }
            if (string.IsNullOrEmpty(txtMonitorCode.Text))
            {
                MessageBox.Show("请输入监控/报表编码");
                return;
            }
            if (string.IsNullOrEmpty(txtMonitorName.Text))
            {
                MessageBox.Show("请输入监控/报表名称");
                return;
            }


            IMSDBHelper<monitor> db = new IMSDBHelper<monitor>();

            monitor m = new monitor();

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                DataGridViewRow dataGridViewRow = gdvMonitor.CurrentRow;
                m = dataGridViewRow.DataBoundItem as monitor;
                m.companycode = cbCompanyCode.SelectedValue.ToString();
                m.projectcode = cbProject.SelectedValue.ToString();

                m.monitorcode = txtMonitorCode.Text.Trim();
                m.name = txtMonitorName.Text.Trim();
                m.desc = txtDesc.Text.Trim();


                var list = db.FindList(x => (x.monitorcode == m.monitorcode || x.name == m.name) && x.companycode == m.companycode && x.projectcode == m.projectcode && x.id != m.id);

                if (list != null && list.Count > 0)
                {
                    MessageBox.Show("该公司下已经存在相同的监控/报表名称或者编号！");
                    return;
                }
                db.Update(m);
            }
            else
            {
                m.companycode = cbCompanyCode.SelectedValue.ToString();
                m.projectcode = cbProject.SelectedValue.ToString();

                m.monitorcode = txtMonitorCode.Text.Trim();
                m.name = txtMonitorName.Text.Trim();
                m.desc = txtDesc.Text.Trim();



                var list = db.FindList(x => (x.monitorcode == m.monitorcode || x.name == m.name) && x.companycode == m.companycode && x.projectcode == m.projectcode);

                if (list != null && list.Count > 0)
                {
                    MessageBox.Show("该公司下已经存在相同的监控/报表名称或者编号！");
                    return;
                }
                db.Add(m);
            }
            MessageBox.Show("保存成功");
            InitialForm();
            LoadMonitor();
        }

        private void cbCompanyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var companycode = cbCompanyCode.SelectedValue;
            if(companycode == null)
            {
                return;
            }
            InitialMonitorGroup(companycode.ToString());
        }
    }
}
