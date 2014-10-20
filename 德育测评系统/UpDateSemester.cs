using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySQLDriverCS;
using MoralEvaluated;

namespace MoralEvaluated
{
    public partial class FrmUpDateSemester : FrmModel
    {
        public FrmUpDateSemester()
        {
            InitializeComponent();
        }

        private void FrmUpDateSemester_Load(object sender, EventArgs e)
        {
            string sql = "select * from hdu_sce.semester se where se.se_id = " + GloVariant.se_id;
            MySQLCommand command = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader reader = command.ExecuteReaderEx();
            reader.Read();
            CmbSeYear.Text = reader["se_year"].ToString();
            CmbSeTerm.Text = reader["se_term"].ToString();
            DtpSeStartTime.Text = reader["se_start"].ToString();
            DtpSeEndTime.Text = reader["se_end"].ToString();
            reader.Close();
            command.Dispose();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认修改所选？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "update hdu_sce.semester set se_year = " + CmbSeYear.Text + ",se_term = " + CmbSeTerm.Text + ",se_start = '" + DtpSeStartTime.Text + "',se_end = '" + DtpSeEndTime.Text+ "' where se_id = " + GloVariant.se_id;
                MySQLCommand command = new MySQLCommand(sql, GloVariant.conn);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("修改成功！");
                    Close();
                }
                catch
                {
                    MessageBox.Show("修改失败！或许已经存在这样一条记录亦或其他原因！");
                }
                command.Dispose();
            }
        }
      
    }
}
