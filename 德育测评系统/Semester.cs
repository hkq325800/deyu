using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MoralEvaluated;
using MySQLDriverCS;

namespace MoralEvaluated
{
    public partial class FrmSemester : FrmModel
    {
        public FrmSemester()
        {
            InitializeComponent();
        }

        public void Load_Semester()
        {
            LtbSemester.Items.Clear();
            Ltbse_id.Items.Clear();
            string sql = "select * from hdu_sce.semester order by se_year,se_term";
            MySQLCommand command = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                string Se_Id = datareader["se_id"].ToString();
                Ltbse_id.Items.Add(Se_Id);//保存对应数据到隐藏的Ltbse_id里，以便于“删除所选”时用到
                string Se_Year = datareader["se_year"].ToString();
                string Se_Term = datareader["se_term"].ToString();
                DateTime Se_Start = (DateTime)datareader["se_start"];
                DateTime Se_End = (DateTime)datareader["se_end"];
                LtbSemester.Items.Add(Se_Year + "学年第" + Se_Term + "学期\t\t\t" + Se_Start.ToShortDateString().ToString() + "\t\t" + Se_End.ToShortDateString().ToString());
            }
            datareader.Close();
            command.Dispose();
        }

        private void Semester_Load(object sender, EventArgs e)
        {
            Load_Semester();
        }

        private void LtbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LtbSemester.SelectedIndex < 0)
                return;
            Ltbse_id.SelectedIndex = LtbSemester.SelectedIndex;
            GloVariant.se_id = Ltbse_id.SelectedItem.ToString();
        }

        private void BtAddSem_Click(object sender, EventArgs e)
        {
            FrmAddSemester frmAddSemester = new FrmAddSemester();
            frmAddSemester.ShowDialog();
            if (frmAddSemester.DialogResult == DialogResult.OK)
                Load_Semester();
                
        }

        private void BtDelSem_Click(object sender, EventArgs e)
        {
            if (LtbSemester.SelectedIndex != -1)
            { 
                if (MessageBox.Show("是否确认删除所选？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sql = "delete from hdu_sce.semester where se_id = " + Ltbse_id.SelectedItem.ToString();
                    MySQLCommand command = new MySQLCommand(sql, GloVariant.conn);
                    try//异常处理
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("删除成功！");
                        Load_Semester();
                    }
                    catch
                    {
                        MessageBox.Show("删除失败！您是否已经选中某一条记录？");
                    }
                    command.Dispose();
                }
            }            
            else
                MessageBox.Show("请先选中需要删除的选项！");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (LtbSemester.SelectedIndex != -1)
            {
                FrmUpDateSemester frmUpDateSemester = new FrmUpDateSemester();
                frmUpDateSemester.ShowDialog();
                Load_Semester();
            }
            else
                MessageBox.Show("请先选中需要修改的选项！");
        }      
    }
}
