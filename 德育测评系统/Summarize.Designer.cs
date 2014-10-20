namespace MoralEvaluated
{
    partial class FrmSummarize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSummarize));
            this.DgvSummarize = new System.Windows.Forms.DataGridView();
            this.TreeClass = new System.Windows.Forms.TreeView();
            this.BtnOutPut = new System.Windows.Forms.Button();
            this.CboYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboSemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSummarize)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSummarize
            // 
            this.DgvSummarize.AllowUserToAddRows = false;
            this.DgvSummarize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSummarize.Location = new System.Drawing.Point(234, 60);
            this.DgvSummarize.Name = "DgvSummarize";
            this.DgvSummarize.ReadOnly = true;
            this.DgvSummarize.RowTemplate.Height = 23;
            this.DgvSummarize.Size = new System.Drawing.Size(725, 371);
            this.DgvSummarize.TabIndex = 0;
            this.DgvSummarize.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvSummarize_CellPainting);
            this.DgvSummarize.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvSummarize_RowPostPaint);
            this.DgvSummarize.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DgvSummarize_RowPrePaint);
            // 
            // TreeClass
            // 
            this.TreeClass.Location = new System.Drawing.Point(12, 12);
            this.TreeClass.Name = "TreeClass";
            this.TreeClass.Size = new System.Drawing.Size(216, 448);
            this.TreeClass.TabIndex = 20;
            this.TreeClass.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeClass_NodeMouseClick);
            // 
            // BtnOutPut
            // 
            this.BtnOutPut.Location = new System.Drawing.Point(882, 437);
            this.BtnOutPut.Name = "BtnOutPut";
            this.BtnOutPut.Size = new System.Drawing.Size(75, 23);
            this.BtnOutPut.TabIndex = 21;
            this.BtnOutPut.Text = "导出";
            this.BtnOutPut.UseVisualStyleBackColor = true;
            this.BtnOutPut.Click += new System.EventHandler(this.BtnOutPut_Click);
            // 
            // CboYear
            // 
            this.CboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboYear.FormattingEnabled = true;
            this.CboYear.Location = new System.Drawing.Point(302, 12);
            this.CboYear.Name = "CboYear";
            this.CboYear.Size = new System.Drawing.Size(121, 20);
            this.CboYear.TabIndex = 22;
            this.CboYear.SelectedIndexChanged += new System.EventHandler(this.CboYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "学年:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "学期:";
            // 
            // CboSemester
            // 
            this.CboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSemester.FormattingEnabled = true;
            this.CboSemester.Location = new System.Drawing.Point(535, 12);
            this.CboSemester.Name = "CboSemester";
            this.CboSemester.Size = new System.Drawing.Size(121, 20);
            this.CboSemester.TabIndex = 24;
            this.CboSemester.SelectedIndexChanged += new System.EventHandler(this.CboSemester_SelectedIndexChanged);
            // 
            // FrmSummarize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboSemester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboYear);
            this.Controls.Add(this.BtnOutPut);
            this.Controls.Add(this.DgvSummarize);
            this.Controls.Add(this.TreeClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSummarize";
            this.Text = "测评汇总";
            this.Load += new System.EventHandler(this.FrmSummarize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSummarize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSummarize;
        private System.Windows.Forms.TreeView TreeClass;
        private System.Windows.Forms.Button BtnOutPut;
        private System.Windows.Forms.ComboBox CboYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboSemester;
    }
}