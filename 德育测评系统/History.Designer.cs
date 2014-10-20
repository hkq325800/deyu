namespace MoralEvaluated
{
    partial class FrmHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistory));
            this.GrbHistory = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CboYear = new System.Windows.Forms.ComboBox();
            this.CboSemester = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CboCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DtpOpEnd = new System.Windows.Forms.DateTimePicker();
            this.DtpOpBegin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CboOperator = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CboProfession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboGrade = new System.Windows.Forms.ComboBox();
            this.CboClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LstStudent = new System.Windows.Forms.ListBox();
            this.LstValue = new System.Windows.Forms.ListBox();
            this.DgvDetail = new System.Windows.Forms.DataGridView();
            this.CkbWrite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TxtStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txtscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAll = new System.Windows.Forms.Button();
            this.GrbDetail = new System.Windows.Forms.GroupBox();
            this.BtnContrary = new System.Windows.Forms.Button();
            this.GrbHistory.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetail)).BeginInit();
            this.GrbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbHistory
            // 
            this.GrbHistory.Controls.Add(this.panel5);
            this.GrbHistory.Controls.Add(this.panel4);
            this.GrbHistory.Controls.Add(this.panel3);
            this.GrbHistory.Controls.Add(this.panel2);
            this.GrbHistory.Controls.Add(this.panel1);
            this.GrbHistory.Controls.Add(this.LstStudent);
            this.GrbHistory.Location = new System.Drawing.Point(12, 3);
            this.GrbHistory.Name = "GrbHistory";
            this.GrbHistory.Size = new System.Drawing.Size(753, 236);
            this.GrbHistory.TabIndex = 20;
            this.GrbHistory.TabStop = false;
            this.GrbHistory.Text = "历史记录";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(13, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(584, 47);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.CboYear);
            this.panel4.Controls.Add(this.CboSemester);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(13, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 47);
            this.panel4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "学年:";
            // 
            // CboYear
            // 
            this.CboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboYear.FormattingEnabled = true;
            this.CboYear.Location = new System.Drawing.Point(60, 12);
            this.CboYear.Name = "CboYear";
            this.CboYear.Size = new System.Drawing.Size(121, 20);
            this.CboYear.TabIndex = 0;
            this.CboYear.SelectedIndexChanged += new System.EventHandler(this.CboYear_SelectedIndexChanged);
            // 
            // CboSemester
            // 
            this.CboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSemester.FormattingEnabled = true;
            this.CboSemester.Location = new System.Drawing.Point(259, 12);
            this.CboSemester.Name = "CboSemester";
            this.CboSemester.Size = new System.Drawing.Size(121, 20);
            this.CboSemester.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "学期:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.CboCategory);
            this.panel3.Location = new System.Drawing.Point(413, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 47);
            this.panel3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "测评类型:";
            // 
            // CboCategory
            // 
            this.CboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategory.FormattingEnabled = true;
            this.CboCategory.Items.AddRange(new object[] {
            "全部"});
            this.CboCategory.Location = new System.Drawing.Point(72, 12);
            this.CboCategory.Name = "CboCategory";
            this.CboCategory.Size = new System.Drawing.Size(105, 20);
            this.CboCategory.TabIndex = 0;
            this.CboCategory.SelectedIndexChanged += new System.EventHandler(this.CboCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnSearch);
            this.panel2.Controls.Add(this.DtpOpEnd);
            this.panel2.Controls.Add(this.DtpOpBegin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CboOperator);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(13, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 47);
            this.panel2.TabIndex = 8;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(517, 11);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(60, 23);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "提交";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DtpOpEnd
            // 
            this.DtpOpEnd.CustomFormat = "yyyy-MM-dd";
            this.DtpOpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpOpEnd.Location = new System.Drawing.Point(378, 12);
            this.DtpOpEnd.Name = "DtpOpEnd";
            this.DtpOpEnd.Size = new System.Drawing.Size(121, 21);
            this.DtpOpEnd.TabIndex = 10;
            // 
            // DtpOpBegin
            // 
            this.DtpOpBegin.CustomFormat = "yyyy-MM-dd";
            this.DtpOpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpOpBegin.Location = new System.Drawing.Point(228, 12);
            this.DtpOpBegin.Name = "DtpOpBegin";
            this.DtpOpBegin.Size = new System.Drawing.Size(121, 21);
            this.DtpOpBegin.TabIndex = 9;
            this.DtpOpBegin.Value = new System.DateTime(2013, 9, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "操作人:";
            // 
            // CboOperator
            // 
            this.CboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboOperator.FormattingEnabled = true;
            this.CboOperator.Location = new System.Drawing.Point(60, 12);
            this.CboOperator.Name = "CboOperator";
            this.CboOperator.Size = new System.Drawing.Size(97, 20);
            this.CboOperator.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "至";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "操作时间:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CboProfession);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CboGrade);
            this.panel1.Controls.Add(this.CboClass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 47);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "专业:";
            // 
            // CboProfession
            // 
            this.CboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProfession.FormattingEnabled = true;
            this.CboProfession.Location = new System.Drawing.Point(60, 12);
            this.CboProfession.Name = "CboProfession";
            this.CboProfession.Size = new System.Drawing.Size(121, 20);
            this.CboProfession.TabIndex = 0;
            this.CboProfession.SelectedIndexChanged += new System.EventHandler(this.CboProfession_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "班级:";
            // 
            // CboGrade
            // 
            this.CboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboGrade.FormattingEnabled = true;
            this.CboGrade.Location = new System.Drawing.Point(259, 12);
            this.CboGrade.Name = "CboGrade";
            this.CboGrade.Size = new System.Drawing.Size(121, 20);
            this.CboGrade.TabIndex = 2;
            this.CboGrade.SelectedIndexChanged += new System.EventHandler(this.CboGrade_SelectedIndexChanged);
            // 
            // CboClass
            // 
            this.CboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboClass.FormattingEnabled = true;
            this.CboClass.Location = new System.Drawing.Point(456, 12);
            this.CboClass.Name = "CboClass";
            this.CboClass.Size = new System.Drawing.Size(121, 20);
            this.CboClass.TabIndex = 4;
            this.CboClass.SelectedIndexChanged += new System.EventHandler(this.CboClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "年级:";
            // 
            // LstStudent
            // 
            this.LstStudent.FormattingEnabled = true;
            this.LstStudent.ItemHeight = 12;
            this.LstStudent.Location = new System.Drawing.Point(604, 17);
            this.LstStudent.Name = "LstStudent";
            this.LstStudent.Size = new System.Drawing.Size(142, 208);
            this.LstStudent.TabIndex = 6;
            this.LstStudent.SelectedIndexChanged += new System.EventHandler(this.LstStudent_SelectedIndexChanged);
            // 
            // LstValue
            // 
            this.LstValue.FormattingEnabled = true;
            this.LstValue.ItemHeight = 12;
            this.LstValue.Location = new System.Drawing.Point(800, 173);
            this.LstValue.Name = "LstValue";
            this.LstValue.Size = new System.Drawing.Size(120, 88);
            this.LstValue.TabIndex = 9;
            this.LstValue.Visible = false;
            // 
            // DgvDetail
            // 
            this.DgvDetail.AllowUserToAddRows = false;
            this.DgvDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CkbWrite,
            this.TxtStu,
            this.TxtCategory,
            this.Txtscore,
            this.TxtDate,
            this.TxtOperator,
            this.TxtTime,
            this.TxtReason,
            this.ColID});
            this.DgvDetail.Location = new System.Drawing.Point(3, 42);
            this.DgvDetail.Name = "DgvDetail";
            this.DgvDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvDetail.RowTemplate.Height = 23;
            this.DgvDetail.Size = new System.Drawing.Size(747, 180);
            this.DgvDetail.TabIndex = 0;
            this.DgvDetail.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.DgvDetail.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvDetail_RowPostPaint);
            this.DgvDetail.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // CkbWrite
            // 
            this.CkbWrite.HeaderText = "选择";
            this.CkbWrite.Name = "CkbWrite";
            this.CkbWrite.Width = 35;
            // 
            // TxtStu
            // 
            this.TxtStu.HeaderText = "学生";
            this.TxtStu.Name = "TxtStu";
            this.TxtStu.ReadOnly = true;
            this.TxtStu.Width = 60;
            // 
            // TxtCategory
            // 
            this.TxtCategory.HeaderText = "测评类型";
            this.TxtCategory.Name = "TxtCategory";
            this.TxtCategory.ReadOnly = true;
            this.TxtCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TxtCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TxtCategory.Width = 80;
            // 
            // Txtscore
            // 
            this.Txtscore.HeaderText = "分数";
            this.Txtscore.Name = "Txtscore";
            this.Txtscore.ReadOnly = true;
            this.Txtscore.Width = 35;
            // 
            // TxtDate
            // 
            this.TxtDate.HeaderText = "时间";
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Width = 70;
            // 
            // TxtOperator
            // 
            this.TxtOperator.HeaderText = "操作人";
            this.TxtOperator.Name = "TxtOperator";
            this.TxtOperator.ReadOnly = true;
            this.TxtOperator.Width = 60;
            // 
            // TxtTime
            // 
            this.TxtTime.HeaderText = "操作时间";
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.ReadOnly = true;
            this.TxtTime.Width = 120;
            // 
            // TxtReason
            // 
            this.TxtReason.HeaderText = "原因";
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.ReadOnly = true;
            this.TxtReason.Width = 150;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Column1";
            this.ColID.Name = "ColID";
            this.ColID.Visible = false;
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(522, 13);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 23);
            this.BtnModify.TabIndex = 2;
            this.BtnModify.Text = "修改";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(625, 13);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.Location = new System.Drawing.Point(80, 13);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(57, 23);
            this.BtnAll.TabIndex = 4;
            this.BtnAll.Text = "全选";
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // GrbDetail
            // 
            this.GrbDetail.Controls.Add(this.DgvDetail);
            this.GrbDetail.Controls.Add(this.BtnContrary);
            this.GrbDetail.Controls.Add(this.BtnAll);
            this.GrbDetail.Controls.Add(this.BtnDelete);
            this.GrbDetail.Controls.Add(this.BtnModify);
            this.GrbDetail.Location = new System.Drawing.Point(12, 245);
            this.GrbDetail.Name = "GrbDetail";
            this.GrbDetail.Size = new System.Drawing.Size(753, 228);
            this.GrbDetail.TabIndex = 21;
            this.GrbDetail.TabStop = false;
            this.GrbDetail.Text = "详细信息";
            // 
            // BtnContrary
            // 
            this.BtnContrary.Location = new System.Drawing.Point(156, 13);
            this.BtnContrary.Name = "BtnContrary";
            this.BtnContrary.Size = new System.Drawing.Size(57, 23);
            this.BtnContrary.TabIndex = 5;
            this.BtnContrary.Text = "反选";
            this.BtnContrary.UseVisualStyleBackColor = true;
            this.BtnContrary.Click += new System.EventHandler(this.BtnContrary_Click);
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 475);
            this.Controls.Add(this.LstValue);
            this.Controls.Add(this.GrbDetail);
            this.Controls.Add(this.GrbHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistory";
            this.Text = "历史记录";
            this.Load += new System.EventHandler(this.FrmHistory_Load);
            this.GrbHistory.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetail)).EndInit();
            this.GrbDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboProfession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboGrade;
        private System.Windows.Forms.ComboBox CboClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LstStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboOperator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpOpBegin;
        private System.Windows.Forms.DateTimePicker DtpOpEnd;
        private System.Windows.Forms.ListBox LstValue;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboCategory;
        private System.Windows.Forms.DataGridView DgvDetail;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.GroupBox GrbDetail;
        private System.Windows.Forms.Button BtnContrary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CkbWrite;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txtscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboYear;
        private System.Windows.Forms.ComboBox CboSemester;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
    }
}