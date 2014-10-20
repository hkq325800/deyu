namespace MoralEvaluated
{
    partial class FrmPersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonInfo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnModify = new System.Windows.Forms.Button();
            this.LblLevel = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.CboSex = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnLiftPassword = new System.Windows.Forms.Button();
            this.TxtConcernedNewPassword = new System.Windows.Forms.TextBox();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.TxtOldPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(305, 330);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnModify);
            this.tabPage1.Controls.Add(this.LblLevel);
            this.tabPage1.Controls.Add(this.LblUser);
            this.tabPage1.Controls.Add(this.CboSex);
            this.tabPage1.Controls.Add(this.TxtEmail);
            this.tabPage1.Controls.Add(this.TxtPhone);
            this.tabPage1.Controls.Add(this.TxtUserName);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(297, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "个人信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(92, 264);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 23);
            this.BtnModify.TabIndex = 4;
            this.BtnModify.Text = "确认修改";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Location = new System.Drawing.Point(103, 136);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(0, 12);
            this.LblLevel.TabIndex = 32;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(103, 18);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(0, 12);
            this.LblUser.TabIndex = 31;
            // 
            // CboSex
            // 
            this.CboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSex.FormattingEnabled = true;
            this.CboSex.Items.AddRange(new object[] {
            "男",
            "女",
            "未知"});
            this.CboSex.Location = new System.Drawing.Point(102, 93);
            this.CboSex.Name = "CboSex";
            this.CboSex.Size = new System.Drawing.Size(115, 20);
            this.CboSex.TabIndex = 1;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(102, 212);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(115, 21);
            this.TxtEmail.TabIndex = 3;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(102, 173);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(115, 21);
            this.TxtPhone.TabIndex = 2;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(102, 53);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(115, 21);
            this.TxtUserName.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 26;
            this.label13.Text = "e-mail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "电话:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "权限:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "性别:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "姓名:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "工号:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.BtnLiftPassword);
            this.tabPage2.Controls.Add(this.TxtConcernedNewPassword);
            this.tabPage2.Controls.Add(this.TxtNewPassword);
            this.tabPage2.Controls.Add(this.TxtOldPassword);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(297, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "密码修改";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 48;
            this.label6.Text = "建议3-15字符";
            // 
            // BtnLiftPassword
            // 
            this.BtnLiftPassword.Location = new System.Drawing.Point(106, 193);
            this.BtnLiftPassword.Name = "BtnLiftPassword";
            this.BtnLiftPassword.Size = new System.Drawing.Size(75, 23);
            this.BtnLiftPassword.TabIndex = 47;
            this.BtnLiftPassword.Text = "提交";
            this.BtnLiftPassword.UseVisualStyleBackColor = true;
            this.BtnLiftPassword.Click += new System.EventHandler(this.BtnLiftPassword_Click);
            // 
            // TxtConcernedNewPassword
            // 
            this.TxtConcernedNewPassword.Location = new System.Drawing.Point(138, 141);
            this.TxtConcernedNewPassword.Name = "TxtConcernedNewPassword";
            this.TxtConcernedNewPassword.PasswordChar = '*';
            this.TxtConcernedNewPassword.Size = new System.Drawing.Size(100, 21);
            this.TxtConcernedNewPassword.TabIndex = 46;
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Location = new System.Drawing.Point(138, 107);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.PasswordChar = '*';
            this.TxtNewPassword.Size = new System.Drawing.Size(100, 21);
            this.TxtNewPassword.TabIndex = 45;
            // 
            // TxtOldPassword
            // 
            this.TxtOldPassword.AcceptsTab = true;
            this.TxtOldPassword.Location = new System.Drawing.Point(138, 71);
            this.TxtOldPassword.Name = "TxtOldPassword";
            this.TxtOldPassword.PasswordChar = '*';
            this.TxtOldPassword.Size = new System.Drawing.Size(100, 21);
            this.TxtOldPassword.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 12);
            this.label16.TabIndex = 43;
            this.label16.Text = "确认新密码:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(68, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 42;
            this.label15.Text = "新密码:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 41;
            this.label14.Text = "旧密码:";
            // 
            // FrmPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 354);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonInfo";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.PersonInfo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.ComboBox CboSex;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnLiftPassword;
        private System.Windows.Forms.TextBox TxtConcernedNewPassword;
        private System.Windows.Forms.TextBox TxtNewPassword;
        private System.Windows.Forms.TextBox TxtOldPassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
    }
}