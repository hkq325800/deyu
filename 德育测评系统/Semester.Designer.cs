namespace MoralEvaluated
{
    partial class FrmSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSemester));
            this.LtbSemester = new System.Windows.Forms.ListBox();
            this.BtAddSem = new System.Windows.Forms.Button();
            this.BtDelSem = new System.Windows.Forms.Button();
            this.Ltbse_id = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LtbSemester
            // 
            this.LtbSemester.FormattingEnabled = true;
            this.LtbSemester.ItemHeight = 12;
            this.LtbSemester.Location = new System.Drawing.Point(32, 49);
            this.LtbSemester.Name = "LtbSemester";
            this.LtbSemester.Size = new System.Drawing.Size(432, 232);
            this.LtbSemester.TabIndex = 0;
            this.LtbSemester.SelectedIndexChanged += new System.EventHandler(this.LtbSemester_SelectedIndexChanged);
            // 
            // BtAddSem
            // 
            this.BtAddSem.Location = new System.Drawing.Point(66, 307);
            this.BtAddSem.Name = "BtAddSem";
            this.BtAddSem.Size = new System.Drawing.Size(89, 23);
            this.BtAddSem.TabIndex = 1;
            this.BtAddSem.Text = "添加学年学期";
            this.BtAddSem.UseVisualStyleBackColor = true;
            this.BtAddSem.Click += new System.EventHandler(this.BtAddSem_Click);
            // 
            // BtDelSem
            // 
            this.BtDelSem.Location = new System.Drawing.Point(339, 307);
            this.BtDelSem.Name = "BtDelSem";
            this.BtDelSem.Size = new System.Drawing.Size(86, 23);
            this.BtDelSem.TabIndex = 2;
            this.BtDelSem.Text = "删 除 所 选";
            this.BtDelSem.UseVisualStyleBackColor = true;
            this.BtDelSem.Click += new System.EventHandler(this.BtDelSem_Click);
            // 
            // Ltbse_id
            // 
            this.Ltbse_id.FormattingEnabled = true;
            this.Ltbse_id.ItemHeight = 12;
            this.Ltbse_id.Location = new System.Drawing.Point(528, 119);
            this.Ltbse_id.Name = "Ltbse_id";
            this.Ltbse_id.Size = new System.Drawing.Size(101, 64);
            this.Ltbse_id.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "学年学期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "起始日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "结束日期";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(204, 307);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(86, 23);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "修 改 所 选";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FrmSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 356);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtAddSem);
            this.Controls.Add(this.BtDelSem);
            this.Controls.Add(this.LtbSemester);
            this.Controls.Add(this.Ltbse_id);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSemester";
            this.Text = "学年学期";
            this.Load += new System.EventHandler(this.Semester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LtbSemester;
        private System.Windows.Forms.Button BtAddSem;
        private System.Windows.Forms.Button BtDelSem;
        private System.Windows.Forms.ListBox Ltbse_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUpdate;
    }
}