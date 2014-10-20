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
using Microsoft.Office;

namespace MoralEvaluated
{
    
    public partial class FrmSummarize : FrmModel
    {
        TreeNodeMouseClickEventArgs curTn;
        DataSet ds;

        public FrmSummarize()
        {
            InitializeComponent();
        }

        private void FrmSummarize_Load(object sender, EventArgs e)
        {
            /*CboMajor.Items.Clear();
            GloVariant.ReadPro(ref CboMajor);
            //下面是我新加的
            CboYear.Items.Clear();
            GloVariant.ReadToCom("se_year", ref CboYear);
            CboSemester.Items.Clear();
            GloVariant.ReadToCom("se_term", CboYear.Items.ToString(), ref CboSemester);
             */
            GloVariant.ReadYear(ref CboYear);
            CboYear.SelectedIndex = 0;
            string sql;
            MySQLCommand cmd;
            sql = "select * from hdu_sce.college";
            cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataAdapter adapter = new MySQLDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "college");
            adapter.Dispose();
            foreach (DataRow row in ds.Tables["college"].Rows)
            {
                TreeClass.Nodes.Add(row["co_name"].ToString());
            }
            for (int i = 0; i < TreeClass.Nodes.Count; i++)
                TreeClass.Nodes[i].Nodes.Add("null");
        }

        private void TreeClass_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            /*string sql;
            MySQLDataAdapter adapter;
            MySQLCommand cmd;
            DataSet ds = new DataSet();
            if (e.Node.Level == 0)
            {
                e.Node.Nodes.Clear();
                sql = "select co_name,pr_name from hdu_sce.profession t1 join hdu_sce.college t2 on (t1.co_id = t2.co_id)";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                adapter = new MySQLDataAdapter(cmd);
                adapter.Fill(ds, "table");
                foreach (DataRow row in ds.Tables["table"].Rows)
                {
                    if (row["co_name"].ToString() == e.Node.Text)
                        e.Node.Nodes.Add(row["pr_name"].ToString());
                }
            }
            if (e.Node.Level == 1)
            {
                e.Node.Nodes.Clear();
                sql = "select cl_grade,pr_name from hdu_sce.class t1 join hdu_sce.profession t2 on (t1.pr_id = t2.pr_id)";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                MySQLDataReader reader = cmd.ExecuteReaderEx();
                while (reader.Read())
                {
                    if (reader["pr_name"].ToString() == e.Node.Text)
                        e.Node.Nodes.Add(reader["cl_grade"].ToString());
                }
            }*/
            string sql;
            e.Node.Nodes.Clear();
            MySQLCommand cmd;
            MySQLDataAdapter adapter;
            ds = new DataSet();
            if (e.Node.Level == 0)
            {
                sql = "select co_name,pr_name from hdu_sce.profession t1 join hdu_sce.college t2 on (t1.co_id = t2.co_id)";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                adapter = new MySQLDataAdapter(cmd);
                adapter.Fill(ds, "table");
                foreach (DataRow row in ds.Tables["table"].Rows)
                {
                    if (row["co_name"].ToString() == e.Node.Text)
                        e.Node.Nodes.Add(row["pr_name"].ToString());
                }
            }
            else if (e.Node.Level == 2)
            {
                sql = "select cl_name,t2.pr_name,cl_grade from hdu_sce.class t1 join hdu_sce.profession t2 on (t1.pr_id = t2.pr_id)";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                adapter = new MySQLDataAdapter(cmd);
                adapter.Fill(ds, "table");
                foreach (DataRow row in ds.Tables["table"].Rows)
                {
                    if (row["pr_name"].ToString() == e.Node.Parent.Text && row["cl_grade"].ToString() == e.Node.Text)
                        e.Node.Nodes.Add(row["cl_name"].ToString());
                }
            }
            else if (e.Node.Level == 1)
            {
                sql = "select distinct cl_grade from hdu_sce.class order by cl_grade";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                adapter = new MySQLDataAdapter(cmd);
                adapter.Fill(ds, "table");
                foreach (DataRow row in ds.Tables["table"].Rows)
                {
                    e.Node.Nodes.Add(row["cl_grade"].ToString());
                }
            }
            else if (e.Node.Level == 3)
            {
                sql = "SELECT us_name AS 姓名, us_number AS 学号, IFNULL(n2.`德育测评`,70) as 德育测评, IFNULL(n3.`技能测评`,70) as 技能测评, IFNULL(n4.`体育测评`,75) as 体育测评, IFNULL(n2.`德育测评` * 0.2 + n3.`技能测评` * 0.15 + n4.`体育测评` * 0.05,28.25) AS 总分 FROM ( SELECT t1.us_id, us_name, us_number FROM hdu_sce. USER t1 JOIN hdu_sce.student t2 ON (t1.us_id = t2.us_id) where cl_id = (select cl_id from hdu_sce.class where cl_name = '" + e.Node.Text + "')) n1 LEFT JOIN ( SELECT us_id, IFNULL(count(it_score) + 70, 70) AS 德育测评 FROM hdu_sce.operate t3 JOIN hdu_sce.studentoperate t4 ON (t3.op_id = t4.op_id) WHERE it_date BETWEEN ( SELECT se_start FROM hdu_sce.semester WHERE ca_id = 1 AND se_year = " + CboYear.Text + " AND se_term = " + CboSemester.Text + " ) AND ( SELECT se_end FROM hdu_sce.semester WHERE se_year = " + CboYear.Text + " AND se_term = " + CboSemester.Text + " ) GROUP BY us_id ) n2 ON (n1.us_id = n2.us_id) LEFT JOIN ( SELECT us_id, IFNULL(count(it_score) + 70, 70) AS 技能测评 FROM hdu_sce.operate t3 JOIN hdu_sce.studentoperate t4 ON (t3.op_id = t4.op_id) WHERE it_date BETWEEN ( SELECT se_start FROM hdu_sce.semester WHERE (ca_id = 2 OR TRUE) AND se_year = " + CboYear.Text + " AND se_term = " + CboSemester.Text + " ) AND ( SELECT se_end FROM hdu_sce.semester WHERE se_year = " + CboYear.Text + " AND se_term = " + CboSemester.Text + " ) GROUP BY us_id ) n3 ON (n1.us_id = n3.us_id) LEFT JOIN ( SELECT us_id, IFNULL(count(it_score) + 75, 75) AS 体育测评 FROM hdu_sce.operate t3 JOIN hdu_sce.studentoperate t4 ON (t3.op_id = t4.op_id) WHERE it_date BETWEEN ( SELECT se_start FROM hdu_sce.semester WHERE (ca_id = 3 OR TRUE) AND se_year = " + CboYear.Text + " AND se_term = " + CboSemester.Text + " ) AND ( SELECT se_end FROM hdu_sce.semester WHERE se_year = " + CboYear.Text + " AND se_term = " + CboSemester.Text + " ) GROUP BY us_id ) n4 ON (n3.us_id = n4.us_id)";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                adapter = new MySQLDataAdapter(cmd);
                adapter.Fill(ds, "table");
                DgvSummarize.DataSource = ds.Tables["table"];

            }
            if (e.Node.Level != 2)
                foreach (TreeNode tn in e.Node.Nodes)
                {
                    tn.Nodes.Add("null");
                }
            curTn = e;
        }

        void drawColumnAndRow(DataGridViewCellPaintingEventArgs e)
        {
            // 绘制背景色
            using (LinearGradientBrush backbrush = new LinearGradientBrush(e.CellBounds, ProfessionalColors.MenuItemPressedGradientBegin, ProfessionalColors.MenuItemPressedGradientMiddle, LinearGradientMode.Vertical))
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

        private void DgvSummarize_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void DgvSummarize_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //base.OnRowPostPaint(e);
            int width = this.DgvSummarize.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DgvSummarize.RowHeadersWidth;
            System.Drawing.Rectangle rowBounds = new System.Drawing.Rectangle(0, e.RowBounds.Top, width, e.RowBounds.Height);
            if (this.DgvSummarize.CurrentCellAddress.Y == e.RowIndex)
            {
                //设置选中边框
                e.DrawFocus(rowBounds, true);
            }
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                DgvSummarize.RowHeadersWidth - 4, e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                DgvSummarize.RowHeadersDefaultCellStyle.Font,
                    rectangle,
                    DgvSummarize.RowHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Right); 
        
        }

        private void DgvSummarize_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //base.OnRowPostPaint(e);
            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            {

                int width = this.DgvSummarize.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DgvSummarize.RowHeadersWidth;
                System.Drawing.Rectangle rowBounds = new System.Drawing.Rectangle(0, e.RowBounds.Top, width, e.RowBounds.Height);
                using (LinearGradientBrush backbrush =
                    new LinearGradientBrush(rowBounds, e.InheritedRowStyle.BackColor, Color.PaleVioletRed, 90.0f))
                {
                    e.Graphics.FillRectangle(backbrush, rowBounds);
                    e.PaintCellsContent(rowBounds); e.Handled = true;
                }
            }
        }

        private void CboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboSemester.Items.Clear();
            GloVariant.ReadSemester(CboYear.Text, ref CboSemester);
            CboSemester.SelectedIndex = 0;
            if (curTn == null)
                return;
                TreeClass_NodeMouseClick(sender, curTn);
        }

        private void CboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curTn == null)
                return;
                TreeClass_NodeMouseClick(sender, curTn);
        }

        private void BtnOutPut_Click(object sender, EventArgs e)
        {
            print(ds.Tables["table"]);
        }

        private void print(System.Data.DataTable dt)
        {
            try
            {
                if (dt.Rows.Count == 0)
                    return;
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                excel.Visible = false;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    excel.Cells[1, i + 1] = DgvSummarize.Columns[i].HeaderText;
                }
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            string str = dt.Rows[i][j].ToString();
                            excel.Cells[i + 2, j + 1] = "'" + str;
                        }
                    }
                }
                excel.DisplayAlerts = false;
                excel.AlertBeforeOverwriting = false;
                //excel.Application.Workbooks.Add(true).Save();
                excel.SaveWorkspace("D:" + "\\Data.xls");
                excel.Quit();
                excel = null;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "错误");
            }

        }
    }
}
