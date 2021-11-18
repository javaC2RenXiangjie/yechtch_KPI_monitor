using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yechtech.Model.Monitor;
using Yechtech.Utility;

namespace Yechtch.IMS.Manager
{
    public partial class DBConfigForm : Form
    {
        public DBConfigForm()
        {
            InitializeComponent();
            gdvDataSource.AutoGenerateColumns = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InitialForm();
        }

        private void InitialForm()
        {
            txtId.Text = string.Empty;
            txtDBCode.Text = string.Empty;
            txtDBName.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUrl.Text = string.Empty;
            txtDBCode.Enabled = true;
            txtCubeName.Text = string.Empty;
            cbDBType.SelectedIndex = -1;
            cmbCompany.SelectedIndex = -1;
        }

        void InitialDBType()
        {

            IList<sysconfig> list = SysConfigHelper.GetConfigByGroupName("DbType");


            cbDBType.DataSource = list;
            cbDBType.DisplayMember = "name";
            cbDBType.ValueMember = "val";



        }

        private void InitialCompany()
        {
            IMSDBHelper<company> companyDbHelper = new IMSDBHelper<company>();
            var list = companyDbHelper.FindList(x => x.id>0);
            if (list != null && list.Count > 0)
            {
                cmbCompany.DataSource = list;
                cmbCompany.ValueMember = "Companycode";
                cmbCompany.DisplayMember = "Companyname";
            }
            cmbCompany.SelectedIndex = -1;
        }


        private void DBConfigForm_Load(object sender, EventArgs e)
        {



            InitialDBType();
            InitialCompany();
            LoadDBConfig();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDBConfig();
        }

        private void LoadDBConfig()
        {
            string key = txtSearch.Text.Trim();

            IMSDBHelper<configdb> dbHelper = new IMSDBHelper<configdb>();

            IList<configdb> list;
            if(string.IsNullOrEmpty(key))
            {
                list = dbHelper.FindList(x => x.id>0);
            }
            else
            {
                list = dbHelper.FindList(x => x.dbcode.Contains(key) || x.dbname.Contains(key));
            }
     

            gdvDataSource.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDBCode.Text))
            {
                MessageBox.Show("请输入连接代码");
                return;
            }
            if (string.IsNullOrEmpty(txtDBName.Text))
            {
                MessageBox.Show("请输入连接名称");
                return;
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("请输入用户名");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("请输入密码");
                return;
            }
            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                MessageBox.Show("请输入url");
                return;
            }

            if (cbDBType.SelectedValue != null && !string.IsNullOrEmpty(cbDBType.SelectedValue.ToString()) && string.IsNullOrEmpty(txtCubeName.Text))
            {
                MessageBox.Show("请输入CubeName");
                return;
            }


            IMSDBHelper<configdb> dbHelper = new IMSDBHelper<configdb>();

            configdb m = new configdb();

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                DataGridViewRow dataGridViewRow = gdvDataSource.CurrentRow;
                m = dataGridViewRow.DataBoundItem as configdb;
                m.dbname = txtDBName.Text.Trim();
                m.dbcode = txtDBCode.Text.Trim();
                m.username = txtUserName.Text.Trim();
                m.password = txtPassword.Text.Trim();
                m.url = txtUrl.Text.Trim();
                m.database = txtCubeName.Text;
                m.dbtype = Int32.Parse(cbDBType.SelectedValue.ToString());
                m.companycode = cmbCompany.SelectedValue.ToString();

                var list = dbHelper.FindList(x => (x.dbcode == m.dbcode || x.dbname == m.dbname) && x.id != m.id);

                if (list != null && list.Count > 0)
                {
                    MessageBox.Show("已经存在相同的数据连接或者名称！");
                    return;
                }
                dbHelper.Update(m);
            }
            else
            {

                m.dbname = txtDBName.Text.Trim();
                m.dbcode = txtDBCode.Text.Trim();
                m.username = txtUserName.Text.Trim();
                m.password = txtPassword.Text.Trim();
                m.url = txtUrl.Text.Trim();
                m.database = txtCubeName.Text;
                m.dbtype = Int32.Parse(cbDBType.SelectedValue.ToString());
                m.companycode = cmbCompany.SelectedValue.ToString();

                var list = dbHelper.FindList(x => (x.dbcode == m.dbcode || x.dbname == m.dbname));

                if (list != null && list.Count > 0)
                {
                    MessageBox.Show("已经存在相同的数据连接或者名称！");
                    return;
                }
                dbHelper.Add(m);
            }
            MessageBox.Show("保存成功");
            InitialForm();
            LoadDBConfig();
        }

        private void gdvDataSource_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = gdvDataSource.CurrentRow;
                configdb selected = dataGridViewRow.DataBoundItem as configdb;
                if (selected != null)
                {

                    txtId.Text = selected.id.ToString();

                    txtUrl.Text = selected.url;

                    txtDBCode.Text = selected.dbcode;
                    txtDBName.Text = selected.dbname;
                    txtPassword.Text = selected.password;
                    txtUserName.Text = selected.username;
     
                    txtCubeName.Text = selected.database;
                    cbDBType.SelectedValue = Int32.Parse(selected.dbtype.ToString());
                    cmbCompany.SelectedValue = selected.companycode;

                    ////判断下是否有关联，如果已经有关联则，companycode 就不可以修改
                    //DBHelper<monitoritemdb> monitoritemdbDbHelper = new DBHelper<monitoritemdb>();
                    //var list = monitoritemdbDbHelper.FindList(x => x.dbcode == selected.dbcode);
                    //if (list != null && list.Count > 0)
                    //{
                    //    txtDBCode.Enabled = false;
                    //}
                    //else
                    //{
                    //    txtDBCode.Enabled = true;
                    //}
                }
            }
        }
    }
}
