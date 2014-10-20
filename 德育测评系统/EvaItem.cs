using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MoralEvaluated.Properties;
using MySQLDriverCS;

namespace MoralEvaluated
{
    public partial class FrmEvaItem : FrmModel
    {
        public FrmEvaItem()
        {
            InitializeComponent();
        }

        public static string curName;

        public static int handleType = 0;

        private void EvaItem_Load(object sender, EventArgs e)
        {
            GloVariant.ReadCategory(ref CboCategory);
            GloVariant.ReadCategory(ref CboDetailCategory);
        }

        private void TxtPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar("-"))
            {
                if (((TextBox)sender).Text.Trim().IndexOf('-') > -1 || (sender as TextBox).SelectionStart != 0)
                    e.Handled = true;
                else return;
            }
            if (e.KeyChar == 8) return;
            if (e.KeyChar == '.')
            {
                if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                    e.Handled = true;
                else return;
            }
            if (e.KeyChar > '9' || e.KeyChar < '0') e.Handled = true;
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GloVariant.ReadItem(ref CboCategory, ref LstItems);
        }

        private void LstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstItems.SelectedIndex < 0)
                return;
            string sql;
            sql = "select it_reason,it_score from hdu_sce.item where it_name = '" + LstItems.SelectedItem.ToString() + "'";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            while(reader.Read())
            {
                CboDetailCategory.Text = CboCategory.Text;
                TxtItem.Text = LstItems.SelectedItem.ToString();
                TxtPoint.Text = reader["it_score"].ToString();
                TxtReason.Text = reader["it_reason"].ToString();
            }
        }
        //清除详细内容
        private void Clear()
        {
            TxtReason.Clear();
            TxtPoint.Clear();
            CboDetailCategory.SelectedIndex = -1;
            TxtItem.Clear();
        }
        //解锁详细内容
        private void unLock()
        {
            TxtReason.ReadOnly = false;
            TxtPoint.ReadOnly = false;
            CboDetailCategory.Enabled = true;
            TxtItem.ReadOnly = false;
            BtnSubmit.Show();
        }
        //锁定详细内容
        private void Lock()
        {
            TxtReason.ReadOnly = true;
            TxtPoint.ReadOnly = true;
            CboDetailCategory.Enabled = false;
            TxtItem.ReadOnly = true;
            BtnSubmit.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            unLock();
            CboDetailCategory.Text = CboCategory.Text;
            CboDetailCategory.Focus();
            handleType = 1;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string sql;
            MySQLCommand cmd;
            double curPoint = Convert.ToDouble(TxtPoint.Text);
            if (curPoint == 0 || Math.Abs(curPoint) > 10)
            {
                MessageBox.Show("输入的分数有误!");
            }
            if (handleType == 1)
            {
                sql = "insert into hdu_sce.item (ca_id,it_name,it_score,it_reason) values((select ca_id from hdu_sce.category where ca_name = '" + CboDetailCategory.Text + "'),'" + TxtItem.Text + "'," + TxtPoint.Text + ",'" + TxtReason.Text + "')";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("操作成功!");
                    LstItems.Items.Add(TxtItem.Text);
                    handleType = 0;
                    Lock();
                }
                catch
                {
                    MessageBox.Show("请输入完整的信息.");
                }
            }
            if (handleType == 2)
            {
                double x = Convert.ToDouble(TxtPoint.Text);
                if (x == 0 || Math.Abs(x) > 10)
                {
                    MessageBox.Show("输入的分数有错误!");
                    return;
                }
                sql = "update hdu_sce.item set ca_id = (select ca_id from hdu_sce.category where ca_name = '" + CboDetailCategory.Text + "'),it_name = '" + TxtItem.Text + "',it_score = " + TxtPoint.Text + ",it_reason = '" + TxtReason.Text + "' where it_id = (select n.it_id from (select it_id,it_name from hdu_sce.item) as n where n.it_name = '" + curName + "')";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功!");
                    handleType = 0;
                    Lock();
                }
                catch
                {
                    MessageBox.Show("修改失败.请不要输入'");
                }
            }
            else
                return;
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (LstItems.SelectedIndex < 0)
            {
                MessageBox.Show("请选择要修改的项");
                return;
            }
            unLock();
            curName = TxtItem.Text;
            handleType = 2;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (LstItems.SelectedIndex < 0)
            {
                MessageBox.Show("请选择要删除的项!");
                return;
            }
            string sql = "delete from hdu_sce.item where it_name = '" + TxtItem.Text + "' and ca_id = (select ca_id from hdu_sce.category where ca_name = '" + CboDetailCategory.Text + "')";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            if (MessageBox.Show("确定要删除项目：‘" + TxtItem.Text + "’吗?","确认",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("操作成功!");
                }
                catch
                {
                    MessageBox.Show("删除失败!");
                }
            }
        }
    }
}
