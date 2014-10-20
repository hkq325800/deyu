namespace MoralEvaluated
{
    partial class FrmAdStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMz = new System.Windows.Forms.TextBox();
            this.TxtBj = new System.Windows.Forms.TextBox();
            this.TxtJob = new System.Windows.Forms.TextBox();
            this.TxtPart = new System.Windows.Forms.TextBox();
            this.TxtDormitory = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.TreeSearch = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txtusid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnYes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "班级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "职务";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "政治面貌:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "宿舍";
            // 
            // TxtMz
            // 
            this.TxtMz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtMz.Location = new System.Drawing.Point(309, 38);
            this.TxtMz.Name = "TxtMz";
            this.TxtMz.ReadOnly = true;
            this.TxtMz.Size = new System.Drawing.Size(100, 21);
            this.TxtMz.TabIndex = 6;
            // 
            // TxtBj
            // 
            this.TxtBj.Location = new System.Drawing.Point(123, 80);
            this.TxtBj.Name = "TxtBj";
            this.TxtBj.ReadOnly = true;
            this.TxtBj.Size = new System.Drawing.Size(100, 21);
            this.TxtBj.TabIndex = 7;
            // 
            // TxtJob
            // 
            this.TxtJob.Location = new System.Drawing.Point(123, 120);
            this.TxtJob.Name = "TxtJob";
            this.TxtJob.ReadOnly = true;
            this.TxtJob.Size = new System.Drawing.Size(100, 21);
            this.TxtJob.TabIndex = 8;
            // 
            // TxtPart
            // 
            this.TxtPart.Location = new System.Drawing.Point(308, 80);
            this.TxtPart.Name = "TxtPart";
            this.TxtPart.ReadOnly = true;
            this.TxtPart.Size = new System.Drawing.Size(100, 21);
            this.TxtPart.TabIndex = 9;
            // 
            // TxtDormitory
            // 
            this.TxtDormitory.Location = new System.Drawing.Point(309, 120);
            this.TxtDormitory.Name = "TxtDormitory";
            this.TxtDormitory.ReadOnly = true;
            this.TxtDormitory.Size = new System.Drawing.Size(100, 21);
            this.TxtDormitory.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.TreeSearch);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 167);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(414, 138);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // TreeSearch
            // 
            this.TreeSearch.Location = new System.Drawing.Point(54, 20);
            this.TreeSearch.Name = "TreeSearch";
            this.TreeSearch.Size = new System.Drawing.Size(354, 141);
            this.TreeSearch.TabIndex = 21;
            this.TreeSearch.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeSearch_NodeMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txtusid);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnYes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtDormitory);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtPart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtJob);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtBj);
            this.groupBox2.Controls.Add(this.TxtMz);
            this.groupBox2.Location = new System.Drawing.Point(15, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 226);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Txtusid
            // 
            this.Txtusid.Location = new System.Drawing.Point(123, 38);
            this.Txtusid.Name = "Txtusid";
            this.Txtusid.ReadOnly = true;
            this.Txtusid.Size = new System.Drawing.Size(100, 21);
            this.Txtusid.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "学号";
            // 
            // BtnYes
            // 
            this.BtnYes.Location = new System.Drawing.Point(343, 170);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(91, 31);
            this.BtnYes.TabIndex = 13;
            this.BtnYes.Text = "完成";
            this.BtnYes.UseVisualStyleBackColor = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "照片(待开发)";
            this.label6.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(539, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 216);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAdStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdStudent";
            this.Text = "学生管理";
            this.Load += new System.EventHandler(this.FrmAdStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMz;
        private System.Windows.Forms.TextBox TxtBj;
        private System.Windows.Forms.TextBox TxtJob;
        private System.Windows.Forms.TextBox TxtPart;
        private System.Windows.Forms.TextBox TxtDormitory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView TreeSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox Txtusid;
        private System.Windows.Forms.Label label8;
    }
}