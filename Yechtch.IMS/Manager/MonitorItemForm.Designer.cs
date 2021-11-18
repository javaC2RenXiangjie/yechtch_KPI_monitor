namespace Yechtch.IMS.Manager
{
    partial class MonitorItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.cbCompanyCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMonitorItemName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMonitorItemCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbConfigDB = new System.Windows.Forms.ComboBox();
            this.cbDBType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbresultformat_multiple = new System.Windows.Forms.RadioButton();
            this.rbresultformat_single = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtdateidformatsuffix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdateidformatprefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbdateidformat = new System.Windows.Forms.ComboBox();
            this.cmbdaypart = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkenablefailurenotify = new System.Windows.Forms.CheckBox();
            this.chkenablesuccessnotify = new System.Windows.Forms.CheckBox();
            this.txtfailureemails = new System.Windows.Forms.TextBox();
            this.txtsuccessemails = new System.Windows.Forms.TextBox();
            this.txtreflashtime = new System.Windows.Forms.TextBox();
            this.cmbTimerange = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkreflash = new System.Windows.Forms.CheckBox();
            this.txtcachetime = new System.Windows.Forms.TextBox();
            this.cmbCacheCycle = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkenablecache = new System.Windows.Forms.CheckBox();
            this.cmbRetryInterval = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkenbalefailureretry = new System.Windows.Forms.CheckBox();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCron = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comparemodethreshold2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbTimeRange = new System.Windows.Forms.ComboBox();
            this.txtcomparemoderangevalue = new System.Windows.Forms.TextBox();
            this.rbcomparemode_average = new System.Windows.Forms.RadioButton();
            this.rbcomparemode_fixedvaluerange = new System.Windows.Forms.RadioButton();
            this.rbcomparemode_fixedvalue = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.txtcomparemodethreshold = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtcomparemodefixedvalue = new System.Windows.Forms.TextBox();
            this.tabDataKpi = new System.Windows.Forms.TabControl();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabDataKpi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbMonitor);
            this.groupBox3.Controls.Add(this.cbProject);
            this.groupBox3.Controls.Add(this.cbCompanyCode);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDesc);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMonitorItemName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtMonitorItemCode);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(25, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 607);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基本信息";
            // 
            // cbMonitor
            // 
            this.cbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(18, 194);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(188, 20);
            this.cbMonitor.TabIndex = 18;
            // 
            // cbProject
            // 
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(18, 142);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(188, 20);
            this.cbProject.TabIndex = 17;
            this.cbProject.SelectedIndexChanged += new System.EventHandler(this.cbMonitorGroup_SelectedIndexChanged);
            // 
            // cbCompanyCode
            // 
            this.cbCompanyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompanyCode.FormattingEnabled = true;
            this.cbCompanyCode.Location = new System.Drawing.Point(18, 89);
            this.cbCompanyCode.Name = "cbCompanyCode";
            this.cbCompanyCode.Size = new System.Drawing.Size(188, 20);
            this.cbCompanyCode.TabIndex = 16;
            this.cbCompanyCode.SelectedIndexChanged += new System.EventHandler(this.cbCompanyCode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "监控/报表";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "项目";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "描述信息";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(20, 354);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(188, 86);
            this.txtDesc.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "监控项/指标名称";
            // 
            // txtMonitorItemName
            // 
            this.txtMonitorItemName.Location = new System.Drawing.Point(20, 300);
            this.txtMonitorItemName.Name = "txtMonitorItemName";
            this.txtMonitorItemName.Size = new System.Drawing.Size(188, 21);
            this.txtMonitorItemName.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "监控项/指标编号";
            // 
            // txtMonitorItemCode
            // 
            this.txtMonitorItemCode.Location = new System.Drawing.Point(21, 252);
            this.txtMonitorItemCode.Name = "txtMonitorItemCode";
            this.txtMonitorItemCode.Size = new System.Drawing.Size(188, 21);
            this.txtMonitorItemCode.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "公司";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(19, 44);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(188, 21);
            this.txtId.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "编号";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 634);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbConfigDB);
            this.groupBox2.Controls.Add(this.cbDBType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(263, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 62);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据源设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "数据源类型";
            // 
            // cbConfigDB
            // 
            this.cbConfigDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConfigDB.FormattingEnabled = true;
            this.cbConfigDB.Location = new System.Drawing.Point(556, 20);
            this.cbConfigDB.Name = "cbConfigDB";
            this.cbConfigDB.Size = new System.Drawing.Size(301, 20);
            this.cbConfigDB.TabIndex = 35;
            // 
            // cbDBType
            // 
            this.cbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBType.FormattingEnabled = true;
            this.cbDBType.Location = new System.Drawing.Point(110, 20);
            this.cbDBType.Name = "cbDBType";
            this.cbDBType.Size = new System.Drawing.Size(189, 20);
            this.cbDBType.TabIndex = 45;
            this.cbDBType.SelectedIndexChanged += new System.EventHandler(this.cbDBType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "数据源";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(897, 668);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataKPI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbresultformat_multiple);
            this.groupBox7.Controls.Add(this.rbresultformat_single);
            this.groupBox7.Location = new System.Drawing.Point(516, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(366, 60);
            this.groupBox7.TabIndex = 59;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "结果设置";
            // 
            // rbresultformat_multiple
            // 
            this.rbresultformat_multiple.AutoSize = true;
            this.rbresultformat_multiple.Location = new System.Drawing.Point(162, 21);
            this.rbresultformat_multiple.Name = "rbresultformat_multiple";
            this.rbresultformat_multiple.Size = new System.Drawing.Size(161, 16);
            this.rbresultformat_multiple.TabIndex = 1;
            this.rbresultformat_multiple.Text = "包含多个DateId和DataKPI";
            this.rbresultformat_multiple.UseVisualStyleBackColor = true;
            // 
            // rbresultformat_single
            // 
            this.rbresultformat_single.AutoSize = true;
            this.rbresultformat_single.Checked = true;
            this.rbresultformat_single.Location = new System.Drawing.Point(36, 21);
            this.rbresultformat_single.Name = "rbresultformat_single";
            this.rbresultformat_single.Size = new System.Drawing.Size(101, 16);
            this.rbresultformat_single.TabIndex = 0;
            this.rbresultformat_single.TabStop = true;
            this.rbresultformat_single.Text = "只包含单个KPI";
            this.rbresultformat_single.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtdateidformatsuffix);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtdateidformatprefix);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.cmbdateidformat);
            this.groupBox6.Controls.Add(this.cmbdaypart);
            this.groupBox6.Location = new System.Drawing.Point(8, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(495, 69);
            this.groupBox6.TabIndex = 54;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DateIdFormat";
            // 
            // txtdateidformatsuffix
            // 
            this.txtdateidformatsuffix.Location = new System.Drawing.Point(401, 42);
            this.txtdateidformatsuffix.Name = "txtdateidformatsuffix";
            this.txtdateidformatsuffix.Size = new System.Drawing.Size(72, 21);
            this.txtdateidformatsuffix.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 12);
            this.label7.TabIndex = 50;
            this.label7.Text = "|——前缀———————时间格式——————后缀——|";
            // 
            // txtdateidformatprefix
            // 
            this.txtdateidformatprefix.Location = new System.Drawing.Point(177, 42);
            this.txtdateidformatprefix.Name = "txtdateidformatprefix";
            this.txtdateidformatprefix.Size = new System.Drawing.Size(72, 21);
            this.txtdateidformatprefix.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "时间颗粒度";
            // 
            // cmbdateidformat
            // 
            this.cmbdateidformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdateidformat.FormattingEnabled = true;
            this.cmbdateidformat.Items.AddRange(new object[] {
            "yyyymmdd",
            "yyyy-mm-dd",
            "yymmdd",
            "yy-mm-dd"});
            this.cmbdateidformat.Location = new System.Drawing.Point(259, 43);
            this.cmbdateidformat.Name = "cmbdateidformat";
            this.cmbdateidformat.Size = new System.Drawing.Size(132, 20);
            this.cmbdateidformat.TabIndex = 47;
            // 
            // cmbdaypart
            // 
            this.cmbdaypart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdaypart.FormattingEnabled = true;
            this.cmbdaypart.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month",
            "Year"});
            this.cmbdaypart.Location = new System.Drawing.Point(25, 43);
            this.cmbdaypart.Name = "cmbdaypart";
            this.cmbdaypart.Size = new System.Drawing.Size(120, 20);
            this.cmbdaypart.TabIndex = 37;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSql);
            this.groupBox5.Location = new System.Drawing.Point(9, 412);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(873, 240);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "脚本设置（SQL）";
            // 
            // txtSql
            // 
            this.txtSql.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSql.Location = new System.Drawing.Point(6, 20);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(861, 212);
            this.txtSql.TabIndex = 19;
            this.txtSql.Enter += new System.EventHandler(this.txtSql_Enter);
            this.txtSql.Leave += new System.EventHandler(this.txtSql_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkenablefailurenotify);
            this.groupBox1.Controls.Add(this.chkenablesuccessnotify);
            this.groupBox1.Controls.Add(this.txtfailureemails);
            this.groupBox1.Controls.Add(this.txtsuccessemails);
            this.groupBox1.Controls.Add(this.txtreflashtime);
            this.groupBox1.Controls.Add(this.cmbTimerange);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.chkreflash);
            this.groupBox1.Controls.Add(this.txtcachetime);
            this.groupBox1.Controls.Add(this.cmbCacheCycle);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.chkenablecache);
            this.groupBox1.Controls.Add(this.cmbRetryInterval);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.chkenbalefailureretry);
            this.groupBox1.Controls.Add(this.chkEnable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCron);
            this.groupBox1.Location = new System.Drawing.Point(9, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 191);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置区";
            // 
            // chkenablefailurenotify
            // 
            this.chkenablefailurenotify.AutoSize = true;
            this.chkenablefailurenotify.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkenablefailurenotify.Location = new System.Drawing.Point(507, 103);
            this.chkenablefailurenotify.Name = "chkenablefailurenotify";
            this.chkenablefailurenotify.Size = new System.Drawing.Size(96, 16);
            this.chkenablefailurenotify.TabIndex = 38;
            this.chkenablefailurenotify.Text = "失败接收邮件";
            this.chkenablefailurenotify.UseVisualStyleBackColor = true;
            // 
            // chkenablesuccessnotify
            // 
            this.chkenablesuccessnotify.AutoSize = true;
            this.chkenablesuccessnotify.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkenablesuccessnotify.Location = new System.Drawing.Point(507, 22);
            this.chkenablesuccessnotify.Name = "chkenablesuccessnotify";
            this.chkenablesuccessnotify.Size = new System.Drawing.Size(96, 16);
            this.chkenablesuccessnotify.TabIndex = 37;
            this.chkenablesuccessnotify.Text = "成功接收邮件";
            this.chkenablesuccessnotify.UseVisualStyleBackColor = true;
            // 
            // txtfailureemails
            // 
            this.txtfailureemails.Location = new System.Drawing.Point(507, 120);
            this.txtfailureemails.Multiline = true;
            this.txtfailureemails.Name = "txtfailureemails";
            this.txtfailureemails.Size = new System.Drawing.Size(352, 53);
            this.txtfailureemails.TabIndex = 36;
            // 
            // txtsuccessemails
            // 
            this.txtsuccessemails.Location = new System.Drawing.Point(507, 44);
            this.txtsuccessemails.Multiline = true;
            this.txtsuccessemails.Name = "txtsuccessemails";
            this.txtsuccessemails.Size = new System.Drawing.Size(352, 53);
            this.txtsuccessemails.TabIndex = 34;
            // 
            // txtreflashtime
            // 
            this.txtreflashtime.Location = new System.Drawing.Point(230, 152);
            this.txtreflashtime.Name = "txtreflashtime";
            this.txtreflashtime.Size = new System.Drawing.Size(104, 21);
            this.txtreflashtime.TabIndex = 32;
            // 
            // cmbTimerange
            // 
            this.cmbTimerange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimerange.FormattingEnabled = true;
            this.cmbTimerange.Items.AddRange(new object[] {
            "Minute",
            "Hour",
            "Day",
            "Week",
            "Month"});
            this.cmbTimerange.Location = new System.Drawing.Point(340, 153);
            this.cmbTimerange.Name = "cmbTimerange";
            this.cmbTimerange.Size = new System.Drawing.Size(111, 20);
            this.cmbTimerange.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(115, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "时间范围";
            // 
            // chkreflash
            // 
            this.chkreflash.AutoSize = true;
            this.chkreflash.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkreflash.Location = new System.Drawing.Point(17, 157);
            this.chkreflash.Name = "chkreflash";
            this.chkreflash.Size = new System.Drawing.Size(72, 16);
            this.chkreflash.TabIndex = 29;
            this.chkreflash.Text = "数据重刷";
            this.chkreflash.UseVisualStyleBackColor = true;
            // 
            // txtcachetime
            // 
            this.txtcachetime.Location = new System.Drawing.Point(230, 108);
            this.txtcachetime.Name = "txtcachetime";
            this.txtcachetime.Size = new System.Drawing.Size(104, 21);
            this.txtcachetime.TabIndex = 28;
            // 
            // cmbCacheCycle
            // 
            this.cmbCacheCycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCacheCycle.FormattingEnabled = true;
            this.cmbCacheCycle.Items.AddRange(new object[] {
            "Minute",
            "Hour",
            "Day",
            "Week",
            "Month"});
            this.cmbCacheCycle.Location = new System.Drawing.Point(340, 109);
            this.cmbCacheCycle.Name = "cmbCacheCycle";
            this.cmbCacheCycle.Size = new System.Drawing.Size(111, 20);
            this.cmbCacheCycle.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(115, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 26;
            this.label15.Text = "缓存时间";
            // 
            // chkenablecache
            // 
            this.chkenablecache.AutoSize = true;
            this.chkenablecache.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkenablecache.Location = new System.Drawing.Point(17, 113);
            this.chkenablecache.Name = "chkenablecache";
            this.chkenablecache.Size = new System.Drawing.Size(72, 16);
            this.chkenablecache.TabIndex = 25;
            this.chkenablecache.Text = "启用缓存";
            this.chkenablecache.UseVisualStyleBackColor = true;
            // 
            // cmbRetryInterval
            // 
            this.cmbRetryInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRetryInterval.FormattingEnabled = true;
            this.cmbRetryInterval.Items.AddRange(new object[] {
            "10",
            "30",
            "60"});
            this.cmbRetryInterval.Location = new System.Drawing.Point(230, 68);
            this.cmbRetryInterval.Name = "cmbRetryInterval";
            this.cmbRetryInterval.Size = new System.Drawing.Size(221, 20);
            this.cmbRetryInterval.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "执行频率(分钟)";
            // 
            // chkenbalefailureretry
            // 
            this.chkenbalefailureretry.AutoSize = true;
            this.chkenbalefailureretry.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkenbalefailureretry.Location = new System.Drawing.Point(17, 70);
            this.chkenbalefailureretry.Name = "chkenbalefailureretry";
            this.chkenbalefailureretry.Size = new System.Drawing.Size(72, 16);
            this.chkenbalefailureretry.TabIndex = 21;
            this.chkenbalefailureretry.Text = "失败重试";
            this.chkenbalefailureretry.UseVisualStyleBackColor = true;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEnable.Location = new System.Drawing.Point(17, 29);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(72, 16);
            this.chkEnable.TabIndex = 20;
            this.chkEnable.Text = "是否启用";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cron";
            // 
            // txtCron
            // 
            this.txtCron.Location = new System.Drawing.Point(172, 26);
            this.txtCron.Name = "txtCron";
            this.txtCron.Size = new System.Drawing.Size(279, 21);
            this.txtCron.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.comparemodethreshold2);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.cbTimeRange);
            this.groupBox4.Controls.Add(this.txtcomparemoderangevalue);
            this.groupBox4.Controls.Add(this.rbcomparemode_average);
            this.groupBox4.Controls.Add(this.rbcomparemode_fixedvaluerange);
            this.groupBox4.Controls.Add(this.rbcomparemode_fixedvalue);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtcomparemodethreshold);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.txtcomparemodefixedvalue);
            this.groupBox4.Location = new System.Drawing.Point(9, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(873, 133);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "KPI 比对设置";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(833, 105);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(11, 12);
            this.label26.TabIndex = 58;
            this.label26.Text = "%";
            // 
            // comparemodethreshold2
            // 
            this.comparemodethreshold2.Location = new System.Drawing.Point(558, 99);
            this.comparemodethreshold2.Name = "comparemodethreshold2";
            this.comparemodethreshold2.Size = new System.Drawing.Size(295, 21);
            this.comparemodethreshold2.TabIndex = 57;
            this.comparemodethreshold2.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(476, 99);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 12);
            this.label25.TabIndex = 56;
            this.label25.Text = "阈值范围";
            // 
            // cbTimeRange
            // 
            this.cbTimeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeRange.FormattingEnabled = true;
            this.cbTimeRange.Items.AddRange(new object[] {
            "7",
            "14",
            "30",
            "60"});
            this.cbTimeRange.Location = new System.Drawing.Point(188, 97);
            this.cbTimeRange.Name = "cbTimeRange";
            this.cbTimeRange.Size = new System.Drawing.Size(263, 20);
            this.cbTimeRange.TabIndex = 51;
            // 
            // txtcomparemoderangevalue
            // 
            this.txtcomparemoderangevalue.Location = new System.Drawing.Point(190, 58);
            this.txtcomparemoderangevalue.Name = "txtcomparemoderangevalue";
            this.txtcomparemoderangevalue.Size = new System.Drawing.Size(261, 21);
            this.txtcomparemoderangevalue.TabIndex = 55;
            // 
            // rbcomparemode_average
            // 
            this.rbcomparemode_average.AutoSize = true;
            this.rbcomparemode_average.Location = new System.Drawing.Point(24, 101);
            this.rbcomparemode_average.Name = "rbcomparemode_average";
            this.rbcomparemode_average.Size = new System.Drawing.Size(107, 16);
            this.rbcomparemode_average.TabIndex = 54;
            this.rbcomparemode_average.Text = "最近平均值范围";
            this.rbcomparemode_average.UseVisualStyleBackColor = true;
            // 
            // rbcomparemode_fixedvaluerange
            // 
            this.rbcomparemode_fixedvaluerange.AutoSize = true;
            this.rbcomparemode_fixedvaluerange.Location = new System.Drawing.Point(24, 63);
            this.rbcomparemode_fixedvaluerange.Name = "rbcomparemode_fixedvaluerange";
            this.rbcomparemode_fixedvaluerange.Size = new System.Drawing.Size(83, 16);
            this.rbcomparemode_fixedvaluerange.TabIndex = 53;
            this.rbcomparemode_fixedvaluerange.Text = "指定值范围";
            this.rbcomparemode_fixedvaluerange.UseVisualStyleBackColor = true;
            // 
            // rbcomparemode_fixedvalue
            // 
            this.rbcomparemode_fixedvalue.AutoSize = true;
            this.rbcomparemode_fixedvalue.Checked = true;
            this.rbcomparemode_fixedvalue.Location = new System.Drawing.Point(24, 26);
            this.rbcomparemode_fixedvalue.Name = "rbcomparemode_fixedvalue";
            this.rbcomparemode_fixedvalue.Size = new System.Drawing.Size(59, 16);
            this.rbcomparemode_fixedvalue.TabIndex = 51;
            this.rbcomparemode_fixedvalue.TabStop = true;
            this.rbcomparemode_fixedvalue.Text = "指定值";
            this.rbcomparemode_fixedvalue.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(834, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 50;
            this.label17.Text = "%";
            // 
            // txtcomparemodethreshold
            // 
            this.txtcomparemodethreshold.Location = new System.Drawing.Point(558, 62);
            this.txtcomparemodethreshold.Name = "txtcomparemodethreshold";
            this.txtcomparemodethreshold.Size = new System.Drawing.Size(295, 21);
            this.txtcomparemodethreshold.TabIndex = 49;
            this.txtcomparemodethreshold.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(476, 62);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 48;
            this.label24.Text = "阈值范围";
            // 
            // txtcomparemodefixedvalue
            // 
            this.txtcomparemodefixedvalue.Location = new System.Drawing.Point(190, 25);
            this.txtcomparemodefixedvalue.Name = "txtcomparemodefixedvalue";
            this.txtcomparemodefixedvalue.Size = new System.Drawing.Size(261, 21);
            this.txtcomparemodefixedvalue.TabIndex = 37;
            // 
            // tabDataKpi
            // 
            this.tabDataKpi.Controls.Add(this.tabPage1);
            this.tabDataKpi.Location = new System.Drawing.Point(263, 92);
            this.tabDataKpi.Name = "tabDataKpi";
            this.tabDataKpi.SelectedIndex = 0;
            this.tabDataKpi.Size = new System.Drawing.Size(905, 694);
            this.tabDataKpi.TabIndex = 53;
            // 
            // MonitorItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 791);
            this.Controls.Add(this.tabDataKpi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSave);
            this.Name = "MonitorItemForm";
            this.Text = "数据KPI监控项目";
            this.Load += new System.EventHandler(this.MonitorItem_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabDataKpi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMonitorItemName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMonitorItemCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.ComboBox cbCompanyCode;
        private System.Windows.Forms.ComboBox cbMonitor;
     
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbConfigDB;
        private System.Windows.Forms.ComboBox cbDBType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbdaypart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfailureemails;
        private System.Windows.Forms.TextBox txtsuccessemails;
        private System.Windows.Forms.TextBox txtreflashtime;
        private System.Windows.Forms.ComboBox cmbTimerange;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkreflash;
        private System.Windows.Forms.TextBox txtcachetime;
        private System.Windows.Forms.ComboBox cmbCacheCycle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkenablecache;
        private System.Windows.Forms.ComboBox cmbRetryInterval;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkenbalefailureretry;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCron;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox comparemodethreshold2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbTimeRange;
        private System.Windows.Forms.TextBox txtcomparemoderangevalue;
        private System.Windows.Forms.RadioButton rbcomparemode_average;
        private System.Windows.Forms.RadioButton rbcomparemode_fixedvaluerange;
        private System.Windows.Forms.RadioButton rbcomparemode_fixedvalue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtcomparemodethreshold;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtcomparemodefixedvalue;
        private System.Windows.Forms.TabControl tabDataKpi;
        private System.Windows.Forms.ComboBox cmbdateidformat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdateidformatsuffix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdateidformatprefix;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbresultformat_multiple;
        private System.Windows.Forms.RadioButton rbresultformat_single;
        private System.Windows.Forms.CheckBox chkenablesuccessnotify;
        private System.Windows.Forms.CheckBox chkenablefailurenotify;
    }
}