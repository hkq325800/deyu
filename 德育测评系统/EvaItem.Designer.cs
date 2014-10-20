namespace MoralEvaluated
{
    partial class FrmEvaItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvaItem));
            this.CboCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtReason = new System.Windows.Forms.RichTextBox();
            this.LstItems = new System.Windows.Forms.ListBox();
            this.GrpDetail = new System.Windows.Forms.GroupBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.CboDetailCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.GrpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboCategory
            // 
            this.CboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategory.FormattingEnabled = true;
            this.CboCategory.Location = new System.Drawing.Point(43, 58);
            this.CboCategory.Name = "CboCategory";
            this.CboCategory.Size = new System.Drawing.Size(121, 20);
            this.CboCategory.TabIndex = 1;
            this.CboCategory.SelectedIndexChanged += new System.EventHandler(this.CboCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "测评类型:";
            // 
            // TxtPoint
            // 
            this.TxtPoint.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPoint.Location = new System.Drawing.Point(93, 107);
            this.TxtPoint.Name = "TxtPoint";
            this.TxtPoint.ReadOnly = true;
            this.TxtPoint.Size = new System.Drawing.Size(121, 21);
            this.TxtPoint.TabIndex = 2;
            this.TxtPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPoint_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "分值:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "原因:";
            // 
            // TxtReason
            // 
            this.TxtReason.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtReason.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtReason.Location = new System.Drawing.Point(93, 134);
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.ReadOnly = true;
            this.TxtReason.Size = new System.Drawing.Size(228, 77);
            this.TxtReason.TabIndex = 3;
            this.TxtReason.Text = "";
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.ItemHeight = 12;
            this.LstItems.Location = new System.Drawing.Point(277, 12);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(122, 124);
            this.LstItems.TabIndex = 13;
            this.LstItems.SelectedIndexChanged += new System.EventHandler(this.LstItems_SelectedIndexChanged);
            // 
            // GrpDetail
            // 
            this.GrpDetail.Controls.Add(this.BtnSubmit);
            this.GrpDetail.Controls.Add(this.CboDetailCategory);
            this.GrpDetail.Controls.Add(this.label3);
            this.GrpDetail.Controls.Add(this.label2);
            this.GrpDetail.Controls.Add(this.TxtItem);
            this.GrpDetail.Controls.Add(this.label4);
            this.GrpDetail.Controls.Add(this.TxtReason);
            this.GrpDetail.Controls.Add(this.TxtPoint);
            this.GrpDetail.Controls.Add(this.label5);
            this.GrpDetail.Location = new System.Drawing.Point(14, 136);
            this.GrpDetail.Name = "GrpDetail";
            this.GrpDetail.Size = new System.Drawing.Size(385, 235);
            this.GrpDetail.TabIndex = 14;
            this.GrpDetail.TabStop = false;
            this.GrpDetail.Text = "详细信息";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(263, 37);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 58);
            this.BtnSubmit.TabIndex = 20;
            this.BtnSubmit.Text = "提交";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Visible = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // CboDetailCategory
            // 
            this.CboDetailCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDetailCategory.Enabled = false;
            this.CboDetailCategory.FormattingEnabled = true;
            this.CboDetailCategory.Location = new System.Drawing.Point(93, 20);
            this.CboDetailCategory.Name = "CboDetailCategory";
            this.CboDetailCategory.Size = new System.Drawing.Size(121, 20);
            this.CboDetailCategory.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "所属类型:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "项目:";
            // 
            // TxtItem
            // 
            this.TxtItem.BackColor = System.Drawing.SystemColors.Window;
            this.TxtItem.Location = new System.Drawing.Point(93, 46);
            this.TxtItem.Name = "TxtItem";
            this.TxtItem.ReadOnly = true;
            this.TxtItem.Size = new System.Drawing.Size(121, 21);
            this.TxtItem.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "常用项:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(196, 45);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(58, 20);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "添加";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(196, 71);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(58, 20);
            this.BtnModify.TabIndex = 17;
            this.BtnModify.Text = "修改";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(196, 97);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(58, 20);
            this.BtnDel.TabIndex = 18;
            this.BtnDel.Text = "删除";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // FrmEvaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 380);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GrpDetail);
            this.Controls.Add(this.LstItems);
            this.Controls.Add(this.CboCategory);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEvaItem";
            this.Text = "测评项目";
            this.Load += new System.EventHandler(this.EvaItem_Load);
            this.GrpDetail.ResumeLayout(false);
            this.GrpDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox TxtReason;
        private System.Windows.Forms.ListBox LstItems;
        private System.Windows.Forms.GroupBox GrpDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.ComboBox CboDetailCategory;
        private System.Windows.Forms.Button BtnSubmit;
    }
}