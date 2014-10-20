namespace MoralEvaluated
{
    partial class FrmPointExchanged
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPointExchanged));
            this.LstNumber = new System.Windows.Forms.ListBox();
            this.GrpPointExchanged = new System.Windows.Forms.GroupBox();
            this.DpkDate = new System.Windows.Forms.MonthCalendar();
            this.LstSearching = new System.Windows.Forms.ListBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtReason = new System.Windows.Forms.RichTextBox();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.CboOption = new System.Windows.Forms.ComboBox();
            this.CboCommonSelect = new System.Windows.Forms.ComboBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.CboItem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblObject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LstNames = new System.Windows.Forms.ListBox();
            this.LstValue = new System.Windows.Forms.ListBox();
            this.TreeClass = new System.Windows.Forms.TreeView();
            this.GrpPointExchanged.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstNumber
            // 
            this.LstNumber.FormattingEnabled = true;
            this.LstNumber.ItemHeight = 12;
            this.LstNumber.Location = new System.Drawing.Point(298, 36);
            this.LstNumber.Name = "LstNumber";
            this.LstNumber.Size = new System.Drawing.Size(120, 88);
            this.LstNumber.TabIndex = 4;
            this.LstNumber.Visible = false;
            // 
            // GrpPointExchanged
            // 
            this.GrpPointExchanged.Controls.Add(this.DpkDate);
            this.GrpPointExchanged.Controls.Add(this.LstSearching);
            this.GrpPointExchanged.Controls.Add(this.TxtName);
            this.GrpPointExchanged.Controls.Add(this.LstNumber);
            this.GrpPointExchanged.Controls.Add(this.button1);
            this.GrpPointExchanged.Controls.Add(this.BtnOK);
            this.GrpPointExchanged.Controls.Add(this.TxtReason);
            this.GrpPointExchanged.Controls.Add(this.TxtValue);
            this.GrpPointExchanged.Controls.Add(this.CboOption);
            this.GrpPointExchanged.Controls.Add(this.CboCommonSelect);
            this.GrpPointExchanged.Controls.Add(this.TxtDate);
            this.GrpPointExchanged.Controls.Add(this.CboItem);
            this.GrpPointExchanged.Controls.Add(this.label7);
            this.GrpPointExchanged.Controls.Add(this.label6);
            this.GrpPointExchanged.Controls.Add(this.label2);
            this.GrpPointExchanged.Controls.Add(this.label5);
            this.GrpPointExchanged.Controls.Add(this.label4);
            this.GrpPointExchanged.Controls.Add(this.label3);
            this.GrpPointExchanged.Controls.Add(this.LblObject);
            this.GrpPointExchanged.Location = new System.Drawing.Point(411, 4);
            this.GrpPointExchanged.Name = "GrpPointExchanged";
            this.GrpPointExchanged.Size = new System.Drawing.Size(513, 448);
            this.GrpPointExchanged.TabIndex = 3;
            this.GrpPointExchanged.TabStop = false;
            this.GrpPointExchanged.Text = "加减分";
            // 
            // DpkDate
            // 
            this.DpkDate.Location = new System.Drawing.Point(129, 197);
            this.DpkDate.Name = "DpkDate";
            this.DpkDate.TabIndex = 12;
            this.DpkDate.Visible = false;
            this.DpkDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DpkDate_DateSelected);
            // 
            // LstSearching
            // 
            this.LstSearching.FormattingEnabled = true;
            this.LstSearching.ItemHeight = 12;
            this.LstSearching.Location = new System.Drawing.Point(60, 47);
            this.LstSearching.Name = "LstSearching";
            this.LstSearching.Size = new System.Drawing.Size(157, 88);
            this.LstSearching.TabIndex = 24;
            this.LstSearching.Visible = false;
            this.LstSearching.Click += new System.EventHandler(this.LstSearching_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(96, 21);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(121, 21);
            this.TxtName.TabIndex = 23;
            this.TxtName.Click += new System.EventHandler(this.TxtName_Click_1);
            this.TxtName.Enter += new System.EventHandler(this.TxtName_Enter_1);
            this.TxtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(295, 409);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(85, 27);
            this.BtnOK.TabIndex = 17;
            this.BtnOK.Text = "确认";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtReason
            // 
            this.TxtReason.Location = new System.Drawing.Point(94, 344);
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.Size = new System.Drawing.Size(401, 51);
            this.TxtReason.TabIndex = 16;
            this.TxtReason.Text = "";
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(94, 293);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(100, 21);
            this.TxtValue.TabIndex = 15;
            this.TxtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValue_KeyPress);
            // 
            // CboOption
            // 
            this.CboOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboOption.FormattingEnabled = true;
            this.CboOption.Location = new System.Drawing.Point(94, 257);
            this.CboOption.Name = "CboOption";
            this.CboOption.Size = new System.Drawing.Size(121, 20);
            this.CboOption.TabIndex = 14;
            // 
            // CboCommonSelect
            // 
            this.CboCommonSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCommonSelect.FormattingEnabled = true;
            this.CboCommonSelect.Location = new System.Drawing.Point(94, 221);
            this.CboCommonSelect.Name = "CboCommonSelect";
            this.CboCommonSelect.Size = new System.Drawing.Size(121, 20);
            this.CboCommonSelect.TabIndex = 13;
            this.CboCommonSelect.SelectedIndexChanged += new System.EventHandler(this.CboCommonSelect_SelectedIndexChanged);
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(94, 185);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Size = new System.Drawing.Size(156, 21);
            this.TxtDate.TabIndex = 11;
            this.TxtDate.Enter += new System.EventHandler(this.TxtDate_Enter);
            // 
            // CboItem
            // 
            this.CboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboItem.FormattingEnabled = true;
            this.CboItem.Location = new System.Drawing.Point(94, 149);
            this.CboItem.Name = "CboItem";
            this.CboItem.Size = new System.Drawing.Size(121, 20);
            this.CboItem.TabIndex = 10;
            this.CboItem.SelectedIndexChanged += new System.EventHandler(this.CboItem_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "原因:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "分值:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "加减:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "常用项:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "日期:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "项目:";
            // 
            // LblObject
            // 
            this.LblObject.AutoSize = true;
            this.LblObject.Location = new System.Drawing.Point(14, 24);
            this.LblObject.Name = "LblObject";
            this.LblObject.Size = new System.Drawing.Size(83, 12);
            this.LblObject.TabIndex = 1;
            this.LblObject.Text = "单个学生查找:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "对象:";
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(285, 458);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(66, 23);
            this.BtnDel.TabIndex = 26;
            this.BtnDel.Text = "移除";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(191, 458);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(67, 23);
            this.BtnAdd.TabIndex = 22;
            this.BtnAdd.Text = "添加";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LstNames
            // 
            this.LstNames.FormattingEnabled = true;
            this.LstNames.ItemHeight = 12;
            this.LstNames.Location = new System.Drawing.Point(257, 16);
            this.LstNames.Name = "LstNames";
            this.LstNames.Size = new System.Drawing.Size(148, 436);
            this.LstNames.TabIndex = 19;
            // 
            // LstValue
            // 
            this.LstValue.FormattingEnabled = true;
            this.LstValue.ItemHeight = 12;
            this.LstValue.Location = new System.Drawing.Point(668, 152);
            this.LstValue.Name = "LstValue";
            this.LstValue.Size = new System.Drawing.Size(120, 88);
            this.LstValue.TabIndex = 25;
            this.LstValue.Visible = false;
            // 
            // TreeClass
            // 
            this.TreeClass.CheckBoxes = true;
            this.TreeClass.Location = new System.Drawing.Point(12, 16);
            this.TreeClass.Name = "TreeClass";
            this.TreeClass.Size = new System.Drawing.Size(222, 436);
            this.TreeClass.TabIndex = 20;
            this.TreeClass.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeClass_AfterCheck);
            // 
            // FrmPointExchanged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 486);
            this.Controls.Add(this.TreeClass);
            this.Controls.Add(this.LstNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrpPointExchanged);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.LstValue);
            this.Controls.Add(this.BtnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPointExchanged";
            this.Text = "加减分";
            this.Load += new System.EventHandler(this.FrmPointExchanged_Load);
            this.GrpPointExchanged.ResumeLayout(false);
            this.GrpPointExchanged.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpPointExchanged;
        private System.Windows.Forms.RichTextBox TxtReason;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.ComboBox CboOption;
        private System.Windows.Forms.ComboBox CboCommonSelect;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.ComboBox CboItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblObject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.ListBox LstNames;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TreeView TreeClass;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ListBox LstSearching;
        private System.Windows.Forms.MonthCalendar DpkDate;
        private System.Windows.Forms.ListBox LstValue;
        private System.Windows.Forms.ListBox LstNumber;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Label label1;
    }
}