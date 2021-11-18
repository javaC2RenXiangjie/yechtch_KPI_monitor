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
    public partial class MonitorItemForm : Form
    {
        public MonitorItemForm()
        {
            InitializeComponent();
        }


        private string monitorItemId;

        public string MonitorItemId { get => monitorItemId; set => monitorItemId = value; }


        private void MonitorItem_Load(object sender, EventArgs e)
        {
            InitialCompany();

            if (!string.IsNullOrEmpty(monitorItemId))
            {
                InitialMonitorItem(monitorItemId);
            }

            InitialSql();
            InitialDBType();
            InitialDaypart();

            IntialDateidFormat();

            IntialCacheCycle();

            IntialRetryInterval();
            IntialTimeRange();

        }

        private void IntialTimeRange()
        {
            IList<sysconfig> list = SysConfigHelper.GetConfigByGroupName("DayPart");
            cmbTimerange.DataSource = list;
            cmbTimerange.DisplayMember = "name";
            cmbTimerange.ValueMember = "val";
        }

        private void IntialRetryInterval()
        {
            IList<sysconfig> list = SysConfigHelper.GetConfigByGroupName("ExecuteInterval");
            cmbRetryInterval.DataSource = list;
            cmbRetryInterval.DisplayMember = "name";
            cmbRetryInterval.ValueMember = "val";
        }

        private void IntialCacheCycle()
        {
            IList<sysconfig> list = SysConfigHelper.GetConfigByGroupName("CacheCycle");
            cmbCacheCycle.DataSource = list;
            cmbCacheCycle.DisplayMember = "name";
            cmbCacheCycle.ValueMember = "val";
        }

        private void IntialDateidFormat()
        {
            IList<sysconfig> list = SysConfigHelper.GetConfigByGroupName("DateIdFormat");
            cmbdateidformat.DataSource = list;
            cmbdateidformat.DisplayMember = "name";
            cmbdateidformat.ValueMember = "val";
        }

        private void InitialDaypart()
        {
            IList<sysconfig> list = SysConfigHelper.GetConfigByGroupName("DbType");
            cbDBType.DataSource = list;
            cbDBType.DisplayMember = "name";
            cbDBType.ValueMember = "val";
        }

        void InitialDBType()
        {
            IList<sysconfig> list = SysConfigHelper.GetConfigByGroupName("DayPart");
            cmbdaypart.DataSource = list;
            cmbdaypart.DisplayMember = "name";
            cmbdaypart.ValueMember = "val";
        }

        private void InitialDataSource()
        {
            IMSDBHelper<configdb> configDBDbHelper = new IMSDBHelper<configdb>();
            if(cbDBType.SelectedValue == null || string.IsNullOrEmpty(cbDBType.SelectedValue.ToString()) )
            {
                return;
            }
            //var list = configDBDbHelper.FindList(x => x.DBType == cbDBType.SelectedValue);
            //if (list != null && list.Count > 0)
            //{
            //    cmbCompany.DataSource = list;
            //    cmbCompany.ValueMember = "Companycode";
            //    cmbCompany.DisplayMember = "Companyname";
            //}
            //cmbCompany.SelectedIndex = -1;
        }




        private void InitialSql()
        {
            //正则 用这个取匹配##DateID-[0-9]*##
            //初始化SQL

            var sql = "编写是SQL语句时，如果用到时间颗粒度，则使用##DateID##作为占位符，默认值为当前时间对应选择的时间颗粒度和时间格式;\r\n";
            sql += "如以下SQL\r\n";
            sql += "select sum(salesamount) from sales where dateid = '##DateID##'\r\n";
            sql += "比如选择时间颗粒度Day，格式为yyyy - mm - dd,则语句将变为\r\n";
            sql += "select sum(salesamount) from sales where dateid = '{0}'\r\n";
            sql += "比如选择时间颗粒度Month，格式为yyyymm,前缀为M，则语句将变为\r\n";
            sql += "select sum(salesamount) from sales where dateid = 'M{1}'\r\n";
            sql += "如果使用到时间范围，则占位符变为##DateID-1##，表示为当前时间对应选择的时间颗粒度和时间格式往前一个时间颗粒度;\r\n";
            sql += "如以下SQL\r\n";
            sql += "select sum(salesamount) from sales where dateid >= ##DateID-7## and ateid <= '##DateID-1##' \r\n";
            sql += "比如选择时间颗粒度Day，格式为yyyy - mm - dd,则语句将变为\r\n";
            sql += "select sum(salesamount) from sales where dateid = >= {2} and ateid <= {3}\r\n";
            sql += "比如选择时间颗粒度Month，格式为yyyymm,则语句将变为\r\n";
            sql += "select sum(salesamount) from sales where dateid = >= {4} and dateid <= {5}\r\n";

            var currentday = DateTime.Now.ToString("yyyy-MM-dd");
            var currentmonth = DateTime.Now.ToString("yyyyMM");
            var p1day = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            var p7day = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
            var p1month = DateTime.Now.AddMonths(-1).ToString("yyyyMM");
            var p7month = DateTime.Now.AddMonths(-7).ToString("yyyyMM");

            txtSql.Text = string.Format(sql, currentday, currentmonth, p1day, p7day, p1month, p7month);
        }

        public void InitialMonitorItem(string monitorItemId)
        {
            //IMSDBHelper<monitoritem> helper = new IMSDBHelper<monitoritem>();

            //var monitorItemList = helper.FindList(x => x.Id == monitorItemId);
            //if(monitorItemList != null && monitorItemList.Count >0)
            //{
            //    var item = monitorItemList[0];
            //    txtId.Text = item.Id;
            //    cbCompanyCode.SelectedValue = item.CompanyCode;
            //    cbProject.SelectedValue = item.ProjectCode;
            //    cbMonitor.SelectedValue = item.MonitorCode;
            //    txtMonitorItemCode.Text = item.MonitorItemCode;
            //    txtMonitorItemName.Text = item.MonitorItemName;
            //    txtDesc.Text = item.Desc;
            //    cbConfigDB.SelectedValue = item.DbCode;
            //    txtCron.Text = item.cron;
            //    //txtsql.Text = item.Command;
            //}
        }





        public void InitialConfigDB(string companyCode,int dbtype)
        {

            IMSDBHelper<configdb> helper = new IMSDBHelper<configdb>();
            var list = helper.FindList(x => x.companycode == companyCode && x.dbtype == dbtype);
            if (list != null && list.Count > 0)
            {
                cbConfigDB.DataSource = list;
                cbConfigDB.ValueMember = "dbcode";
                cbConfigDB.DisplayMember = "dbname";
            }
            else
            {
                cbConfigDB.DataSource = null;
                cbConfigDB.ValueMember = "dbcode";
                cbConfigDB.DisplayMember = "dbname";
            }


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

    

        private void cbCompanyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDbSource();

        }


        void ChangeDbSource()
        {
            var companycode = cbCompanyCode.SelectedValue;
            if (companycode == null)
            {
                return;
            }


            var dbtype = 0;
            if (cbDBType.SelectedValue != null && !string.IsNullOrEmpty(cbDBType.SelectedValue.ToString()))
            {
                dbtype = Int32.Parse(cbDBType.SelectedValue.ToString());
            }

            InitialConfigDB(companycode.ToString(), dbtype);
            InitialProject(companycode.ToString());
        }

        private void InitialProject(string companycode)
        {
            IMSDBHelper<project> db = new IMSDBHelper<project>();
            var list = db.FindList(x => x.CompanyCode == companycode);
            if (list == null)
            {
                list = new List<project>();
            }

            cbProject.DataSource = list;
            cbProject.ValueMember = "ProjectCode";
            cbProject.DisplayMember = "ProjectName";

            cbProject.SelectedIndex = -1;
        }

        private void cbMonitorGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var companycode = cbCompanyCode.SelectedValue;

            var monitorCode = cbProject.SelectedValue;

            if (companycode == null || monitorCode== null)
            {
                return;
            }
            InitialMonitor(companycode.ToString(), monitorCode.ToString());
        }

        private void InitialMonitor(string companycode,string projectCode)
        {
            IMSDBHelper<monitor> db = new IMSDBHelper<monitor>();
            var list = db.FindList(x => x.companycode == companycode && x.projectcode == projectCode);
            if (list == null)
            {
                list = new List<monitor>();
            }

            cbMonitor.DataSource = list;
            cbMonitor.ValueMember = "monitorcode";
            cbMonitor.DisplayMember = "monitorname";

            //cbMonitor.SelectedIndex = -1;
        }

      
    

        private void btnSave_Click(object sender, EventArgs e)
        {
            var item = new monitoritem();



            if (!string.IsNullOrEmpty(txtId.Text))
            {
                item.id = Int32.Parse(txtId.Text);
            }
          

            if (string.IsNullOrEmpty(cbCompanyCode.Text))
            {
                MessageBox.Show("请选择公司");
                return;
            }
            item.companycode = cbCompanyCode.SelectedValue.ToString();

            if (string.IsNullOrEmpty(cbProject.Text))
            {
                MessageBox.Show("请选择项目");
                return;
            }
            item.projectcode = cbProject.SelectedValue.ToString();


            if (string.IsNullOrEmpty(cbMonitor.Text))
            {
                MessageBox.Show("请选择监控/报表");
                return;
            }
            item.monitorcode = cbMonitor.SelectedValue.ToString();


            if (string.IsNullOrEmpty(txtMonitorItemCode.Text))
            {
                MessageBox.Show("请输入监控编号");
                return;
            }
            item.monitoritemcode = txtMonitorItemCode.Text;

            if (string.IsNullOrEmpty(txtMonitorItemName.Text))
            {
                MessageBox.Show("请输入监控名称");
                return;
            }
            item.monitoritemname = txtMonitorItemName.Text;

            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("请输入监控项描述");
                return;
            }
            item.description = txtDesc.Text;


            item.dbtype = Int32.Parse(cbDBType.SelectedValue.ToString());


            if(cbConfigDB.SelectedValue == null)
            {
                MessageBox.Show("请选择数据源");
                return;
            }
            item.configdbcode = cbConfigDB.SelectedValue.ToString();


            if (cmbdaypart.SelectedValue == null)
            {
                MessageBox.Show("时间颗粒度");
                return;
            }
            item.daypart = Int32.Parse(cmbdaypart.SelectedValue.ToString());

            item.dateidformatprefix = txtdateidformatprefix.Text.Trim();


            if (cmbdateidformat.SelectedValue == null)
            {
                MessageBox.Show("时间格式");
                return;
            }
            item.dateidformat = Int32.Parse(cmbdateidformat.SelectedValue.ToString());

            item.dateidformatsuffix = txtdateidformatsuffix.Text.Trim();

            item.resultformat = rbresultformat_single.Checked ? 1 : 2;

            item.comparemode = rbcomparemode_fixedvalue.Checked ? 1 : (rbcomparemode_fixedvaluerange.Checked ? 2 : 3);

            if(rbcomparemode_fixedvalue.Checked && (string.IsNullOrEmpty(txtcomparemodefixedvalue.Text) || !CommonUtility.IsNumeric(txtcomparemodefixedvalue.Text)))
            {
                MessageBox.Show("请正确输入固定值");
                return;
            }

            if (rbcomparemode_fixedvalue.Checked)
            {
                item.comparemodefixedvalue = Decimal.Parse(txtcomparemodefixedvalue.Text);
            }




            if (rbcomparemode_fixedvaluerange.Checked 
                && (string.IsNullOrEmpty(txtcomparemoderangevalue.Text) 
                    || string.IsNullOrEmpty(txtcomparemodethreshold.Text) 
                    || !CommonUtility.IsNumeric(txtcomparemoderangevalue.Text) 
                    || !CommonUtility.IsNumeric(txtcomparemodethreshold.Text)
                    ) 
                )
            {
                MessageBox.Show("请正确指定值范围和百分比");
                return;
            }
            if (rbcomparemode_fixedvaluerange.Checked)
            {
                item.comparemoderangevalue = Decimal.Parse(txtcomparemoderangevalue.Text);
                item.comparemodethreshold = Decimal.Parse(txtcomparemodethreshold.Text);
            }


            if (rbcomparemode_average.Checked
                && (cmbTimerange.SelectedValue == null || string.IsNullOrEmpty(comparemodethreshold2.Text)
                    || !CommonUtility.IsNumeric(comparemodethreshold2.Text)
                    )
                )
            {
                MessageBox.Show("请正确输入最近平均值范围和百分比");
                return;
            }

            if (rbcomparemode_average.Checked)
            {
                item.comparemoderangevalue = Decimal.Parse(cmbTimerange.SelectedValue.ToString());
                item.comparemodethreshold = Decimal.Parse(comparemodethreshold2.Text);
            }

            item.enabled = chkEnable.Checked;


            if (chkEnable.Checked && string.IsNullOrEmpty(txtCron.Text))
            {
                MessageBox.Show("请输入执行频率");
                return;
            }
            item.cron = txtCron.Text;

            item.enbalefailureretry = chkenbalefailureretry.Checked;
            item.failureretryexecuteinterval = Int32.Parse(cmbRetryInterval.SelectedValue.ToString());

            item.enablecache = chkenablecache.Checked;

            if(chkenablecache.Checked)
            {
                if(string.IsNullOrEmpty(txtcachetime.Text) || !CommonUtility.IsNumeric(txtcachetime.Text) || cmbCacheCycle.SelectedValue == null)
                {
                    MessageBox.Show("请正确输入缓存时间");
                    return;
                }
                item.cachetime = Int32.Parse(txtcachetime.Text);
                item.cachetimedaypart = Int32.Parse(cmbCacheCycle.SelectedValue.ToString());
            }

            item.enablereflash = chkreflash.Checked;

            if(chkreflash.Checked)
            {
                if (string.IsNullOrEmpty(txtreflashtime.Text) || !CommonUtility.IsNumeric(txtreflashtime.Text) || cmbTimerange.SelectedValue == null)
                {
                    MessageBox.Show("请正确输入重刷时间");
                    return;
                }
                item.reflashtime = Int32.Parse(txtreflashtime.Text);
                item.reflashdaypart = Int32.Parse(cmbTimerange.SelectedValue.ToString());
            }

            item.enablesuccessnotify = chkenablesuccessnotify.Checked;
            item.successemails = txtsuccessemails.Text;

            item.enablefailurenotify = chkenablefailurenotify.Checked;
            item.failureemails = txtfailureemails.Text;

            item.executesql = txtSql.Text;



            //插入或者更新monitoritem

            IMSDBHelper<monitoritem> monitoritemDbHelper = new IMSDBHelper<monitoritem>();
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                monitoritemDbHelper.Update(item);
            }
            else
            {
                monitoritemDbHelper.Add(item);
            }





            MessageBox.Show("保存成功");
          





        }


        Boolean textboxHasText = false;

        private void txtSql_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                txtSql.Text = "";

            txtSql.ForeColor = Color.Black;
        }

        private void txtSql_Leave(object sender, EventArgs e)
        {
            if (txtSql.Text == "")
            {
                InitialSql();
                txtSql.ForeColor = Color.LightGray;
                textboxHasText = false;
            }
            else
                textboxHasText = true;
        }

        private void cbDBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDbSource();
        }
    }
}
