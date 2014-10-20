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
    public partial class FrmAddSemester : FrmModel
    {
       
        public FrmAddSemester()
        {
            InitializeComponent();
        }
        private void FrmAddSemester_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            CmbSeYear.Text = year.ToString();
            if(month>7)
            {
                CmbSeTerm.Text = "2";
                DtpSeStartTime.Text = year+"/"+"09/01";
                DtpSeEndTime.Text = ++year+"/"+"01/31";
            }
            else
            {
                CmbSeTerm.Text = "1";
                DtpSeStartTime.Text = year+"/"+"03/01";
                DtpSeEndTime.Text = year+"/"+"07/01";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("是否确认添加？","确认",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string Se_Year = CmbSeYear.Text;
                string Se_Term = CmbSeTerm.Text;
                string Se_Start = DtpSeStartTime.Text;
                string Se_End = DtpSeEndTime.Text;    
                string sql = "insert into hdu_sce.semester (co_id,se_year,se_term,se_start,se_end) values(1,'"+Se_Year+"','"+Se_Term+"','"+Se_Start+"','"+Se_End+"')";
                MySQLCommand command = new MySQLCommand(sql, GloVariant.conn);
                try//异常处理
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("添加成功！");
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("“起始日期”·“结束日期”有误或是该记录已经存在！");
                }
                command.Dispose();
                return;
            }
            else
                return;
        }

        private void CmbSeTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbSeTerm.Text == "1")
            {
                DtpSeStartTime.Text = CmbSeYear.Text + "/" + "03/01";
                DtpSeEndTime.Text = CmbSeYear.Text + "/" + "07/01";
            }
            else
            {
                DtpSeStartTime.Text = CmbSeYear.Text + "/" + "09/01";
                int year = Convert.ToInt16(CmbSeYear.Text);
                DtpSeEndTime.Text = ++year + "/" + "01/31";
            }
        }

      
    }
}
