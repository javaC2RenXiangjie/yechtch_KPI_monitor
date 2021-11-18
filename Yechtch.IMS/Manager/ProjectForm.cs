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
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
            gdvProjectGroup.AutoGenerateColumns = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InitialForm();
        }

        private void InitialForm()
        {
            txtId.Text = string.Empty;

            cbCompanyCode.SelectedIndex = -1;
            txtProjectCode.Text = string.Empty;
            txtProjectName.Text = string.Empty;
            txtDesc.Text = string.Empty;

            txtProjectCode.Enabled = true;
            cbCompanyCode.Enabled = true;


        }

        private void MonitorGroupForm_Load(object sender, EventArgs e)
        {
            InitialCompany();
            LoadProject();
        }

        private void InitialCompany()
        {
            IMSDBHelper<company> companyDbHelper = new IMSDBHelper<company>();
            var list = companyDbHelper.FindList(x => x.id >0);
            if (list != null && list.Count > 0)
            {
                cbCompanyCode.DataSource = list;
                cbCompanyCode.ValueMember = "companycode";
                cbCompanyCode.DisplayMember = "companyname";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cbCompanyCode.SelectedIndex<0)
            {
                MessageBox.Show("请选择公司名称");
                return;
            }
            if (string.IsNullOrEmpty(txtProjectCode.Text))
            {
                MessageBox.Show("请输入项目编码");
                return;
            }
            if (string.IsNullOrEmpty(txtProjectName.Text))
            {
                MessageBox.Show("请输入项目名称");
                return;
            }


            IMSDBHelper<project> monitorDbHelper = new IMSDBHelper<project>();

            project m = new project();

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                DataGridViewRow dataGridViewRow = gdvProjectGroup.CurrentRow;
                m = dataGridViewRow.DataBoundItem as project;
                m.CompanyCode = cbCompanyCode.SelectedValue.ToString();
                m.ProjectCode = txtProjectCode.Text.Trim();
                m.ProjectName = txtProjectName.Text.Trim();
                m.Desc = txtDesc.Text.Trim();
                

                var list = monitorDbHelper.FindList(x => (x.ProjectCode == m.ProjectCode || x.ProjectName == m.ProjectName) && x.CompanyCode == m.CompanyCode && x.Id != m.Id);

                if (list != null && list.Count > 0)
                {
                    MessageBox.Show("该公司下已经存在相同的项目名称或者项目编码！");
                    return;
                }
                monitorDbHelper.Update(m);
            }
            else
            {
              
                m.CompanyCode = cbCompanyCode.SelectedValue.ToString();
                m.ProjectCode = txtProjectCode.Text.Trim();
                m.ProjectName = txtProjectName.Text.Trim();
                m.Desc = txtDesc.Text.Trim();


                var list = monitorDbHelper.FindList(x => (x.ProjectCode == m.ProjectCode || x.ProjectName == m.ProjectName) && x.CompanyCode == m.CompanyCode);

                if (list != null && list.Count > 0)
                {
                    MessageBox.Show("该公司下已经存在相同的项目名称或者项目编码！");
                    return;
                }
                monitorDbHelper.Add(m);
            }
            MessageBox.Show("保存成功");
            InitialForm();
            LoadProject();
        }

        private void LoadProject()
        {
            string key = txtSearch.Text.Trim();

            IMSDBHelper<project> projectDbHelper = new IMSDBHelper<project>();


            IList<project> list;
            if(!string.IsNullOrEmpty(key))
            {
                list = projectDbHelper.FindList(x => x.CompanyCode.Contains(key) || x.ProjectCode.Contains(key) || x.ProjectName.Contains(key));
            }
            else
            {
                list = projectDbHelper.FindList(x =>x.Id >0);
            }

            gdvProjectGroup.DataSource = list;
        }

        private void gdvMonitorGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = gdvProjectGroup.CurrentRow;
                project selected = dataGridViewRow.DataBoundItem as project;
                if (selected != null)
                {
                    
                    txtId.Text = selected.Id.ToString();

                    cbCompanyCode.SelectedValue = selected.CompanyCode;
                    txtProjectCode.Text = selected.ProjectCode;
                    txtProjectName.Text = selected.ProjectName;
                    txtDesc.Text = selected.Desc;

                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProject();
        }
    }
}
