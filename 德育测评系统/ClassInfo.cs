using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MoralEvaluated.Properties;

namespace MoralEvaluated
{
    public partial class FrmClassInfo : FrmModel
    {
        public FrmClassInfo()
        {
            InitializeComponent();
        }

        private void ClassInfo_Load(object sender, EventArgs e)
        {
            GloVariant.ReadPro(ref CboPr_name);
            if (GloVariant.cl_op == "update")
            {
                TxtCl_name.Text = GloVariant.cl_number;
                TxtGrade.Text = GloVariant.grade;
            }
            CboPr_name.Text = GloVariant.pr_name;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!(TxtGrade.Text == "" || TxtCl_name.Text == "" || CboPr_name.Text == ""))
            {
                GloVariant.cl_number = TxtCl_name.Text;
                GloVariant.pr_name = CboPr_name.Text;
                GloVariant.grade = TxtGrade.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("请填写完整的信息!");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
