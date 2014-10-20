using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoralEvaluated
{
    public partial class FrmIndex : Form
    {
        private bool IsChildFormExsit(string childFrmName)
        {            
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == childFrmName)
                {
                    if (childForm.WindowState == FormWindowState.Minimized)
                        childForm.WindowState = FormWindowState.Normal;                        
                    childForm.Activate();
                    return true;
                }
            }
            return false;
        }

        public FrmIndex()
        {
            InitializeComponent();
        }

        private void FrmIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            GloVariant.conn.Close();
        }

        private void MnuItmPointExchange_Click(object sender, EventArgs e)
        {
            if (!IsChildFormExsit("FrmPointExchanged"))
            {
                FrmPointExchanged frmPointExchanged = new FrmPointExchanged();
                frmPointExchanged.MdiParent = this;
                frmPointExchanged.Show();
            }
        }

        private void MnuItmPersonInfo_Click(object sender, EventArgs e)
        {
            if (!IsChildFormExsit("FrmPersonInfo"))
            {
                FrmPersonInfo frmPersonInfo = new FrmPersonInfo();
                frmPersonInfo.MdiParent = this;
                frmPersonInfo.Show();
            }
        }

        private void MnuItmSummarize_Click(object sender, EventArgs e)
        {
            if (!IsChildFormExsit("FrmSummarize"))
            {
                FrmSummarize frmSummarize = new FrmSummarize();
                frmSummarize.MdiParent = this;
                frmSummarize.Show();
            }
        }

        private void MnuItmHistory_Click(object sender, EventArgs e)
        {
            if (!IsChildFormExsit("FrmHistory"))
            {
                FrmHistory frmHistory = new FrmHistory();
                frmHistory.MdiParent = this;
                frmHistory.Show();
            }
        }

        private void MnuItmWindows_DropDownOpening(object sender, EventArgs e)
        {
            MnuItmWindows.DropDownItems.Clear();
            foreach (Form ChildFrm in this.MdiChildren)
            {
                MnuItmWindows.DropDownItems.Add(ChildFrm.Text);
            }
        }

        private void MnuItmWindows_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Text == e.ClickedItem.Text)
                {
                    ChildForm.Activate();
                    ChildForm.SetDesktopLocation(0, 0);
                }
            }
        }

        private void MnuItmClass_Click(object sender, EventArgs e)
        {
            if (!IsChildFormExsit("FrmClass"))
            {
                FrmClass frmClass = new FrmClass();
                frmClass.MdiParent = this;
                frmClass.Show();
            }
        }

        private void MnuItmAdStu_Click(object sender, EventArgs e)
        {
            if (!IsChildFormExsit("AdFrmStudent"))
            {
                FrmAdStudent frmAdStudent = new FrmAdStudent();
                frmAdStudent.MdiParent = this;
                frmAdStudent.Show();
            }
        }

        private void MnuItmEvaItem_Click(object sender, EventArgs e)
        {
            if (!IsChildFormExsit("FrmEvaItem"))
            {
                FrmEvaItem frmEvaItem = new FrmEvaItem();
                frmEvaItem.MdiParent = this;
                frmEvaItem.Show();
            }
        }

        private void MnuItmAdAdmin_Click(object sender, EventArgs e)
        {
            if (!IsChildFormExsit("FrmAdAdmin"))
            {
                FrmAdAdmin frmAdAdmin = new FrmAdAdmin();
                frmAdAdmin.MdiParent = this;
                frmAdAdmin.Show();
            }
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {
            if (GloVariant.Rank == "1002")
                MnuItmAdAdmin.Visible = false;
            if (GloVariant.Rank == "1003")
            {
                MnuItmRead.Visible = true;
                MnuItmUserAdmin.Visible = false;
                MnuItmBaseConfig.Visible = false;
                MnuItmEva.Visible = false;
            }
        }

        private void MnuItmSemester_Click(object sender, EventArgs e)
        {
            if (!IsChildFormExsit("FrmSemester"))
            {
                FrmSemester frmSemester = new FrmSemester();
                frmSemester.MdiParent = this;
                frmSemester.Show();
            }
        }
    }
}
