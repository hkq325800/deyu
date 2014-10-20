namespace MoralEvaluated
{
    partial class FrmRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecord));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtStudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtReason = new System.Windows.Forms.RichTextBox();
            this.TxtOperater = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生:";
            // 
            // TxtStudent
            // 
            this.TxtStudent.Location = new System.Drawing.Point(77, 12);
            this.TxtStudent.Name = "TxtStudent";
            this.TxtStudent.ReadOnly = true;
            this.TxtStudent.Size = new System.Drawing.Size(121, 21);
            this.TxtStudent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "测评类型:";
            // 
            // TxtPoint
            // 
            this.TxtPoint.Location = new System.Drawing.Point(77, 66);
            this.TxtPoint.Name = "TxtPoint";
            this.TxtPoint.Size = new System.Drawing.Size(121, 21);
            this.TxtPoint.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "分数:";
            // 
            // CboCategory
            // 
            this.CboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategory.FormattingEnabled = true;
            this.CboCategory.Location = new System.Drawing.Point(77, 39);
            this.CboCategory.Name = "CboCategory";
            this.CboCategory.Size = new System.Drawing.Size(121, 20);
            this.CboCategory.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "原因:";
            // 
            // TxtReason
            // 
            this.TxtReason.Location = new System.Drawing.Point(77, 162);
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.Size = new System.Drawing.Size(121, 152);
            this.TxtReason.TabIndex = 8;
            this.TxtReason.Text = "";
            // 
            // TxtOperater
            // 
            this.TxtOperater.Location = new System.Drawing.Point(77, 93);
            this.TxtOperater.Name = "TxtOperater";
            this.TxtOperater.ReadOnly = true;
            this.TxtOperater.Size = new System.Drawing.Size(121, 21);
            this.TxtOperater.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "操作人:";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(26, 336);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 11;
            this.BtnSubmit.Text = "提交";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(138, 336);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DtpDate
            // 
            this.DtpDate.CustomFormat = "yyyy-MM-dd";
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDate.Location = new System.Drawing.Point(77, 120);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(121, 21);
            this.DtpDate.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "时间:";
            // 
            // FrmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 383);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtOperater);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtReason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboCategory);
            this.Controls.Add(this.TxtPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtStudent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecord";
            this.Text = "历史记录";
            this.Load += new System.EventHandler(this.FrmRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TxtReason;
        private System.Windows.Forms.TextBox TxtOperater;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Label label6;
    }
}