using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySQLDriverCS;
using System.Windows.Forms;
using System.Data.Common;
using System.Web.Security;

namespace MoralEvaluated
{
    class GloVariant
    {
        //数据库连接变量
        public static MySQLConnection conn = null;
        //登录权限
        public static string User;
        public static string Rank;
        public static string Us_id;
	    public static string UserSearch;          //用于查找用户名可更改us_number
        public static string RankSearch;          //用于查找用户级别可更改
        public static string Us_idSearch;         //用于查找用户id可更改
        public static string Us_state;            //用于查找用户状态（启用/禁用）
        public static int count;                  //用于注册时的字符个数控制
        //用于添加班级
        public static string cl_number;
        public static string grade;
        public static string pr_name;
        public static string cl_op;
        //用于保存所选中的学年学期的se_id
        public static string se_id;
        //用于管理中一个窗体根据按钮更改窗体中的属性
        public static int index;

        //用于修改历史记录信息
        public static string stu_name, ca_name, point, op_name, op_reason, time;

        //读取专业信息并载入到comboBox中
        public static void ReadPro(ref ComboBox Cbo)
        {
            string sql;
            sql = "select pr_name from hdu_sce.profession";
            MySQLCommand cmd = new MySQLCommand(sql, conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                Cbo.Items.Add(reader["pr_name"].ToString());
            }
            reader.Close();
            cmd.Dispose();
        }
        //读取年级信息并载入到comboBox中
        public static void ReadGrade(string pr_name, ref ComboBox Cbo)
        {
            string pr_id;
            string sql = "select distinct pr_id from hdu_sce.profession where pr_name = '" + pr_name + "'";
            MySQLCommand cmd = new MySQLCommand(sql, conn);
            pr_id = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            sql = "select cl_grade from hdu_sce.class where pr_id = '" + pr_id + "'";
            cmd = new MySQLCommand(sql, conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                Cbo.Items.Add(reader["cl_grade"].ToString());
            }
            reader.Close();
            cmd.Dispose();
        }
        //读取班级信息并载入到comboBox中
        public static void ReadClass(string pr_name, string grade, ref ComboBox Cbo)
        {
            string id;
            string sql = "select pr_id from hdu_sce.profession t1 where t1.pr_name='" + pr_name + "'";
            MySQLCommand cmd = new MySQLCommand(sql, conn);
            id = cmd.ExecuteScalar().ToString();//获取对应专业编号
            cmd.Dispose();
            sql = "select cl_name from hdu_sce.class t2 where t2.pr_id='" + id + "' and t2.cl_grade='" + grade + "'";
            cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                Cbo.Items.Add(reader["cl_name"].ToString());
            }
            reader.Close();
            cmd.Dispose();
        }
        //读取学生信息并载入到ListBox中
        public static void ReadStu(string cl_name,ref ListBox Lst,ref ListBox Value)
        {
            string sql = "select t1.us_id,us_name,us_number from hdu_sce.user t1 join hdu_sce.student t2 on (t1.us_id = t2.us_id) where cl_id = (select cl_id from hdu_sce.class where cl_name = '" + cl_name + "')";
            MySQLCommand cmd = new MySQLCommand(sql, conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                Lst.Items.Add(reader["us_name"].ToString() + " " + reader["us_number"].ToString());
                Value.Items.Add(reader["us_id"].ToString());
            }
        }
        //根据姓名查找学生信息,将学号姓名存入Lst中,并将学号存入value相应的index中
        public static void SearchByName(string name, ref ListBox Lst, ref ListBox Value)
        {
            string sql;
            string Name, Number;
            sql = "select us_name,us_number from hdu_sce.user inner join hdu_sce.student on (hdu_sce.student.us_id=hdu_sce.user.us_id) where us_name like '" + name + "%' ";
            MySQLCommand command = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader datareader = command.ExecuteReader();
            while (datareader.Read())  // datareader执行一次往下跳一次
            {
                Name = datareader["us_name"].ToString();
                Number = datareader["us_number"].ToString();
                Lst.Items.Add(Name + ' ' + Number);
                Value.Items.Add(Number);
            }
            datareader.Close();
            command.Dispose();
        }
        //根据学号查找学生信息,将学号姓名存入Lst中,并将学号存入value相应的index中
        public static void SearchByNumber(string number, ref ListBox Lst, ref ListBox Value)
        {
            string sql;
            string Name, Number;
            sql = "select us_name,us_number from hdu_sce.user t1 inner join hdu_sce.student t2 on (t1.us_id = t2.us_id) where us_number like '" + number + "%'";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                Name = datareader["us_name"].ToString();
                Number = datareader["us_number"].ToString();
                Lst.Items.Add(Name + ' ' + Number);
                Value.Items.Add(Number);
            }
            datareader.Close();
            cmd.Dispose();
        }
        //通过每个字的首字母查询学生信息
        public static void SearchByLetter(string letter, ref ListBox Lst, ref ListBox Value)
        {
            string sql,Name,Number;
            int length = letter.Length;
            char[] lets = letter.ToCharArray();
            if (length < 1)
                return;
            //生成sql语句
            sql = "select us_name,us_number from hdu_sce.user t1 join hdu_sce.student t2 on (t1.us_id = t2.us_id)";
            int i;
            for (i = 0; i < length; i++)
                sql += ",hdu_sce.t_cosler c" + i.ToString();
            sql += " where";
            for (i = 0; i < length - 1; i++)
                sql += " CONV(HEX(mid(us_name," + (i + 1).ToString() + ",1)),16,10) between c" + i.ToString() + ".cBegin and c" + i.ToString() + ".cEnd and c" + i.ToString() + ".f_PY = '" + lets[i] + "' and ";
            sql += " CONV(HEX(mid(us_name," + (i + 1).ToString() + ",1)),16,10) between c" + i.ToString() + ".cBegin and c" + i.ToString() + ".cEnd and c" + i.ToString() + ".f_PY = '" + lets[i] + "'";
            
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                Name = datareader["us_name"].ToString();
                Number = datareader["us_number"].ToString();
                Lst.Items.Add(Name + ' ' + Number);
                Value.Items.Add(Number);
            }
            datareader.Close();
            cmd.Dispose();
        }

        public static void SearchByStr(string attribute, string value, ref ListBox Lst)
        {
            Lst.Items.Clear();
            //int no = 0;
            string sql = "select " + attribute + @" from hdu_sce.user t1 where t1." + attribute + " like '" + value + @"%' limit 5 ";
            MySQLCommand command = new MySQLCommand(sql, conn);
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string str = reader[attribute].ToString();
                Lst.Items.Add(str);
            }
            Lst.Height = (Lst.Items.Count + 1) * 12;
            reader.Dispose();
        }
        //读取学年
        public static void ReadYear(ref ComboBox Cbo)
        {
            string sql = "select distinct se_year from hdu_sce.semester";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                Cbo.Items.Add(reader["se_year"]);
            }
        }
        //读取学期
        public static void ReadSemester(string year,ref ComboBox Cbo)
        {
            string sql = "select se_term from hdu_sce.semester where se_year = " + year;
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                Cbo.Items.Add(reader["se_term"]);
            }
        }
        //加密明文密码,MD5
        public static string Encrypt(string str)
        {
            /*System.Security.Cryptography.MD5CryptoServiceProvider md5CSP = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] strEncrypt = System.Text.Encoding.Unicode.GetBytes(str);
            byte[] resultEncrypt = md5CSP.ComputeHash(strEncrypt);
            string resultStr = System.Text.Encoding.Unicode.GetString(resultEncrypt);
             */
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
        }
        //读取测评种类并载入到ComboBox中
        public static void ReadCategory(ref ComboBox Cbo)
        {
            string sql;
            sql = "select ca_name from hdu_sce.category ";
            MySQLCommand command = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                string Ca_name = datareader["ca_name"].ToString();
                Cbo.Items.Add(Ca_name);
            }
        }
        //读取测评种类并载入到ComboBox中
        public static void ReadItem(ref ComboBox Cbo,ref ComboBox x)
        {
            string sql;
            string ca_id;
            MySQLCommand cmd;
            sql = "select ca_id from hdu_sce.category where ca_name = '" + Cbo.SelectedItem.ToString() + "'";
            cmd = new MySQLCommand(sql, GloVariant.conn);
            ca_id = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            sql = "select it_name from hdu_sce.item where ca_id = " + ca_id;
            cmd = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader Datareader = cmd.ExecuteReader();
            x.Items.Clear();
            while (Datareader.Read())
            {
                string It_name = Datareader["it_name"].ToString();
                x.Items.Add(It_name);
            }
        }
        //读取测评种类并载入到ComboBox中
        public static void ReadItem(ref ComboBox Cbo, ref ListBox x)
        {
            string sql;
            string ca_id;
            MySQLCommand cmd;
            sql = "select ca_id from hdu_sce.category where ca_name = '" + Cbo.SelectedItem.ToString() + "'";
            cmd = new MySQLCommand(sql, GloVariant.conn);
            ca_id = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            sql = "select it_name from hdu_sce.item where ca_id = " + ca_id;
            cmd = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader Datareader = cmd.ExecuteReader();
            x.Items.Clear();
            while (Datareader.Read())
            {
                string It_name = Datareader["it_name"].ToString();
                x.Items.Add(It_name);
            }
        }
        //根据操作ID删除操作
        public static bool DelOperate(string op_id)
        {
            string sql1 = "delete from hdu_sce.operate where op_id = " + op_id;
            string sql2 = "delete from hdu_sce.studentoperate where op_id = " + op_id;
            MySQLCommand cmd1 = new MySQLCommand(sql1, GloVariant.conn);
            MySQLCommand cmd2 = new MySQLCommand(sql2, GloVariant.conn);
            try
            {
                cmd2.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                return false;
            }
            
        }
        //从hdu_sce.semester表中根据满足相关字段的相关值条件来查找相关信息，并输出到ComboBox中,attribute为字段，value为值
        public static void ReadToCom(string attribute, ref ComboBox x)
        {
            x.Items.Clear();
            string sql = "select distinct " + attribute + " from hdu_sce.semester ordre by " + attribute;
            MySQLCommand command = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string value = reader["se_year"].ToString();
                x.Items.Add(value);
            }
            reader.Close();
            command.Dispose();
        }
        //下面函数是上面的重载,多一个条件“某一学年”下的学期
        public static void ReadToCom(string attribute, string year_value, ref ComboBox x)
        {
            x.Items.Clear();
            string sql = "select distinct " + attribute + " from hdu_sce.semester where se_year = " + year_value + " ordre by " + attribute;
            MySQLCommand command = new MySQLCommand(sql, GloVariant.conn);
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string value = reader["se_year"].ToString();
                x.Items.Add(value);
            }
            reader.Close();
            command.Dispose();
        }
    }
}
