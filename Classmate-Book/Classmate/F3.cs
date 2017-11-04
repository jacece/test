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
    public partial class F3 : Form
    {
        Util util = new Util();
        public F3()
        {
            InitializeComponent();
            string str = "Server=127.0.0.1;User ID=root;Password=5680weikun;Database=my_schema;CharSet=gbk;";
            MySqlConnection con = new MySqlConnection(str);
            string strcmd = "select msg_id,class_id,content,datetime from txl_msg";

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
        private void Button1_Click(object sender, EventArgs e)
        {
            F4 k = new F4();
            k.Show();
            this.Close();
        }      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void F3_Load(object sender, EventArgs e)
        {

        }
    }
}