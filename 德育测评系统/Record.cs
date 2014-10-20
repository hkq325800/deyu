using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MoralEvaluated;

namespace MoralEvaluated
{
    public partial class FrmRecord : FrmModel
    {
        public FrmRecord()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TxtPoint.Text) == 0)
            {
                MessageBox.Show("分数有误!");
                return;
            }
            if (Convert.ToDouble(TxtPoint.Text) > 10)
            {
                MessageBox.Show("单次加分最多为10分!");
                return;
            }
            GloVariant.stu_name = TxtStudent.Text;
            GloVariant.ca_name = CboCategory.Text;
            GloVariant.point = TxtPoint.Text;
            GloVariant.op_reason = TxtReason.Text;
            GloVariant.time = DtpDate.Text;
            DialogResult = DialogResult.Yes;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void FrmRecord_Load(object sender, EventArgs e)
        {
            GloVariant.ReadCategory(ref CboCategory);
            TxtStudent.Text = GloVariant.stu_name;
            CboCategory.Text = GloVariant.ca_name;
            TxtPoint.Text = GloVariant.point;
            TxtReason.Text = GloVariant.op_reason;
            TxtOperater.Text = GloVariant.op_name;
            DtpDate.Text = GloVariant.time;
        }

    }
}
