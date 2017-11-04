using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Classmate
{
    public partial class F2 : Form
    {
        Util util = new Util();
        public F2()
        {
            InitializeComponent();
            ShowFresh();
        }
        
        private void Button_Click(object sender, EventArgs e)
        {
            string str = "Server=127.0.0.1;User ID=root;Password=5680weikun;Database=my_schema;CharSet=gbk;";
            MySqlConnection con = new MySqlConnection(str);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    string stu_no = dataGridView1.Rows[i].Cells[2].Value.ToString();

                    string strcmd = "update txl_user set name='',tel='',addr='',email='',wx_no='',qq_no='',descript='' where stu_no='" + stu_no + "'";
                    //打开数据库3
                    if (!util.OpenMysql(ref con))
                    {
                        Console.WriteLine("数据库连接失败");
                        return;
                    }
                    //建立数据集，收集数据，执行查询语句
                    if (util.UpdataMysql(ref con, strcmd))
                    {
                        Console.WriteLine("yes");
                        label1.Text = "删除成功";
                        ShowFresh();
                    }
                    else
                    {
                        Console.WriteLine("no");
                        label1.Text = "删除失败";
                    }
                    //关闭数据库
                    if (!util.CloseMysql(ref con))
                    {
                        Console.WriteLine("数据库关闭连接失败");
                        return;
                    }
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            
        }
        private void ShowFresh()
        {
            string str = "Server=127.0.0.1;User ID=root;Password=5680weikun;Database=my_schema;CharSet=gbk;";
            MySqlConnection con = new MySqlConnection(str);
            string strcmd = "select user_id,stu_no,class_name,name,tel,addr,email,wx_no,qq_no,descript from txl_user";

            if (!util.OpenMysql(ref con))
            {
                Console.WriteLine("数据库连接失败");
                return;
            }

            //建立数据集，收集数据，执行查询语句
            DataSet ds = new DataSet();
            ds = util.SelectMysql(ref con, strcmd);

            //关闭数据库
            if (!util.CloseMysql(ref con))
            {
                Console.WriteLine("数据库关闭连接失败");
                return;
            }

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void F2_Load(object sender, EventArgs e)
        {
            
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "127.0.0.1/txl/excel.php?class_id=" + Model.class_id;
            System.Diagnostics.Process.Start("chrome.exe", url);
        }
    }
}
