using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySQLDriverCS;
using System.Data.Common;
using MoralEvaluated.Properties;

namespace MoralEvaluated
{
    public partial class FrmPointExchanged : FrmModel
    {
        public FrmPointExchanged()
        {
            InitializeComponent();
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (LstNumber.Items.Count < 1)
            {
                MessageBox.Show("未选择学生.");
                return;
            }
            if (TxtDate.Text == "" || CboItem.Text == "" || CboOption.Text == "" || TxtValue.Text == "" || TxtReason.Text == "")
            {
                MessageBox.Show("请按格式输入，不允许有空值");
                return;
            }
            if (DateTime.Now < Convert.ToDateTime(TxtDate.Text))
            {
                MessageBox.Show("日期有误");
                return;
            }
            if (Convert.ToDouble(TxtValue.Text) == 0)
            {
                MessageBox.Show("请输入正确的分数!");
                return;
            }
            if (Convert.ToDouble(TxtValue.Text) > 10)
            {
                MessageBox.Show("目前支持最大单次加分为10分!");
                return;
            }
            string sql;
            MySQLCommand cmd;
            string us_id;
            string op_id;
            for (int i = 0; i < LstNumber.Items.Count; i++)
            {
                sql = "select us_id from hdu_sce.user t where t.us_number = '" + LstNumber.Items[i] +"'";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                us_id = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                if (CboOption.SelectedIndex == 1)
                    TxtValue.Text = "-" + TxtValue.Text;
                sql = "insert into hdu_sce.operate (ca_id,it_date,it_score,it_reason,op_usid,op_time) values(" + (CboItem.SelectedIndex + 1).ToString() + ",'" + TxtDate.Text + "','" + TxtValue.Text + "','" + TxtReason.Text + "','" + GloVariant.Us_id + "' ,'" + DateTime.Now + "' ) ";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                sql = "select op_id from hdu_sce.operate where op_usid = " + GloVariant.Us_id + " order by op_id desc limit 1";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                op_id = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                sql = "insert into hdu_sce.studentoperate values ( " + us_id + "," + op_id +")";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("操作成功");
        }
        
        private void TxtName_Click(object sender, EventArgs e)
        {
            TxtName.SelectAll();
        }

        private void LstSearching_Click(object sender, EventArgs e)
        {
            if (LstSearching.SelectedIndex < 0 )                   //判断是否选中item          
                return;          
            TxtName.Text = LstSearching.SelectedItem.ToString();
            if (IsExsist(LstValue.Items[LstSearching.SelectedIndex].ToString()))
                return;
            LstNames.Items.Add(LstSearching.SelectedItem.ToString());
            LstNumber.Items.Add(LstValue.Items[LstSearching.SelectedIndex].ToString());
            LstSearching.Hide();
        }

        private void DpkDate_DateSelected(object sender, DateRangeEventArgs e)      //选择日期
        {
            TxtDate.Text = DpkDate.SelectionStart.ToString("yyyy-MM-dd");
            DpkDate.Hide();
        }

        private void FrmPointExchanged_Load(object sender, EventArgs e)
        {
            //读取测评类型
            GloVariant.ReadCategory(ref CboItem);
            //读取加减
            string sql;
            MySQLCommand command;
            DbDataReader datareader;
            sql = "select dic_value from hdu_sce.dictionary where dic_id < 5";
            command = new MySQLCommand(sql, GloVariant.conn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                string Dic=datareader["dic_value"].ToString();
                CboOption.Items.Add(Dic);
            }
            //读取TreeNode
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
            sql = "select pr_name,co_name from hdu_sce.profession t1 join hdu_sce.college t2 on (t1.co_id = t2.co_id)";
            cmd.Dispose();
            cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            while(reader.Read())
            {
                for (int i = 0; i < TreeClass.Nodes.Count;i++)
                    if (TreeClass.Nodes[i].Text == reader["co_name"].ToString())
                        TreeClass.Nodes[i].Nodes.Add(reader["pr_name"].ToString());
            }
            cmd.Dispose();
            reader.Dispose();
            sql = "select cl_name,pr_name from hdu_sce.class t1 join hdu_sce.profession t2 on (t1.pr_id = t2.pr_id)";
            cmd = new MySQLCommand(sql, GloVariant.conn);
            reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                for (int i = 0; i < TreeClass.Nodes.Count; i++)
                {
                    for (int j = 0; j < TreeClass.Nodes[i].Nodes.Count;j++ )
                        if (TreeClass.Nodes[i].Nodes[j].Text == reader["pr_name"].ToString())
                            TreeClass.Nodes[i].Nodes[j].Nodes.Add(reader["cl_name"].ToString());
                }
            }
            cmd.Dispose();
            reader.Dispose();
            sql = "select us_number,us_name,cl_name from hdu_sce.user t1 join hdu_sce.student t2 on (t1.us_id = t2.us_id) join hdu_sce.class t3 on (t2.cl_id = t3.cl_id)";
            cmd = new MySQLCommand(sql, GloVariant.conn);
            reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                for (int i = 0; i < TreeClass.Nodes.Count; i++)
                {
                    for (int j = 0; j < TreeClass.Nodes[i].Nodes.Count; j++)
                    {
                        for (int k = 0; k < TreeClass.Nodes[i].Nodes[j].Nodes.Count;k++ )
                            if (TreeClass.Nodes[i].Nodes[j].Nodes[k].Text == reader["cl_name"].ToString())
                                TreeClass.Nodes[i].Nodes[j].Nodes[k].Nodes.Add(reader["us_name"].ToString() + " " + reader["us_number"].ToString());
                    }
                }
            }
        }


        //mouseup的时候选择日期，同时隐藏日历表
        //private void DpkDate_MouseUp(object sender, MouseEventArgs e)
        //{
        //    DpkDate.Hide();
        //}

        //keyup的时候通过姓名查询
        private void TxtName_KeyUp(object sender, KeyEventArgs e)
        {
            LstValue.Items.Clear();
            LstSearching.Items.Clear();
            GloVariant.SearchByName(TxtName.Text, ref LstSearching, ref LstValue);
            GloVariant.SearchByLetter(TxtName.Text, ref LstSearching, ref LstValue);
            if(TxtName.Text != "")
                GloVariant.SearchByNumber(TxtName.Text, ref LstSearching, ref LstValue);
        }
        //显示lstsearching box
        private void TxtName_Enter_1(object sender, EventArgs e)
        {
            LstSearching.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            GloVariant.ReadItem(ref CboItem, ref CboCommonSelect);
            /*string sql;
            string ca_id;
            MySQLCommand cmd;
            sql = "select ca_id from hdu_sce.category where ca_name = '" + CboItem.SelectedItem.ToString() + "'";
            cmd = new MySQLCommand(sql, GloVariant.conn);
            ca_id = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            sql = "select it_name from hdu_sce.item where ca_id = " + ca_id;
            cmd = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader Datareader = cmd.ExecuteReader();
            CboCommonSelect.Items.Clear();
            while (Datareader.Read())
            {
                string It_name = Datareader["it_name"].ToString();
                CboCommonSelect.Items.Add(It_name);
            }
             */
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (LstNames.SelectedIndex < 0)
                return;
            LstNumber.Items.Remove(LstNumber.Items[LstNames.SelectedIndex]);
            LstNames.Items.Remove(LstNames.SelectedItem);
            
        }
        //遍历TreeView得到选中的项添加到Lst表中
        private void Traverse(TreeNode tn)
        {
            for (int i = 0; i < tn.Nodes.Count;i++ )
            {
                if (tn.Nodes[i].Nodes.Count > 0)
                    Traverse(tn.Nodes[i]);
                else
                {
                    if (tn.Nodes[i].Level == 3 && tn.Nodes[i].Checked)
                    {
                        string[] s = (tn.Nodes[i].Text).Split(new char[]{' '});
                        if(IsExsist(s[1]))
                            continue;
                        LstNames.Items.Add(tn.Nodes[i].Text);
                        LstNumber.Items.Add(s[1]);
                    }
                }
            }

        }
        //判断是否已存在于Lst表中
        private bool IsExsist(string number)
        {
            for (int i = 0; i < LstNumber.Items.Count; i++)
                if (number == LstNumber.Items[i].ToString())
                return true;
            return false;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TreeClass.Nodes.Count;i++)
                Traverse(TreeClass.Nodes[i]);
        }

        private void TreeClass_AfterCheck(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < e.Node.Nodes.Count; i++)
            {
                e.Node.Nodes[i].Checked = e.Node.Checked;
            }
        }
        //读取常用项
        private void CboCommonSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "select it_score,it_reason from hdu_sce.item where it_name = '" + CboCommonSelect.Text + "'";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            reader.Read();
            TxtValue.Text = reader["it_score"].ToString();
            TxtReason.Text = reader["it_reason"].ToString();
        }

        private void TxtDate_Enter(object sender, EventArgs e)
        {
            DpkDate.Show();
        }

        private void TxtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) return;
            if (e.KeyChar == '.')
            {
                if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                    e.Handled = true;
                else return;
            }
            if (e.KeyChar > '9' || e.KeyChar < '0') e.Handled = true;
        }

        private void TxtName_Click_1(object sender, EventArgs e)
        {
            TxtName.SelectAll();
        }
    }
}
