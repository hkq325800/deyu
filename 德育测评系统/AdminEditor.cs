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

namespace MoralEvaluated
{
    public partial class FrmAdminEditor : Form
    {
        public FrmAdminEditor()
        {
            InitializeComponent();
        }

        

        private void FrmAdminEditor_Load(object sender, EventArgs e)
        {
            //GloVariant.count = 0;
            if (GloVariant.index == 1)
            {
                CboSex.Text = "男";
                BtnComplete.Text = "设置密码";
                BtnModify.Visible = false;
                focus1(sender, e);
            }
            if (GloVariant.index == 2)
            {
                BtnComplete.Text = "完成";
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                TxtUser.ReadOnly = true;
                TxtUserName.ReadOnly = true;
                CboSex.Enabled = false;
                TxtPhone.ReadOnly = true;
                TxtEmail.ReadOnly = true;
                tabControl1.TabPages.Remove(tabPage2);
                //MessageBox.Show(GloVariant.UserSearch);
                MySQLCommand setformat = new MySQLCommand("set names gbk", GloVariant.conn);
                setformat.ExecuteNonQuery();
                setformat.Dispose();
                string sql = "select us_number,us_name,dic_value,us_rank,us_tel,us_email,ma_state from hdu_sce.user u join hdu_sce.dictionary d on us_sex = dic_id join hdu_sce.manager m on m.us_id=u.us_id where us_number = '"+GloVariant.UserSearch+"'";
                MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                TxtUser.Text = GloVariant.UserSearch;
                TxtUserName.Text = reader["us_name"].ToString();
                CboSex.Text = reader["dic_value"].ToString();
                TxtPhone.Text = reader["us_tel"].ToString();
                TxtEmail.Text = reader["us_email"].ToString();
                GloVariant.RankSearch = reader["us_rank"].ToString();
                if (GloVariant.RankSearch == "1001")
                    LblLevel.Text = "超级管理员";
                else if (GloVariant.RankSearch == "1002")
                    LblLevel.Text = "管理员";
                else if (GloVariant.RankSearch == "1003")
                    LblLevel.Text = "用户";
                cmd.Dispose();
                reader.Close();
                focus1(sender, e);
            }
            if (GloVariant.index == 3)
            {
                BtnComplete.Text = "完成";
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                BtnModify.Visible = false;
                TxtUserName.ReadOnly = false;
                TxtPhone.ReadOnly = false;
                TxtEmail.ReadOnly = false;
                TxtUser.ReadOnly = true;
                CboSex.Enabled = true;
                tabControl1.TabPages.Remove(tabPage2);
                //MessageBox.Show(GloVariant.UserSearch);
                MySQLCommand setformat = new MySQLCommand("set names gbk", GloVariant.conn);
                setformat.ExecuteNonQuery();
                setformat.Dispose();
                string sql = "select us_number,us_name,dic_value,us_rank,us_tel,us_email,ma_state from hdu_sce.user u join hdu_sce.dictionary d on us_sex = dic_id join hdu_sce.manager m on m.us_id=u.us_id where us_number = '" + GloVariant.UserSearch + "'";
                MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                TxtUserName.Text = reader["us_name"].ToString();
                CboSex.Text = reader["dic_value"].ToString();
                TxtPhone.Text = reader["us_tel"].ToString();
                TxtEmail.Text = reader["us_email"].ToString();
                GloVariant.RankSearch = reader["us_rank"].ToString();
                //GloVariant.Us_state = reader["ma_state"].ToString();
                //if (GloVariant.Us_state == "3001")
                //    BtnModState.Text = "禁用";
                //else BtnModState.Text = "启用";
                TxtUser.Text = GloVariant.UserSearch;
                cmd.Dispose();
                reader.Close();
                if (GloVariant.RankSearch == "1001")
                    LblLevel.Text = "超级管理员";
                else if (GloVariant.RankSearch == "1002")
                    LblLevel.Text = "管理员";
                else if (GloVariant.RankSearch == "1003")
                    LblLevel.Text = "用户";
                focus1(sender, e);
                //if (GloVariant.RankSearch != "1001")
                //{
                //    BtnModState.Visible = true;
                //}
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == this.tabPage1)
            {
                focus1(sender, e);
            }
            if (this.tabControl1.SelectedTab == this.tabPage2)
            {
                focus2(sender, e);
                BtnComplete_Click(sender, e);
                TxtUser.Focus();
                TxtUser.SelectAll();
            }
        }
        private void focus1(object sender, EventArgs e)
        {
            TxtUser.Focus();
            TxtUser.SelectAll();
            tabControl1.SelectedTab = tabPage1;
            this.AcceptButton = BtnComplete;
        }
        private void focus2(object sender, EventArgs e)
        {
            TxtPasswordFir.Focus();
            TxtPasswordFir.SelectAll();
            tabControl1.SelectedTab = tabPage2;
            this.AcceptButton = BtnSubmit;
        }
        private void BtnComplete_Click(object sender, EventArgs e)
        {
            if (GloVariant.index == 1)
            {
                if (TxtUser.Text == "" || TxtUserName.Text == "")
                {
                    MessageBox.Show("账号姓名为必填项！");
                    focus1(sender, e);
                }
                else
                {
                    if (GloVariant.count < 3 || GloVariant.count > 12)
                    {
                        MessageBox.Show("账号有长度限制(3-12个字符)！");
                        focus1(sender, e);
                        return;
                    }
                    else
                    {
                        string sqlcompare = "select us_number from hdu_sce.user where us_rank <> 1003";
                        MySQLCommand cmdcompare = new MySQLCommand(sqlcompare, GloVariant.conn);
                        DbDataReader readercompare = cmdcompare.ExecuteReader();
                        readercompare.Read();
                        while (readercompare.Read())
                        {
                            string numbercompare = null;
                            numbercompare = readercompare["us_number"].ToString();
                            if (TxtUser.Text == numbercompare)
                            {
                                MessageBox.Show("账号已存在！");
                                return;
                            }
                        }
                    }
                    tabControl1.SelectedTab = tabPage2;
                    focus2(sender, e);
                }
            }
            else if (GloVariant.index == 2)//查看详细信息
            {
                this.Close();
            }
            else//修改/禁用
            {
                int sex=0;
                if (CboSex.Text == "男")
                {
                    sex = 2002;
                }
                else if (CboSex.Text == "女")
                {
                    sex = 2003;
                }
                else { sex = 2001; }
                MySQLCommand setformat = new MySQLCommand("set names gbk", GloVariant.conn);
                setformat.ExecuteNonQuery();
                setformat.Dispose();
                string sql = "UPDATE hdu_sce.user set us_name='"+TxtUserName.Text+"',us_sex="+sex+",us_tel='"+TxtPhone.Text+"',us_email='"+TxtEmail.Text+"' where us_id=" + GloVariant.Us_idSearch;
                MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Close();
            }//提交入数据库 
                
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (GloVariant.count < 3 || GloVariant.count > 15)
            {
                MessageBox.Show("密码有长度限制(3-15个字符)！");
                focus2(sender, e);
                return;
            }
            else if (TxtPasswordFir.Text != TxtPasswordSec.Text||TxtPasswordFir.Text=="")
            {
                MessageBox.Show("两次密码输入不一致！");
                focus2(sender, e);
                return;
            }
            int sex = 2001;
            if (CboSex.Text == "男")
                sex = 2002;
            else if (CboSex.Text == "女")
                sex = 2003;
            string password=null;
            MySQLCommand setformat = new MySQLCommand("set names gbk", GloVariant.conn);
            setformat.ExecuteNonQuery();
            setformat.Dispose();
            password = GloVariant.Encrypt(TxtPasswordFir.Text);//重置密码“”内为明文
            //string sqlcompare = "select us_number from hdu_sce.user where us_rank <> 1003";
            //MySQLCommand cmdcompare = new MySQLCommand(sqlcompare, GloVariant.conn);
            //DbDataReader readercompare = cmdcompare.ExecuteReader();
            //readercompare.Read();
            //while (readercompare.Read())
            //{ 
            //    string numbercompare=null;
            //    numbercompare=readercompare["us_number"].ToString();
            //    if (TxtUser.Text == numbercompare)
            //    {
            //        MessageBox.Show("账号已存在！");
            //        return;
            //    }
            //}
            string sqluser = "INSERT INTO hdu_sce.USER (us_number,us_password,us_rank,us_name, us_sex,us_tel,us_email) VALUES('" + TxtUser.Text + "','" + password + "',1002,'" + TxtUserName.Text + "',"+sex+",'"+TxtPhone.Text+"','"+TxtEmail.Text+"')";
            MySQLCommand cmduser = new MySQLCommand(sqluser, GloVariant.conn);
            cmduser.ExecuteNonQuery();
            cmduser.Dispose();
            string sqlsearchus_id = "select us_id,us_number from hdu_sce.user where us_number= '" + TxtUser.Text + "'";
            MySQLCommand cmdsearchus_id = new MySQLCommand(sqlsearchus_id, GloVariant.conn);
            DbDataReader reader = cmdsearchus_id.ExecuteReader();
            reader.Read();
            GloVariant.Us_idSearch = reader["us_id"].ToString();
            cmdsearchus_id.Dispose();
            reader.Close();
            string sqlmanager = "insert into hdu_sce.manager (us_id,ma_state,co_id) values("+GloVariant.Us_idSearch+",3001,1)";
            //MessageBox.Show(GloVariant.Us_idSearch);
            MySQLCommand cmdmanager = new MySQLCommand(sqlmanager, GloVariant.conn);
            cmdmanager.ExecuteNonQuery();
            MessageBox.Show("提交成功！");
            cmdmanager.Dispose();
            this.Close();
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {
            GloVariant.count = int.Parse(TxtUser.Text.Length.ToString());
            //MessageBox.Show(GloVariant.count.ToString());
        }

        private void TxtPasswordFir_TextChanged(object sender, EventArgs e)
        {
            GloVariant.count = int.Parse(TxtPasswordFir.Text.Length.ToString());
            //MessageBox.Show(GloVariant.count.ToString());
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            GloVariant.index = 3;
            FrmAdminEditor_Load(sender,e);
            TxtUserName.Focus();
            TxtUserName.SelectAll();
            BtnModify.Visible = false;
        }

    }
}
