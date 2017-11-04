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
    public partial class F4 : Form
    {
        Util util = new Util();
        public F4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string str = "Server=127.0.0.1;User ID=root;Password=5680weikun;Database=my_schema;CharSet=gbk;";
            MySqlConnection con = new MySqlConnection(str);

            string content = textBox1.Text;
            string datetime = DateTime.Now.ToLocalTime().ToString();
            int class_id = 1;

            string strcmd = "insert into txl_msg(class_id,content,datetime) values('" + class_id + "','" + content + "','" + datetime + "')";

            //打开数据库
            if (!util.OpenMysql(ref con))
            {
                Console.WriteLine("数据库连接失败");
                return;
            }

            //建立数据集，收集数据，执行查询语句
            if (util.InsertMysql(ref con, strcmd))
            {
                Console.WriteLine("yes");
                textBox1.Text = "";
                label1.Text = "发布成功";
            }
            else
            {
                Console.WriteLine("no");
            }

            //关闭数据库
            if (!util.CloseMysql(ref con))
            {
                Console.WriteLine("数据库关闭连接失败");
                return;
            }
        }

       

        private void F4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
