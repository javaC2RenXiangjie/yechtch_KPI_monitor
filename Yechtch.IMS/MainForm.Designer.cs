namespace Yechtch.IMS
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监控项管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.指标管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监控配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监控项配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据源配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.监控ToolStripMenuItem,
            this.指标管理ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 监控ToolStripMenuItem
            // 
            this.监控ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.监控项管理ToolStripMenuItem});
            this.监控ToolStripMenuItem.Name = "监控ToolStripMenuItem";
            this.监控ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.监控ToolStripMenuItem.Text = "监控";
            // 
            // 监控项管理ToolStripMenuItem
            // 
            this.监控项管理ToolStripMenuItem.Name = "监控项管理ToolStripMenuItem";
            this.监控项管理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.监控项管理ToolStripMenuItem.Text = "监控项管理";
            this.监控项管理ToolStripMenuItem.Click += new System.EventHandler(this.监控项管理ToolStripMenuItem_Click);
            // 
            // 指标管理ToolStripMenuItem
            // 
            this.指标管理ToolStripMenuItem.Name = "指标管理ToolStripMenuItem";
            this.指标管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.指标管理ToolStripMenuItem.Text = "指标管理";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户设置ToolStripMenuItem,
            this.项目配置ToolStripMenuItem,
            this.监控配置ToolStripMenuItem,
            this.监控项配置ToolStripMenuItem,
            this.数据源配置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "配置";
            // 
            // 客户设置ToolStripMenuItem
            // 
            this.客户设置ToolStripMenuItem.Name = "客户设置ToolStripMenuItem";
            this.客户设置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.客户设置ToolStripMenuItem.Text = "客户设置";
            this.客户设置ToolStripMenuItem.Click += new System.EventHandler(this.客户设置ToolStripMenuItem_Click);
            // 
            // 项目配置ToolStripMenuItem
            // 
            this.项目配置ToolStripMenuItem.Name = "项目配置ToolStripMenuItem";
            this.项目配置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.项目配置ToolStripMenuItem.Text = "项目配置";
            this.项目配置ToolStripMenuItem.Click += new System.EventHandler(this.项目配置ToolStripMenuItem_Click);
            // 
            // 监控配置ToolStripMenuItem
            // 
            this.监控配置ToolStripMenuItem.Name = "监控配置ToolStripMenuItem";
            this.监控配置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.监控配置ToolStripMenuItem.Text = "监控配置";
            this.监控配置ToolStripMenuItem.Click += new System.EventHandler(this.监控配置ToolStripMenuItem_Click);
            // 
            // 监控项配置ToolStripMenuItem
            // 
            this.监控项配置ToolStripMenuItem.Name = "监控项配置ToolStripMenuItem";
            this.监控项配置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.监控项配置ToolStripMenuItem.Text = "监控项配置";
            this.监控项配置ToolStripMenuItem.Click += new System.EventHandler(this.监控项配置ToolStripMenuItem_Click);
            // 
            // 数据源配置ToolStripMenuItem
            // 
            this.数据源配置ToolStripMenuItem.Name = "数据源配置ToolStripMenuItem";
            this.数据源配置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.数据源配置ToolStripMenuItem.Text = "数据源配置";
            this.数据源配置ToolStripMenuItem.Click += new System.EventHandler(this.数据源配置ToolStripMenuItem_Click);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监控ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 指标管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监控配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监控项配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据源配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监控项管理ToolStripMenuItem;
    }
}

