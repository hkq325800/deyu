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
using System.Data.Common;

namespace MoralEvaluated
{
    public partial class FrmPersonInfo : FrmModel
    {
        
        public FrmPersonInfo()
        {
            InitializeComponent();
        }

        private void PersonInfo_Load(object sender, EventArgs e)
        {
            MySQLCommand setformat = new MySQLCommand("set names gbk", GloVariant.conn);
            setformat.ExecuteNonQuery();
            setformat.Dispose();       
            string sql = "select * from hdu_sce.user join hdu_sce.dictionary on (us_sex = dic_id) where us_number = '" + GloVariant.User + "'";
            LblUser.Text = GloVariant.User;
            if (GloVariant.Rank == "1001")
                LblLevel.Text = "超级管理员";
            else if (GloVariant.Rank == "1002")
                LblLevel.Text = "管理员";
            else if (GloVariant.Rank == "1003")
                LblLevel.Text = "用户";//? 
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            TxtUserName.Text = reader["us_name"].ToString();
            CboSex.Text = reader["dic_value"].ToString();
            TxtPhone.Text = reader["us_tel"].ToString();
            TxtEmail.Text = reader["us_email"].ToString();
            cmd.Dispose();
            reader.Close();
            this.AcceptButton = BtnModify;
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            string sexCode;
            if (CboSex.Text == "男")
                sexCode = "2002";
            else if (CboSex.Text == "女")
                sexCode = "2003";
            else
                sexCode = "2001";
            string sql = "UPDATE hdu_sce.user SET us_name = '" + TxtUserName.Text + "',us_sex = " + sexCode + ",us_tel = '" + TxtPhone.Text + "',us_email = '" + TxtEmail.Text + "' WHERE us_number = '" + GloVariant.User + "'";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            cmd.ExecuteNonQuery();
            MySQLCommand setformat = new MySQLCommand("set names gbk", GloVariant.conn);
            setformat.ExecuteNonQuery();
            setformat.Dispose();       
            MessageBox.Show("修改成功");
            cmd.Dispose();
        }
        private void BtnLiftPassword_Click(object sender, EventArgs e)
        {
            GloVariant.count = int.Parse(TxtNewPassword.Text.Length.ToString());
            if (GloVariant.count < 3 || GloVariant.count > 15)
            {
                MessageBox.Show("密码有长度限制(3-15个字符)！");
                TxtNewPassword.Focus();
                TxtNewPassword.SelectAll();
                return;
            }
            if (TxtNewPassword.Text == "" || TxtConcernedNewPassword.Text == "")
            { 
                MessageBox.Show("请输入并确认新密码！");
                return;
            }
            string temp;
            string sql1 = "select count(*) as result from hdu_sce.user where us_number = '" + GloVariant.User + "' and us_password = '" + GloVariant.Encrypt(TxtOldPassword.Text) + "'";
            MySQLCommand cmd1 = new MySQLCommand(sql1, GloVariant.conn);
            DbDataReader reader = cmd1.ExecuteReader();
            reader.Read();//超重要!
            temp = reader["result"].ToString();
            if (temp == "1")
            {
                if (TxtNewPassword.Text == TxtConcernedNewPassword.Text)
                {
                    string sql2 = "update hdu_sce.user set us_password = '" + GloVariant.Encrypt(TxtNewPassword.Text) + "' WHERE us_number = '" + GloVariant.User + "'";
                    MySQLCommand cmd2 = new MySQLCommand(sql2, GloVariant.conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("修改成功");
                    cmd2.Dispose();
                }
                else MessageBox.Show("两次新密码不一致！");
            }
            else MessageBox.Show("原密码输入错误");
            
            cmd1.Dispose();
            reader.Close();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == this.tabPage2)
            {
                TxtOldPassword.Focus();
                this.AcceptButton = BtnLiftPassword;
            }
            if (this.tabControl1.SelectedTab == this.tabPage1)
            {
                this.AcceptButton = BtnModify;
            }
        }

        
    }
}
