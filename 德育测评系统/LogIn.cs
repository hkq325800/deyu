using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySQLDriverCS;
using System.Configuration;

namespace MoralEvaluated
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.AppSettings["connectionstring"];
            GloVariant.conn = new MySQLConnection(connstr);
            GloVariant.conn.Open();
            MySQLCommand setformat = new MySQLCommand("set names gbk", GloVariant.conn);
            setformat.ExecuteNonQuery();
            setformat.Dispose();
            GloVariant.User = null;
            GloVariant.Us_id = null;
            GloVariant.Us_state = null;
            GloVariant.Rank = null;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {            
            string sql = "call hdu_sce.login('" + TxtUser.Text + "','" + GloVariant.Encrypt(TxtPassword.Text) + "')";
            int count = 0;
            MySQLCommand command = new MySQLCommand(sql, GloVariant.conn);
            command.CommandType = CommandType.StoredProcedure;
            MySQLDataReader reader = command.ExecuteReaderEx();
            while (reader.Read())
            {
                count++;
                GloVariant.Rank = reader["us_rank"].ToString();
                GloVariant.Us_id = reader["us_id"].ToString();
            }
            string sqlcompare = "select us_number from hdu_sce.user";
            MySQLCommand cmdcompare = new MySQLCommand(sqlcompare, GloVariant.conn);
            MySQLDataReader readercompare = cmdcompare.ExecuteReaderEx();
            readercompare.Read();
            bool compare = false;
            while (readercompare.Read())
            {
                string numbercompare = null;
                numbercompare = readercompare["us_number"].ToString();
                if (TxtUser.Text == numbercompare)
                {
                    compare = true;
                    break;
                }
            }
            if (compare != true)
            {
                MessageBox.Show("账号不存在！");
                return;
            }
            if (TxtUser.Text == "")
            {
                MessageBox.Show("请输入登录信息!");
                return;
            }
            if (GloVariant.Rank != "1003")
            {
                string state = null;
                string sqlgetstate = "select ma_state from hdu_sce.manager m join hdu_sce.user u on u.us_id=m.us_id where us_number= '" + TxtUser.Text + "'";
                MySQLCommand cmd = new MySQLCommand(sqlgetstate, GloVariant.conn);
                MySQLDataReader readercmd = cmd.ExecuteReaderEx();
                readercmd.Read();
                state = readercmd["ma_state"].ToString();
                if (state == "3002")
                {
                    MessageBox.Show("该管理员已被禁用");
                    return;
                }
                command.Dispose();
                cmd.Dispose();
                cmdcompare.Dispose();
                readercmd.Close();
                reader.Close();
                readercompare.Close();
            }
            else
            {
                MessageBox.Show("学生系统尚未开发！敬请期待");
                return;
            }
            //MessageBox.Show(result);
            if (count == 1)
            {
                GloVariant.User = TxtUser.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误!");
                GloVariant.Rank = "0";
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtPassword.Clear();
            TxtUser.Clear();
            TxtUser.Focus();
        }
    }
}
