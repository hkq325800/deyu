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
using Microsoft.VisualBasic;

namespace MoralEvaluated
{
    public partial class FrmClass : FrmModel
    {
        public FrmClass()
        {
            InitializeComponent();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            string sql = "select * from hdu_sce.college";
            MySQLCommand cmd = new MySQLCommand(sql, GloVariant.conn);
            MySQLDataAdapter adapter = new MySQLDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"table");
            foreach (DataRow row in ds.Tables["table"].Rows)
            {
                TreeClass.Nodes.Add(row["co_name"].ToString());
            }
            foreach (TreeNode tn in TreeClass.Nodes)
            {
                tn.Nodes.Add("null");
            }
            /*
            while (reader.Read())
            {                
                TreeClass.Nodes.Add(reader["co_name"].ToString());
                //TreeClass.Nodes[reader["cl_name"].ToString()].Tag = reader["cl_id"];
            }
             */
        }

        private void TreeClass_AfterExpand(object sender, TreeViewEventArgs e)
        {

           // e.Node.Tag
        }

        private void TreeClass_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            /*
            if (e.Node.Nodes.Count == 0)
                e.Node.Nodes.Add("null");
            if (e.Node.Nodes[0].Text != "null")
                return;
            */
            string sql;
            e.Node.Nodes.Clear();
            MySQLCommand cmd;
            MySQLDataAdapter adapter;
            DataSet ds = new DataSet();
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
                sql = "select cl_grade,pr_name from hdu_sce.class t1 join hdu_sce.profession t2 on (t1.pr_id = t2.pr_id) order by cl_grade";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                adapter = new MySQLDataAdapter(cmd);
                adapter.Fill(ds, "table");
                foreach (DataRow row in ds.Tables["table"].Rows)
                {
                    if (e.Node.Text == row["pr_name"].ToString())
                        e.Node.Nodes.Add(row["cl_grade"].ToString());
                }
            }
                /*
            else if (e.Node.Level == 3)
            {
                sql = "select us_name,cl_name from hdu_sce.student t1 join hdu_sce.class t2 on (t1.cl_id = t2.cl_id) join hdu_sce.user t3 on (t3.us_number = t1.us_id)";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                adapter = new MySQLDataAdapter(cmd);
                adapter.Fill(ds, "table");
                foreach (DataRow row in ds.Tables["table"].Rows)
                {
                    if (row["cl_name"].ToString() == e.Node.Text)
                        e.Node.Nodes.Add(row["us_name"].ToString());
                }
            }
                 */
            else return;
            if (e.Node.Level != 2)
                foreach (TreeNode tn in e.Node.Nodes)
                {
                    tn.Nodes.Add("null");
                }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string sql;
            MySQLCommand cmd;
            /*string pr_id;
            FrmClassInfo frmClassInfo = new FrmClassInfo();
            GloVariant.pr_name = TreeClass.SelectedNode.Text;
            GloVariant.cl_op = "add";
            frmClassInfo.ShowDialog();
            if (frmClassInfo.DialogResult == DialogResult.OK)
            {
                sql = "select pr_id from hdu_sce.profession where pr_name = '" + GloVariant.pr_name + "'";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                pr_id = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                sql = "insert into hdu_sce.class (cl_name,pr_id,cl_grade) values ('" + GloVariant.cl_number + "'," + pr_id + "," + GloVariant.grade + ")";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加班级成功!");
                }
                catch
                {
                    MessageBox.Show("您输入的信息有误.");
                }
                frmClassInfo.Dispose();
            }
            */
            string pr_id;
            FrmClassInfo frmClassInfo = new FrmClassInfo();
            GloVariant.pr_name = TreeClass.SelectedNode.Text;
            frmClassInfo.ShowDialog();
            if (frmClassInfo.DialogResult == DialogResult.OK)
            {
                sql = "select pr_id from hdu_sce.profession where pr_name = '" + GloVariant.pr_name + "'";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                pr_id = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                sql = "insert into hdu_sce.class (cl_name,pr_id,cl_grade) values ('" + GloVariant.cl_number + "'," + pr_id + "," + GloVariant.grade + ")";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功,请重新打开该界面查看最新信息!");
                }
                catch
                {
                    MessageBox.Show("班级已存在");
                }
            }
            /*int type;
            type = TreeClass.SelectedNode.Level;
            if (type == 0)
            {
                
                
            }
            else if (type == 1)
            {
                
            }
            else
                return;
             */
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            int type = TreeClass.SelectedNode.Level;
            string temp;
            string sql;
            MySQLCommand cmd;
            if (type == 0)
                return;
            else if (type == 1)
            {
                temp = Microsoft.VisualBasic.Interaction.InputBox("新专业名", "修改专业  -----" + TreeClass.SelectedNode.Text);
                if (temp == "") return;
                sql = "update hdu_sce.profession set pr_name = '" + temp + "' where pr_id = (select pr_id from (select pr_id,pr_name from hdu_sce.profession) as t where t.pr_name = '" + TreeClass.SelectedNode.Text + "')";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改专业名成功!");
                }
                catch
                {
                    MessageBox.Show("修改失败,请联系开发人员.");
                }
            }
            else if (type == 3)
            {
                FrmClassInfo frmClassInfo = new FrmClassInfo();
                GloVariant.cl_op = "update";
                GloVariant.cl_number = TreeClass.SelectedNode.Text;
                GloVariant.grade = TreeClass.SelectedNode.Parent.Text;
                GloVariant.pr_name = TreeClass.SelectedNode.Parent.Parent.Text;
                frmClassInfo.ShowDialog();
                if (frmClassInfo.DialogResult == DialogResult.OK)
                {
                    sql = "update hdu_sce.class set cl_name = '" + GloVariant.cl_number + "',cl_grade = " + GloVariant.grade + ",pr_id = (select pr_id from hdu_sce.profession where pr_name = '" + GloVariant.pr_name + "') where cl_id = (select cl_id from (select cl_id,cl_name from hdu_sce.class) as t where t.cl_name = '" + TreeClass.SelectedNode.Text + "')";
                    cmd = new MySQLCommand(sql, GloVariant.conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改成功!");
                    }
                    catch
                    {
                        MessageBox.Show("修改失败,请联系开发人员!");
                    }
                }
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            string sql;
            int type;
            MySQLCommand cmd;
            type = TreeClass.SelectedNode.Level;
            if (type == 3)
            {
                string cl_id;
                string numOfStu;
                sql = "select cl_id from hdu_sce.class t1 where t1.cl_name = '" + TreeClass.SelectedNode.Text + "'";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                cl_id = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                sql = "select count(*) from hdu_sce.student t1 where t1.cl_id = " + cl_id;
                cmd = new MySQLCommand(sql, GloVariant.conn);
                numOfStu = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                if (numOfStu != "0")
                {
                    MessageBox.Show("请先清空其中的学生信息,再删除班级!");
                    return;
                }
                sql = "delete from hdu_sce.class where cl_name = '" + TreeClass.SelectedNode.Text + "'";
                cmd = new MySQLCommand(sql, GloVariant.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除班级成功!");
            }
            /*
            else if (type == 2)
            {
                ;
            }
            else if (type == 1)
            {
                MessageBox.Show("暂时不支持删除专业的功能!");
            }
            else if (type == 0)
            {
                MessageBox.Show("什么?你想拆了" + TreeClass.SelectedNode.Text + "?");
            }
                 */
        }

        private void TreeClass_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void BtnAddProfession_Click(object sender, EventArgs e)
        {
            string sql;
            string temp;
            string co_id;
            MySQLCommand cmd;
            temp = Microsoft.VisualBasic.Interaction.InputBox("专业名", "添加专业  -----" + TreeClass.SelectedNode.Text);
            if (temp == "") return;
            sql = "select co_id from hdu_sce.college where co_name = '" + TreeClass.SelectedNode.Text + "'";
            cmd = new MySQLCommand(sql, GloVariant.conn);
            co_id = cmd.ExecuteScalar().ToString();
            sql = "insert into hdu_sce.profession (pr_name,co_id) values ('" + temp + "'," + co_id + ")";
            cmd.Dispose();
            cmd = new MySQLCommand(sql, GloVariant.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加成功,请重新打开该界面查看最新信息!");
            }
            catch
            {
                MessageBox.Show("专业已存在");
            }

            //MessageBox.Show("暂时不支持添加专业的功能");
        }
    }
}
