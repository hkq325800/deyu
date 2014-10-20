namespace MoralEvaluated
{
    partial class FrmAdminEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminEditor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnModify = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.BtnComplete = new System.Windows.Forms.Button();
            this.LblLevel = new System.Windows.Forms.Label();
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
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxtPasswordSec = new System.Windows.Forms.TextBox();
            this.TxtPasswordFir = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnModify);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxtUser);
            this.tabPage1.Controls.Add(this.BtnComplete);
            this.tabPage1.Controls.Add(this.LblLevel);
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
            this.BtnModify.Location = new System.Drawing.Point(191, 264);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 23);
            this.BtnModify.TabIndex = 6;
            this.BtnModify.Text = "修改";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "用作登陆";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "3-12个英文字符";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "*(必填项)";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(77, 18);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(115, 21);
            this.TxtUser.TabIndex = 0;
            this.TxtUser.TextChanged += new System.EventHandler(this.TxtUser_TextChanged);
            // 
            // BtnComplete
            // 
            this.BtnComplete.Location = new System.Drawing.Point(41, 264);
            this.BtnComplete.Name = "BtnComplete";
            this.BtnComplete.Size = new System.Drawing.Size(75, 23);
            this.BtnComplete.TabIndex = 5;
            this.BtnComplete.Text = "完成";
            this.BtnComplete.UseVisualStyleBackColor = true;
            this.BtnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Location = new System.Drawing.Point(75, 132);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(41, 12);
            this.LblLevel.TabIndex = 16;
            this.LblLevel.Text = "管理员";
            // 
            // CboSex
            // 
            this.CboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSex.FormattingEnabled = true;
            this.CboSex.Items.AddRange(new object[] {
            "男",
            "女",
            "未知"});
            this.CboSex.Location = new System.Drawing.Point(77, 94);
            this.CboSex.Name = "CboSex";
            this.CboSex.Size = new System.Drawing.Size(115, 20);
            this.CboSex.TabIndex = 2;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(77, 208);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(115, 21);
            this.TxtEmail.TabIndex = 4;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(77, 167);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(115, 21);
            this.TxtPhone.TabIndex = 3;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(77, 53);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(115, 21);
            this.TxtUserName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "e-mail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "电话:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "权限:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "性别:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "姓名:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "账号:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.BtnSubmit);
            this.tabPage2.Controls.Add(this.TxtPasswordSec);
            this.tabPage2.Controls.Add(this.TxtPasswordFir);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(297, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "密码设定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "建议3-15字符";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(92, 264);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 2;
            this.BtnSubmit.Text = "提交";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtPasswordSec
            // 
            this.TxtPasswordSec.Location = new System.Drawing.Point(119, 131);
            this.TxtPasswordSec.Name = "TxtPasswordSec";
            this.TxtPasswordSec.PasswordChar = '*';
            this.TxtPasswordSec.Size = new System.Drawing.Size(100, 21);
            this.TxtPasswordSec.TabIndex = 1;
            // 
            // TxtPasswordFir
            // 
            this.TxtPasswordFir.Location = new System.Drawing.Point(119, 73);
            this.TxtPasswordFir.Name = "TxtPasswordFir";
            this.TxtPasswordFir.PasswordChar = '*';
            this.TxtPasswordFir.Size = new System.Drawing.Size(100, 21);
            this.TxtPasswordFir.TabIndex = 0;
            this.TxtPasswordFir.TextChanged += new System.EventHandler(this.TxtPasswordFir_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "确认密码:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "输入密码:";
            // 
            // FrmAdminEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 354);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAdminEditor";
            this.Text = "管理员信息";
            this.Load += new System.EventHandler(this.FrmAdminEditor_Load);
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
        private System.Windows.Forms.Button BtnComplete;
        private System.Windows.Forms.Label LblLevel;
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
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox TxtPasswordSec;
        private System.Windows.Forms.TextBox TxtPasswordFir;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnModify;
    }
}