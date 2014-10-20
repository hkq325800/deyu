namespace MoralEvaluated
{
    partial class FrmAdAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdAdmin));
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnDetail = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DgvAdmin = new System.Windows.Forms.DataGridView();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colusid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnModState = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(329, 406);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(96, 23);
            this.BtnModify.TabIndex = 3;
            this.BtnModify.Text = "修改信息";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(474, 406);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(88, 23);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "重置密码";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnDetail
            // 
            this.BtnDetail.Location = new System.Drawing.Point(171, 406);
            this.BtnDetail.Name = "BtnDetail";
            this.BtnDetail.Size = new System.Drawing.Size(108, 23);
            this.BtnDetail.TabIndex = 2;
            this.BtnDetail.Text = "查看详细信息";
            this.BtnDetail.UseVisualStyleBackColor = true;
            this.BtnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(32, 406);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(87, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "增加管理员";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DgvAdmin
            // 
            this.DgvAdmin.AllowUserToAddRows = false;
            this.DgvAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck,
            this.ColID,
            this.ColName,
            this.ColRank,
            this.ColStatus,
            this.Colusid});
            this.DgvAdmin.Location = new System.Drawing.Point(12, 12);
            this.DgvAdmin.Name = "DgvAdmin";
            this.DgvAdmin.RowTemplate.Height = 23;
            this.DgvAdmin.Size = new System.Drawing.Size(716, 371);
            this.DgvAdmin.TabIndex = 0;
            // 
            // ColCheck
            // 
            this.ColCheck.HeaderText = "";
            this.ColCheck.Name = "ColCheck";
            // 
            // ColID
            // 
            this.ColID.HeaderText = "账号";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "姓名";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColRank
            // 
            this.ColRank.HeaderText = "权限";
            this.ColRank.Name = "ColRank";
            this.ColRank.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "状态";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // Colusid
            // 
            this.Colusid.HeaderText = "us_id";
            this.Colusid.Name = "Colusid";
            this.Colusid.ReadOnly = true;
            this.Colusid.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(97, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // BtnModState
            // 
            this.BtnModState.Location = new System.Drawing.Point(610, 406);
            this.BtnModState.Name = "BtnModState";
            this.BtnModState.Size = new System.Drawing.Size(75, 23);
            this.BtnModState.TabIndex = 6;
            this.BtnModState.Text = "启用/禁用";
            this.BtnModState.UseVisualStyleBackColor = true;
            this.BtnModState.Click += new System.EventHandler(this.BtnModState_Click);
            // 
            // FrmAdAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 441);
            this.Controls.Add(this.BtnModState);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnDetail);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdAdmin";
            this.Text = "管理员";
            this.Load += new System.EventHandler(this.FrmAdAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAdmin;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDetail;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnModState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colusid;
    }
}