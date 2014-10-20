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
using System.Configuration;

namespace MoralEvaluated
{
    public partial class FrmAdAdmin : FrmModel
    {
        public FrmAdAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdAdmin_Load(object sender, EventArgs e)
        {
            DgvAdmin.ClearSelection();
            string connstr = ConfigurationManager.AppSettings["connectionstring"];
            GloVariant.conn = new MySQLConnection(connstr);
            GloVariant.conn.Open();
            MySQLCommand setformat = new MySQLCommand("set names gbk", GloVariant.conn);
            setformat.ExecuteNonQuery();
            setformat.Dispose();     
            GloVariant.index = 0;
            string sql = "select m.us_id,u.us_number,u.us_name,d1.dic_value as d1value,d2.dic_value as d2value from hdu_sce.manager m join hdu_sce.user u on m.us_id=u.us_id JOIN hdu_sce.dictionary d1 on d1.dic_id=u.us_rank JOIN hdu_sce.dictionary d2 on d2.dic_id=m.ma_state where u.us_number <> '" + GloVariant.User + "' order by d1value,d2value desc,m.us_id";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            DgvAdmin.Rows.Clear();//输入到dgv中
            while (reader.Read())
            {
                int index = this.DgvAdmin.Rows.Add();
                this.DgvAdmin.Rows[index].Cells[1].Value = reader["us_number"].ToString();
                this.DgvAdmin.Rows[index].Cells[2].Value = reader["us_name"].ToString();
                this.DgvAdmin.Rows[index].Cells[3].Value = reader["d1value"].ToString();
                this.DgvAdmin.Rows[index].Cells[4].Value = reader["d2value"].ToString();
                this.DgvAdmin.Rows[index].Cells[5].Value = reader["us_id"].ToString();
            }
            reader.Close();
            cmd.Dispose();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GloVariant.index = 1;
            FrmAdminEditor frmAdminEditor = new FrmAdminEditor();
            frmAdminEditor.ShowDialog();
            FrmAdAdmin_Load(sender, e);
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            int count = DgvAdmin.Rows.Count;
            int traverse = 0;
            int i = 0;
            for (i = 0; i < count; i++)
            {
                DgvAdmin.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                bool flag = Convert.ToBoolean(checkCell.Value);
                if (flag)
                    traverse += 1;
            }
            if (traverse != 1) { MessageBox.Show("请选择并只选择一个人进行查看"); }
            else for (i = count - 1; i >= 0; i--)
            {
                DgvAdmin.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                bool flag = Convert.ToBoolean(checkCell.Value);
                if (flag)
                {
                    GloVariant.Us_idSearch = DgvAdmin.Rows[i].Cells[5].Value.ToString();
                    GloVariant.index = 2;
                    GloVariant.UserSearch = DgvAdmin.Rows[i].Cells[1].Value.ToString();
                    FrmAdminEditor frmAdminEditor = new FrmAdminEditor();
                    frmAdminEditor.ShowDialog();
                    FrmAdAdmin_Load(sender, e);
                }
            }
        }
        private void BtnModify_Click(object sender, EventArgs e)
        {
            GloVariant.index = 3;
            int traverse=0;
            int count = DgvAdmin.Rows.Count;
            int i = 0;
            for(i=0;i<count;i++)
            {
                DgvAdmin.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                bool flag = Convert.ToBoolean(checkCell.Value);
                if(flag)
                traverse+=1;
            }
            //MessageBox.Show(traverse.ToString());
            if (traverse!=1)
            {
                MessageBox.Show("请选择并只选择一个人进行修改");
                return;
            }
            else
            {
                for (i = 0; i < count; i++)
                {
                    DgvAdmin.EndEdit();
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                    bool flag = Convert.ToBoolean(checkCell.Value);
                    if (flag)
                    {
                        FrmAdminEditor frmAdminEditor = new FrmAdminEditor();
                        GloVariant.UserSearch = DgvAdmin.Rows[i].Cells[1].Value.ToString();
                        GloVariant.Us_idSearch = DgvAdmin.Rows[i].Cells[5].Value.ToString();
                        frmAdminEditor.ShowDialog();
                        FrmAdAdmin_Load(sender, e);
                    }
                }
            }
            
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            int count = DgvAdmin.Rows.Count;
            int traverse = 0;
            int i = 0;
            for (i = 0; i < count; i++)
            {
                DgvAdmin.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                bool flag = Convert.ToBoolean(checkCell.Value);
                if (flag)
                    traverse += 1;
            }
            if (traverse == 0) { MessageBox.Show("请选择至少一人进行密码重置"); return; }
            if (MessageBox.Show("你确定要重置吗?", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
                    
            else for (i = count - 1; i >= 0; i--)
           {
                DgvAdmin.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                bool flag = Convert.ToBoolean(checkCell.Value);
                if (flag)
                {
                    GloVariant.Us_idSearch = DgvAdmin.Rows[i].Cells[5].Value.ToString();
                    GloVariant.UserSearch = DgvAdmin.Rows[i].Cells[1].Value.ToString();
                    string MD5;
                    MD5 = GloVariant.Encrypt(GloVariant.UserSearch);//重置密码“”内为明文
                    string sql = "update hdu_sce.user set us_password='" + MD5 + "' where us_id=" + GloVariant.Us_idSearch;
                    MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();  
                }
            }
            MessageBox.Show("重置密码成功,当前密码与账号相同");
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            int count = DgvAdmin.Rows.Count;
            int traverse = 0;
            int i = 0;
            for (i = 0; i < count; i++)
            {
                DgvAdmin.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                bool flag = Convert.ToBoolean(checkCell.Value);
                if (flag)
                    traverse += 1;
            }//遍历traverse为选中条数
            //MessageBox.Show(traverse.ToString());
            if (checkBox1.Checked == true)
            {
                for (i = 0; i < count; i++)
                {
                    DgvAdmin.EndEdit();
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                    bool flag = Convert.ToBoolean(checkCell.Value);
                    if (!flag)
                    {
                        DataGridViewCheckBoxCell CheckCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];
                        checkCell.Value = true;
                    }
                    traverse += 1;
                }
            }
            else
            {
                traverse = 0;
                for (i = 0; i < count; i++)
                {
                    DgvAdmin.EndEdit();
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                    bool flag = Convert.ToBoolean(checkCell.Value);
                    if (flag)
                    {
                        DataGridViewCheckBoxCell CheckCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];
                        checkCell.Value = false;
                    }
                    traverse += 1;
                }
            }
            //MessageBox.Show(traverse.ToString());
        }

        private void BtnModState_Click(object sender, EventArgs e)
        {
            int count = DgvAdmin.Rows.Count;
            int traverse = 0;
            int i = 0;
            for (i = 0; i < count; i++)
            {
                DgvAdmin.EndEdit();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                bool flag = Convert.ToBoolean(checkCell.Value);
                if (flag)
                {
                    traverse += 1;
                }
            }
            if (traverse == 0) { MessageBox.Show("请选择至少一人进行启用/禁用"); return; }
            if (MessageBox.Show("你确定要执行吗?", "确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            else for (i = 0; i <count; i++)
                {
                    DgvAdmin.EndEdit();
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)DgvAdmin.Rows[i].Cells[0];//确保取出
                    bool flag = Convert.ToBoolean(checkCell.Value);
                    if (flag)
                    {
                        GloVariant.Us_idSearch = DgvAdmin.Rows[i].Cells[5].Value.ToString();
                        string sql1 = "select ma_state from hdu_sce.manager where us_id=" + GloVariant.Us_idSearch;
                        MySQLCommand cmd = new MySQLCommand(sql1, GloVariant.conn);
                        MySQLDataReader reader = cmd.ExecuteReaderEx();
                        reader.Read();
                        GloVariant.Us_state = reader["ma_state"].ToString();
                        if (GloVariant.Us_state == "3001")
                        {
                            GloVariant.Us_state = "3002";
                        }
                        else 
                        {
                            GloVariant.Us_state = "3001"; 
                        }
                        string sql2 = "update hdu_sce.manager set ma_state=" + GloVariant.Us_state + " where us_id=" + GloVariant.Us_idSearch;
                        MySQLCommand cmdupdate = new MySQLCommand(sql2, GloVariant.conn);
                        cmdupdate.ExecuteNonQuery();
                        cmd.Dispose();
                        reader.Close();
                        
                        
                    }
                }
            FrmAdAdmin_Load(sender, e);
            MessageBox.Show("启用/禁用成功");
        

        }


    }
}
