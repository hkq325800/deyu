namespace MoralEvaluated
{
    partial class FrmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndex));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuItmEva = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmPointExchange = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmSummarize = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmUserAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmAdAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmAdStu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmBaseConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmClass = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmEvaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmSemester = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmRead = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItmEva,
            this.MnuItmUserAdmin,
            this.MnuItmBaseConfig,
            this.MnuItmRead,
            this.MnuItmPersonInfo,
            this.MnuItmWindows,
            this.MnuItmAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuItmEva
            // 
            this.MnuItmEva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItmPointExchange,
            this.MnuItmSummarize,
            this.MnuItmHistory});
            this.MnuItmEva.Name = "MnuItmEva";
            this.MnuItmEva.Size = new System.Drawing.Size(83, 20);
            this.MnuItmEva.Text = "综合测评(&S)";
            // 
            // MnuItmPointExchange
            // 
            this.MnuItmPointExchange.Name = "MnuItmPointExchange";
            this.MnuItmPointExchange.Size = new System.Drawing.Size(136, 22);
            this.MnuItmPointExchange.Text = "加减分(&P)";
            this.MnuItmPointExchange.Click += new System.EventHandler(this.MnuItmPointExchange_Click);
            // 
            // MnuItmSummarize
            // 
            this.MnuItmSummarize.Name = "MnuItmSummarize";
            this.MnuItmSummarize.Size = new System.Drawing.Size(136, 22);
            this.MnuItmSummarize.Text = "测评汇总(&S)";
            this.MnuItmSummarize.Click += new System.EventHandler(this.MnuItmSummarize_Click);
            // 
            // MnuItmHistory
            // 
            this.MnuItmHistory.Name = "MnuItmHistory";
            this.MnuItmHistory.Size = new System.Drawing.Size(136, 22);
            this.MnuItmHistory.Text = "历史纪录(&H)";
            this.MnuItmHistory.Click += new System.EventHandler(this.MnuItmHistory_Click);
            // 
            // MnuItmUserAdmin
            // 
            this.MnuItmUserAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItmAdAdmin,
            this.MnuItmAdStu});
            this.MnuItmUserAdmin.Name = "MnuItmUserAdmin";
            this.MnuItmUserAdmin.Size = new System.Drawing.Size(83, 20);
            this.MnuItmUserAdmin.Text = "用户管理(&U)";
            // 
            // MnuItmAdAdmin
            // 
            this.MnuItmAdAdmin.Name = "MnuItmAdAdmin";
            this.MnuItmAdAdmin.Size = new System.Drawing.Size(124, 22);
            this.MnuItmAdAdmin.Text = "管理员(&A)";
            this.MnuItmAdAdmin.Click += new System.EventHandler(this.MnuItmAdAdmin_Click);
            // 
            // MnuItmAdStu
            // 
            this.MnuItmAdStu.Name = "MnuItmAdStu";
            this.MnuItmAdStu.Size = new System.Drawing.Size(124, 22);
            this.MnuItmAdStu.Text = "学生(&S)";
            this.MnuItmAdStu.Click += new System.EventHandler(this.MnuItmAdStu_Click);
            // 
            // MnuItmBaseConfig
            // 
            this.MnuItmBaseConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItmClass,
            this.MnuItmEvaItem,
            this.MnuItmSemester});
            this.MnuItmBaseConfig.Name = "MnuItmBaseConfig";
            this.MnuItmBaseConfig.Size = new System.Drawing.Size(83, 20);
            this.MnuItmBaseConfig.Text = "基本设置(&B)";
            // 
            // MnuItmClass
            // 
            this.MnuItmClass.Name = "MnuItmClass";
            this.MnuItmClass.Size = new System.Drawing.Size(136, 22);
            this.MnuItmClass.Text = "专业班级(&C)";
            this.MnuItmClass.Click += new System.EventHandler(this.MnuItmClass_Click);
            // 
            // MnuItmEvaItem
            // 
            this.MnuItmEvaItem.Name = "MnuItmEvaItem";
            this.MnuItmEvaItem.Size = new System.Drawing.Size(136, 22);
            this.MnuItmEvaItem.Text = "测评项目(&E)";
            this.MnuItmEvaItem.Click += new System.EventHandler(this.MnuItmEvaItem_Click);
            // 
            // MnuItmSemester
            // 
            this.MnuItmSemester.Name = "MnuItmSemester";
            this.MnuItmSemester.Size = new System.Drawing.Size(136, 22);
            this.MnuItmSemester.Text = "学年学期(&S)";
            this.MnuItmSemester.Click += new System.EventHandler(this.MnuItmSemester_Click);
            // 
            // MnuItmRead
            // 
            this.MnuItmRead.Name = "MnuItmRead";
            this.MnuItmRead.Size = new System.Drawing.Size(83, 20);
            this.MnuItmRead.Text = "查看成绩(&R)";
            this.MnuItmRead.Visible = false;
            // 
            // MnuItmPersonInfo
            // 
            this.MnuItmPersonInfo.Name = "MnuItmPersonInfo";
            this.MnuItmPersonInfo.Size = new System.Drawing.Size(83, 20);
            this.MnuItmPersonInfo.Text = "个人中心(&P)";
            this.MnuItmPersonInfo.Click += new System.EventHandler(this.MnuItmPersonInfo_Click);
            // 
            // MnuItmWindows
            // 
            this.MnuItmWindows.Name = "MnuItmWindows";
            this.MnuItmWindows.Size = new System.Drawing.Size(59, 20);
            this.MnuItmWindows.Text = "窗口(&W)";
            this.MnuItmWindows.DropDownOpening += new System.EventHandler(this.MnuItmWindows_DropDownOpening);
            this.MnuItmWindows.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MnuItmWindows_DropDownItemClicked);
            // 
            // MnuItmAbout
            // 
            this.MnuItmAbout.Name = "MnuItmAbout";
            this.MnuItmAbout.Size = new System.Drawing.Size(83, 20);
            this.MnuItmAbout.Text = "联系我们(&A)";
            this.MnuItmAbout.Visible = false;
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 564);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmIndex";
            this.Text = "德育测评系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIndex_FormClosed);
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuItmEva;
        private System.Windows.Forms.ToolStripMenuItem MnuItmPointExchange;
        private System.Windows.Forms.ToolStripMenuItem MnuItmSummarize;
        private System.Windows.Forms.ToolStripMenuItem MnuItmHistory;
        private System.Windows.Forms.ToolStripMenuItem MnuItmUserAdmin;
        private System.Windows.Forms.ToolStripMenuItem MnuItmAdAdmin;
        private System.Windows.Forms.ToolStripMenuItem MnuItmAdStu;
        private System.Windows.Forms.ToolStripMenuItem MnuItmBaseConfig;
        private System.Windows.Forms.ToolStripMenuItem MnuItmClass;
        private System.Windows.Forms.ToolStripMenuItem MnuItmEvaItem;
        private System.Windows.Forms.ToolStripMenuItem MnuItmSemester;
        private System.Windows.Forms.ToolStripMenuItem MnuItmPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem MnuItmAbout;
        private System.Windows.Forms.ToolStripMenuItem MnuItmWindows;
        private System.Windows.Forms.ToolStripMenuItem MnuItmRead;

    }
}