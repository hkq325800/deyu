using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MoralEvaluated.Properties;
using System.Drawing.Drawing2D;
using MySQLDriverCS;

namespace MoralEvaluated
{
    public partial class FrmHistory : FrmModel
    {
        public FrmHistory()
        {
            InitializeComponent();
        }
        
        private void FrmHistory_Load(object sender, EventArgs e)
        {
            CboProfession.Items.Clear();
            GloVariant.ReadCategory(ref CboCategory);
            GloVariant.ReadPro(ref CboProfession);
            CboYear.Items.Clear();
            //GloVariant.ReadYear(ref CboYear);
            CboSemester.Items.Add("1");
            CboSemester.Items.Add("2");
            int year = DateTime.Now.Year;
            CboYear.Text = DateTime.Now.Year.ToString();
            for (int i = 0; i < 4; i++)
                CboYear.Items.Add((year - i).ToString());
            if (DateTime.Now.Month > 2 && DateTime.Now.Month < 8)
                CboSemester.Text = "2";
            else
                CboSemester.Text = "1";
            CboOperator.Items.Clear();
            string sql = "select us_name from hdu_sce.user where us_id in (select distinct op_usid from hdu_sce.operate)";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                CboOperator.Items.Add(reader["us_name"].ToString());
            }
            cmd.Dispose();
            reader.Close();

        }

        protected void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                drawColumnAndRow(e);
                e.Handled = true;
            }
            else if (e.ColumnIndex < 0 && e.RowIndex >= 0)
            {
                drawColumnAndRow(e);
                e.Handled = true;
            }
        }

        void drawColumnAndRow(DataGridViewCellPaintingEventArgs e)
        {
            // 绘制背景色
            using (LinearGradientBrush backbrush = new LinearGradientBrush(e.CellBounds,ProfessionalColors.MenuItemPressedGradientBegin,ProfessionalColors.MenuItemPressedGradientMiddle,LinearGradientMode.Vertical))
            {
                System.Drawing.Rectangle border = e.CellBounds;
                border.Width -= 1;
                //填充绘制效果
                e.Graphics.FillRectangle(backbrush, border);
                //绘制Column、Row的Text信息
                e.PaintContent(e.CellBounds);
                //绘制边框
                ControlPaint.DrawBorder3D(e.Graphics, e.CellBounds, Border3DStyle.Etched);
            }
        }

        protected void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            //base.OnRowPostPaint(e);
            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            {

                int width = this.DgvDetail.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DgvDetail.RowHeadersWidth;
                System.Drawing.Rectangle rowBounds = new System.Drawing.Rectangle(0, e.RowBounds.Top, width, e.RowBounds.Height);
                using (LinearGradientBrush backbrush = 
                    new LinearGradientBrush(rowBounds, e.InheritedRowStyle.BackColor, Color.PaleVioletRed, 90.0f)) 
                    { 
                        e.Graphics.FillRectangle(backbrush, rowBounds); 
                        e.PaintCellsContent(rowBounds); e.Handled = true; 
                    }
            }
            
        }

        private void DgvDetail_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //base.OnRowPostPaint(e);
            int width = this.DgvDetail.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DgvDetail.RowHeadersWidth;
            System.Drawing.Rectangle rowBounds = new System.Drawing.Rectangle(0, e.RowBounds.Top, width, e.RowBounds.Height);
            if (this.DgvDetail.CurrentCellAddress.Y == e.RowIndex)
            {
                //设置选中边框
                e.DrawFocus(rowBounds, true);
            }
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                DgvDetail.RowHeadersWidth - 4, e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                DgvDetail.RowHeadersDefaultCellStyle.Font,
                    rectangle,
                    DgvDetail.RowHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Right); 
        }

        private void CboProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboProfession.SelectedIndex < 0)
                return;
            CboGrade.Items.Clear();
            GloVariant.ReadGrade(CboProfession.Text, ref CboGrade);
        }

        private void CboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboGrade.SelectedIndex < 0)
                return;
            CboClass.Items.Clear();
            GloVariant.ReadClass(CboProfession.Text, CboGrade.Text, ref CboClass);
        }

        private void CboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboClass.SelectedIndex < 0)
                return;
            LstStudent.Items.Clear();
            LstValue.Items.Clear();
            GloVariant.ReadStu(CboClass.Text, ref LstStudent, ref LstValue);
        }

        private void LstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboYear.Text == "" || CboSemester.Text == "")
            {
                MessageBox.Show("请选择学年学期!");
                return;
            }
            if (LstStudent.SelectedIndex < 0)
                return;
            string sql = "select t1.op_id,t3.us_name,ca_name,it_score,date_format(it_date,'%y-%m-%d') as it_date,t5.us_name as op_name,op_time,it_reason from hdu_sce.operate t1 join hdu_sce.studentoperate t2 on (t1.op_id = t2.op_id) join hdu_sce.user t3 on (t2.us_id = t3.us_id) join hdu_sce.category t4 on (t1.ca_id = t4.ca_id) join hdu_sce.user t5 on (t1.op_usid = t5.us_id) where t2.us_id = " + LstValue.Items[LstStudent.SelectedIndex].ToString() + " and it_date between (select se_start from hdu_sce.semester where se_year = " + CboYear.Text + " and se_term = " + CboSemester.Text + ") and (select se_end from hdu_sce.semester where se_year = " + CboYear.Text + " and se_term = " + CboSemester.Text + ")";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            DgvDetail.Rows.Clear();
            while (reader.Read())
            {
                int index = this.DgvDetail.Rows.Add();
                this.DgvDetail.Rows[index].Cells[1].Value = reader["us_name"].ToString();
                this.DgvDetail.Rows[index].Cells[2].Value = reader["ca_name"].ToString();
                this.DgvDetail.Rows[index].Cells[3].Value = reader["it_score"].ToString();
                this.DgvDetail.Rows[index].Cells[4].Value = reader["it_date"].ToString();
                this.DgvDetail.Rows[index].Cells[5].Value = reader["op_name"].ToString();
                this.DgvDetail.Rows[index].Cells[6].Value = reader["op_time"].ToString();
                this.DgvDetail.Rows[index].Cells[7].Value = reader["it_reason"].ToString();
                this.DgvDetail.Rows[index].Cells[8].Value = reader["op_id"].ToString();
            }
            reader.Close();
            CboCategory_SelectedIndexChanged(sender, e);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (CboOperator.SelectedIndex < 0)
                return;
            string sql = "select t1.op_id,t3.us_name,ca_name,it_score,date_format(it_date,'%y-%m-%d') as it_date,t5.us_name as op_name,op_time,it_reason from hdu_sce.operate t1 join hdu_sce.studentoperate t2 on (t1.op_id = t2.op_id) join hdu_sce.user t3 on (t2.us_id = t3.us_id) join hdu_sce.category t4 on (t1.ca_id = t4.ca_id) join hdu_sce.user t5 on (t1.op_usid = t5.us_id) where t5.us_name = '" + CboOperator.Text + "' and op_time between '" + DtpOpBegin.Text + "' and '" + Convert.ToDateTime(DtpOpEnd.Text).AddDays(1).ToString() + "'";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            DgvDetail.Rows.Clear();
            while (reader.Read())
            {
                int index = this.DgvDetail.Rows.Add();
                this.DgvDetail.Rows[index].Cells[1].Value = reader["us_name"].ToString();
                this.DgvDetail.Rows[index].Cells[2].Value = reader["ca_name"].ToString();
                this.DgvDetail.Rows[index].Cells[3].Value = reader["it_score"].ToString();
                this.DgvDetail.Rows[index].Cells[4].Value = reader["it_date"].ToString();
                this.DgvDetail.Rows[index].Cells[5].Value = reader["op_name"].ToString();
                this.DgvDetail.Rows[index].Cells[6].Value = reader["op_time"].ToString();
                this.DgvDetail.Rows[index].Cells[7].Value = reader["it_reason"].ToString();
                this.DgvDetail.Rows[index].Cells[8].Value = reader["op_id"].ToString();
            }
            reader.Close();
            CboCategory_SelectedIndexChanged(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int count = DgvDetail.Rows.Count;
            int no = 0;
            int selectno = 0;
            for (int i = count - 1; i >= 0; i--)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvDetail.Rows[i].Cells[0];
                bool flag = Convert.ToBoolean(checkCell.Value);
                if (flag)
                    selectno++;
            }
            if (selectno == 0)
                return;
            if (MessageBox.Show("你真的要删除这" + selectno.ToString() +"条加分记录吗?此操作不可恢复!", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            for (int i = count - 1; i >= 0; i--)
            {
                DgvDetail.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvDetail.Rows[i].Cells[0];
                bool flag = Convert.ToBoolean(checkCell.Value);
                if (flag)
                {
                    string op_id;
                    try
                    {
                        op_id = DgvDetail.Rows[i].Cells[8].Value.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("选择有误");
                        return;
                    }
                    if (GloVariant.DelOperate(op_id))
                    {
                        DgvDetail.Rows.Remove(DgvDetail.Rows[i]);
                        no++;
                    }
                }
            }
            MessageBox.Show(no.ToString() + "条记录已删除");
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string sql = "select t1.op_id,t3.us_name,ca_name,it_score,date_format(it_date,'%y-%m-%d') as it_date,t5.us_name as op_name,op_time,it_reason from hdu_sce.operate t1 join hdu_sce.studentoperate t2 on (t1.op_id = t2.op_id) join hdu_sce.user t3 on (t2.us_id = t3.us_id) join hdu_sce.category t4 on (t1.ca_id = t4.ca_id) join hdu_sce.user t5 on (t1.op_usid = t5.us_id) where t4.ca_name = '" + CboCategory.Text + "'";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            DgvDetail.Rows.Clear();
            while (reader.Read())
            {
                int index = this.DgvDetail.Rows.Add();
                this.DgvDetail.Rows[index].Cells[1].Value = reader["us_name"].ToString();
                this.DgvDetail.Rows[index].Cells[2].Value = reader["ca_name"].ToString();
                this.DgvDetail.Rows[index].Cells[3].Value = reader["it_score"].ToString();
                this.DgvDetail.Rows[index].Cells[4].Value = reader["it_date"].ToString();
                this.DgvDetail.Rows[index].Cells[5].Value = reader["op_name"].ToString();
                this.DgvDetail.Rows[index].Cells[6].Value = reader["op_time"].ToString();
                this.DgvDetail.Rows[index].Cells[7].Value = reader["it_reason"].ToString();
                this.DgvDetail.Rows[index].Cells[8].Value = reader["op_id"].ToString();
            }
            reader.Close();
             */
            if (CboCategory.SelectedIndex < 0)
                return;
            int count = DgvDetail.Rows.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                DgvDetail.Rows[i].Visible = true;
            }
            if (CboCategory.Text == "全部")
                return;
            for (int i = count - 1; i >= 0; i--)
            {
                DataGridViewTextBoxCell txt = (DataGridViewTextBoxCell)DgvDetail.Rows[i].Cells[2];
                if (txt.Value.ToString() != CboCategory.Text)
                {
                    DgvDetail.Rows[i].Visible = false;
                    DataGridViewCheckBoxCell ckb = (DataGridViewCheckBoxCell)DgvDetail.Rows[i].Cells[0];
                    if (Convert.ToBoolean(ckb.Value))
                        DgvDetail.Rows[i].Cells[0].Value = false;
                }
            }
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            int count = DgvDetail.Rows.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                DgvDetail.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvDetail.Rows[i].Cells[0];
                checkCell.Value = true;
            }
        }

        private void BtnContrary_Click(object sender, EventArgs e)
        {
            int count = DgvDetail.Rows.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                DgvDetail.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvDetail.Rows[i].Cells[0];
                if (Convert.ToBoolean(checkCell.Value))
                    checkCell.Value = false;
                else
                    checkCell.Value = true;
            }
        }

        private void CboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboSemester.SelectedIndex = 0;
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            //此处可优化,提取ckb定义到循环外
            int se_no = 0;
            for (int i = 0; i < DgvDetail.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell ckb = (DataGridViewCheckBoxCell)DgvDetail.Rows[i].Cells[0];
                if (Convert.ToBoolean(ckb.Value))
                    se_no++;
            }
            if (se_no == 0)
            {
                MessageBox.Show("请先选择要修改的记录!");
                return;
            }
            else if (se_no > 1)
            {
                MessageBox.Show("一次只能修改一条记录!");
                return;
            }
            for (int i = 0; i < DgvDetail.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell ckb = (DataGridViewCheckBoxCell)DgvDetail.Rows[i].Cells[0];
                if (Convert.ToBoolean(ckb.Value))
                {
                    string op_id = DgvDetail.Rows[i].Cells[8].Value.ToString();
                    GloVariant.stu_name = DgvDetail.Rows[i].Cells[1].Value.ToString();
                    GloVariant.ca_name = DgvDetail.Rows[i].Cells[2].Value.ToString();
                    GloVariant.point = DgvDetail.Rows[i].Cells[3].Value.ToString();
                    GloVariant.op_name = DgvDetail.Rows[i].Cells[5].Value.ToString();
                    GloVariant.op_reason = DgvDetail.Rows[i].Cells[7].Value.ToString();
                    GloVariant.time = DgvDetail.Rows[i].Cells[4].Value.ToString();
                    FrmRecord frmRecord = new FrmRecord();
                    frmRecord.ShowDialog();
                    if (frmRecord.DialogResult == DialogResult.No)
                        return;
                    string sql = "update hdu_sce.operate set ca_id = (select ca_id from hdu_sce.category where ca_name = '" + GloVariant.ca_name + "'),it_score = " + GloVariant.point + ",it_reason = '" + GloVariant.op_reason + "',op_time = '" + DateTime.Now.ToString() + "',it_date = '" + GloVariant.time + "' where op_id = " + op_id;
                    MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改成功!");
                    }
                    catch
                    {
                        MessageBox.Show("修改失败!");
                    }
                }
            }
        }
    }
}
