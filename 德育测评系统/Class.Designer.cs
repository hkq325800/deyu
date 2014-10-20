namespace MoralEvaluated
{
    partial class FrmClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClass));
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnAddClass = new System.Windows.Forms.Button();
            this.TreeClass = new System.Windows.Forms.TreeView();
            this.BtnAddProfession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(297, 465);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 3;
            this.BtnDel.Text = "删除班级";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(297, 423);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 23);
            this.BtnModify.TabIndex = 2;
            this.BtnModify.Text = "修改";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnAddClass
            // 
            this.BtnAddClass.Location = new System.Drawing.Point(297, 382);
            this.BtnAddClass.Name = "BtnAddClass";
            this.BtnAddClass.Size = new System.Drawing.Size(75, 23);
            this.BtnAddClass.TabIndex = 1;
            this.BtnAddClass.Text = "添加班级";
            this.BtnAddClass.UseVisualStyleBackColor = true;
            this.BtnAddClass.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TreeClass
            // 
            this.TreeClass.Location = new System.Drawing.Point(12, 12);
            this.TreeClass.Name = "TreeClass";
            this.TreeClass.Size = new System.Drawing.Size(279, 476);
            this.TreeClass.TabIndex = 0;
            this.TreeClass.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeClass_AfterExpand);
            this.TreeClass.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeClass_AfterSelect);
            this.TreeClass.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeClass_NodeMouseClick);
            // 
            // BtnAddProfession
            // 
            this.BtnAddProfession.Location = new System.Drawing.Point(297, 340);
            this.BtnAddProfession.Name = "BtnAddProfession";
            this.BtnAddProfession.Size = new System.Drawing.Size(75, 23);
            this.BtnAddProfession.TabIndex = 4;
            this.BtnAddProfession.Text = "添加专业";
            this.BtnAddProfession.UseVisualStyleBackColor = true;
            this.BtnAddProfession.Click += new System.EventHandler(this.BtnAddProfession_Click);
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 500);
            this.Controls.Add(this.BtnAddProfession);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnAddClass);
            this.Controls.Add(this.TreeClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClass";
            this.Text = "专业班级";
            this.Load += new System.EventHandler(this.Class_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeClass;
        private System.Windows.Forms.Button BtnAddClass;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnAddProfession;
    }
}