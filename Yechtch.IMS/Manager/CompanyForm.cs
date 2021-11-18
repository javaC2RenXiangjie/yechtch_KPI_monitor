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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            
            InitializeComponent();
            gdvCustomer.AutoGenerateColumns = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            string key = txtSearch.Text.Trim();
            IMSDBHelper<company> companyDbHelper = new IMSDBHelper<company>();
            IList<company> list;
            if(!string.IsNullOrEmpty(key))
            {
                list = companyDbHelper.FindList(x => x.companycode.Contains(key) || x.companyname.Contains(key));
            }
            else
            {
                list = companyDbHelper.FindList(x => x.id >0);
            }
            

            gdvCustomer.DataSource = list;

        }

       



        private void gdvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = gdvCustomer.CurrentRow;
                company selectedCompany = dataGridViewRow.DataBoundItem as company;
                if(selectedCompany != null)
                {
                    txtCompanyCode.Text = selectedCompany.companycode;
                    txtCompanyName.Text = selectedCompany.companyname;
                    txtId.Text = selectedCompany.id.ToString();


                    ////判断下是否有关联，如果已经有关联则，companycode 就不可以修改
                    //IMSDBHelper<monitorgroup> monitorgroupDbHelper = new IMSDBHelper<monitorgroup>();
                    //var list = monitorgroupDbHelper.FindList(x => x.companycode == selectedCompany.companycode);
                    //if(list != null && list.Count>0)
                    //{
                    //    txtCompanyCode.Enabled = false;
                    //}
                    //else
                    //{
                    //    txtCompanyCode.Enabled = true;
                    //}
                }
            }
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //具体表单设置参考 https://blog.csdn.net/achenyuan/article/details/84632751
            LoadCustomer();
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            InitialForm();
        }

        private void InitialForm()
        {
            txtId.Text = string.Empty;

            txtCompanyCode.Text = string.Empty;
            txtCompanyCode.Enabled = true;
            txtCompanyName.Text = string.Empty;
            txtCompanyName.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IMSDBHelper<company> companyDbHelper = new IMSDBHelper<company>();

            company c =new company();

            if(!string.IsNullOrEmpty(txtId.Text))
            {
                DataGridViewRow dataGridViewRow = gdvCustomer.CurrentRow;
                c = dataGridViewRow.DataBoundItem as company;
                c.companycode = txtCompanyCode.Text.Trim();
                c.companyname = txtCompanyName.Text.Trim();

                var list = companyDbHelper.FindList(x => (x.companycode == c.companycode || x.companyname == c.companyname) && x.id != c.id);

                if(list != null && list.Count>0)
                {
                    MessageBox.Show("已经存在相同的公司名称或者公司编码！");
                    return;
                }
                companyDbHelper.Update(c);
            }
            else
            {
                
                c.companycode = txtCompanyCode.Text.Trim();
                c.companyname = txtCompanyName.Text.Trim();
                c.createby = c.lastupdateby = "admin";
                c.lastupdatetime = c.createtime = DateTime.Now;

                var list = companyDbHelper.FindList(x => x.companycode == c.companycode || x.companyname == c.companyname);

                if (list != null && list.Count > 0)
                {
                    MessageBox.Show("已经存在相同的公司名称或者公司编码！");
                    return;
                }
                companyDbHelper.Add(c);
            }
            MessageBox.Show("保存成功");
            InitialForm();
            LoadCustomer();

        }
    }
}
