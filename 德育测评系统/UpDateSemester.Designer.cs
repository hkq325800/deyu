namespace MoralEvaluated
{
    partial class FrmUpDateSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpDateSemester));
            this.CmbSeTerm = new System.Windows.Forms.ComboBox();
            this.CmbSeYear = new System.Windows.Forms.ComboBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpSeEndTime = new System.Windows.Forms.DateTimePicker();
            this.DtpSeStartTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CmbSeTerm
            // 
            this.CmbSeTerm.FormattingEnabled = true;
            this.CmbSeTerm.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CmbSeTerm.Location = new System.Drawing.Point(121, 81);
            this.CmbSeTerm.Name = "CmbSeTerm";
            this.CmbSeTerm.Size = new System.Drawing.Size(68, 20);
            this.CmbSeTerm.TabIndex = 17;
            this.CmbSeTerm.Text = "1";
            // 
            // CmbSeYear
            // 
            this.CmbSeYear.FormattingEnabled = true;
            this.CmbSeYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.CmbSeYear.Location = new System.Drawing.Point(121, 47);
            this.CmbSeYear.Name = "CmbSeYear";
            this.CmbSeYear.Size = new System.Drawing.Size(67, 20);
            this.CmbSeYear.TabIndex = 16;
            this.CmbSeYear.Text = "2010";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(99, 200);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 15;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "结束日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "起始日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "学期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "学年";
            // 
            // DtpSeEndTime
            // 
            this.DtpSeEndTime.CustomFormat = "yyyy-MM-dd";
            this.DtpSeEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpSeEndTime.Location = new System.Drawing.Point(121, 147);
            this.DtpSeEndTime.Name = "DtpSeEndTime";
            this.DtpSeEndTime.Size = new System.Drawing.Size(115, 21);
            this.DtpSeEndTime.TabIndex = 10;
            // 
            // DtpSeStartTime
            // 
            this.DtpSeStartTime.CustomFormat = "yyyy-MM-dd";
            this.DtpSeStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpSeStartTime.Location = new System.Drawing.Point(121, 115);
            this.DtpSeStartTime.Name = "DtpSeStartTime";
            this.DtpSeStartTime.Size = new System.Drawing.Size(115, 21);
            this.DtpSeStartTime.TabIndex = 9;
            // 
            // FrmUpDateSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CmbSeTerm);
            this.Controls.Add(this.CmbSeYear);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpSeEndTime);
            this.Controls.Add(this.DtpSeStartTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUpDateSemester";
            this.Text = "修改学年学期";
            this.Load += new System.EventHandler(this.FrmUpDateSemester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbSeTerm;
        private System.Windows.Forms.ComboBox CmbSeYear;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpSeEndTime;
        private System.Windows.Forms.DateTimePicker DtpSeStartTime;
    }
}