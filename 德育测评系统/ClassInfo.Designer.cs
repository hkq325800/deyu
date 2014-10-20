namespace MoralEvaluated
{
    partial class FrmClassInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassInfo));
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtGrade = new System.Windows.Forms.TextBox();
            this.TxtCl_name = new System.Windows.Forms.TextBox();
            this.CboPr_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(44, 172);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "确认";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtGrade
            // 
            this.TxtGrade.Location = new System.Drawing.Point(90, 112);
            this.TxtGrade.Name = "TxtGrade";
            this.TxtGrade.Size = new System.Drawing.Size(121, 21);
            this.TxtGrade.TabIndex = 5;
            // 
            // TxtCl_name
            // 
            this.TxtCl_name.Location = new System.Drawing.Point(90, 38);
            this.TxtCl_name.Name = "TxtCl_name";
            this.TxtCl_name.Size = new System.Drawing.Size(121, 21);
            this.TxtCl_name.TabIndex = 4;
            // 
            // CboPr_name
            // 
            this.CboPr_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPr_name.FormattingEnabled = true;
            this.CboPr_name.Location = new System.Drawing.Point(90, 75);
            this.CboPr_name.Name = "CboPr_name";
            this.CboPr_name.Size = new System.Drawing.Size(121, 20);
            this.CboPr_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "年级:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "专业:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(150, 172);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "返回";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 216);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtGrade);
            this.Controls.Add(this.TxtCl_name);
            this.Controls.Add(this.CboPr_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClassInfo";
            this.Text = "班级信息";
            this.Load += new System.EventHandler(this.ClassInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboPr_name;
        private System.Windows.Forms.TextBox TxtCl_name;
        private System.Windows.Forms.TextBox TxtGrade;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}