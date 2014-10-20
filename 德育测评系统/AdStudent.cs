using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySQLDriverCS;
using MoralEvaluated;

namespace MoralEvaluated
{
    public partial class FrmAdStudent : FrmModel
    {
        public FrmAdStudent()
        {
            InitializeComponent();
        }

        private void FrmAdStudent_Load(object sender, EventArgs e)
        {
            TreeSearch.Nodes.Clear();
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
                TreeSearch.Nodes.Add(row["co_name"].ToString());
            }
            sql = "select pr_name,co_name from hdu_sce.profession t1 join hdu_sce.college t2 on (t1.co_id = t2.co_id)";
            cmd.Dispose();
            cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataReader reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                for (int i = 0; i < TreeSearch.Nodes.Count; i++)
                    if (TreeSearch.Nodes[i].Text == reader["co_name"].ToString())
                        TreeSearch.Nodes[i].Nodes.Add(reader["pr_name"].ToString());
            }
            cmd.Dispose();
            reader.Dispose();
            sql = "select cl_name,pr_name from hdu_sce.class t1 join hdu_sce.profession t2 on (t1.pr_id = t2.pr_id)";
            cmd = new MySQLCommand(sql, GloVariant.conn);
            reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                for (int i = 0; i < TreeSearch.Nodes.Count; i++)
                {
                    for (int j = 0; j < TreeSearch.Nodes[i].Nodes.Count; j++)
                        if (TreeSearch.Nodes[i].Nodes[j].Text == reader["pr_name"].ToString())
                            TreeSearch.Nodes[i].Nodes[j].Nodes.Add(reader["cl_name"].ToString());
                }
            }
            cmd.Dispose();
            reader.Dispose();
            sql = "select us_number,us_name,cl_name from hdu_sce.user t1 join hdu_sce.student t2 on (t1.us_id = t2.us_id) join hdu_sce.class t3 on (t2.cl_id = t3.cl_id)";
            cmd = new MySQLCommand(sql, GloVariant.conn);
            reader = cmd.ExecuteReaderEx();
            while (reader.Read())
            {
                for (int i = 0; i < TreeSearch.Nodes.Count; i++)
                {
                    for (int j = 0; j < TreeSearch.Nodes[i].Nodes.Count; j++)
                    {
                        for (int k = 0; k < TreeSearch.Nodes[i].Nodes[j].Nodes.Count; k++)
                            if (TreeSearch.Nodes[i].Nodes[j].Nodes[k].Text == reader["cl_name"].ToString())
                                TreeSearch.Nodes[i].Nodes[j].Nodes[k].Nodes.Add(reader["us_number"].ToString() + " " + reader["us_name"].ToString());
                    }
                }
            }
        }

        private void TreeSearch_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 3)
            {
                GloVariant.UserSearch = e.Node.Text.Substring(0,8).ToString();
                //string sqlcompare = "select cl_name from hdu_sce.class";
                //MySQLCommand cmdcompare = new MySQLCommand(sqlcompare, GloVariant.conn);
                //MySQLDataReader readercompare = cmdcompare.ExecuteReaderEx();
                //bool flag=false;
                //while (readercompare.Read())
                //{
                //    if (GloVariant.UserSearch == readercompare["cl_name"].ToString())
                //    { flag=true; }
                //}
                //if (flag)
                //    return;
                //MessageBox.Show(GloVariant.UserSearch);
                string sql = "select u.us_id,us_name,cl_name,st_job,st_part,st_dormitory from hdu_sce.student s join hdu_sce.user u on s.us_id=u.us_id join hdu_sce.class c on s.cl_id=c.cl_id where us_number=" + GloVariant.UserSearch;
                MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
                MySQLDataReader reader = cmd.ExecuteReaderEx();
                reader.Read();
                Txtusid.Text = GloVariant.UserSearch;
                TxtMz.Text = reader["us_name"].ToString();
                TxtJob.Text = reader["st_job"].ToString();
                TxtPart.Text = reader["st_part"].ToString();
                TxtDormitory.Text = reader["st_dormitory"].ToString();
                TxtBj.Text = reader["cl_name"].ToString();
                TxtPart.ReadOnly=false;
                TxtMz.ReadOnly = false;
                TxtJob.ReadOnly = false;
                TxtDormitory.ReadOnly = false;
                TxtBj.ReadOnly = false;
            }
        }

       private void BtnYes_Click(object sender, EventArgs e)
        {
            
            if (TxtBj.Text != "" && Txtusid.Text !=""&& TxtMz.Text != "")
            {
                MySQLCommand setformat = new MySQLCommand("set names gbk", GloVariant.conn);
                setformat.ExecuteNonQuery();
                setformat.Dispose();     
                string sql;
                //获取当前对象
                sql = "select us_id from hdu_sce.user where us_number=" + GloVariant.UserSearch;
                MySQLCommand cmdsear = new MySQLCommand(sql, GloVariant.conn);
                MySQLDataReader reader = cmdsear.ExecuteReaderEx();
                reader.Read();
                GloVariant.Us_idSearch = reader["us_id"].ToString();
                reader.Close();
                cmdsear.Dispose();
                string cl_id=null;
                //获取班级id
                sql = "select cl_id from hdu_sce.class where cl_name='" + TxtBj.Text + "'";
                MySQLCommand cmdcl_id = new MySQLCommand(sql, GloVariant.conn);
                MySQLDataReader readercl_id = cmdcl_id.ExecuteReaderEx();
                if (!readercl_id.Read())
                {
                    MessageBox.Show("班级不存在");
                    return;
                }
                cl_id = readercl_id["cl_id"].ToString();
                //修改信息
                sql = "update hdu_sce.student set st_job='" + TxtJob.Text + "',cl_id='"+cl_id+"',st_part='" + TxtPart.Text + "',st_dormitory='" + TxtDormitory.Text + "' where us_id=" + GloVariant.Us_idSearch;
                MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                sql = "update hdu_sce.user set us_name='" + TxtMz.Text + "' where us_id=" + GloVariant.Us_idSearch;
                MySQLCommand cmdmz = new MySQLCommand(sql, GloVariant.conn);
                cmdmz.ExecuteNonQuery();
                cmdmz.Dispose();
                TxtPart.ReadOnly = true;
                TxtMz.ReadOnly = true;
                TxtJob.ReadOnly = true;
                TxtDormitory.ReadOnly = true;
                TxtBj.ReadOnly = true;
                FrmAdStudent_Load(sender, e);
            }
            else MessageBox.Show("姓名班级不能为空!");
            //if(成功)FrmAdStudent_Load(sender, e);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdStudent_Load(sender, e);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        

        //private void TreeSearch_AfterCollapse(object sender, TreeViewEventArgs e)
        //{
        //    FrmAdStudent_Load(sender, e);
        //}
    }
}
