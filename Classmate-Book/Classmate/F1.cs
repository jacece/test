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
    public partial class F1 : Form
    {
        Util util = new Util();
        public F1()
        {
            InitializeComponent();
            string str = "Server=127.0.0.1;User ID=root;Password=5680weikun;Database=my_schema;CharSet=gbk;";
            MySqlConnection con = new MySqlConnection(str);
            string strcmd = "select* from txl_user";

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
        }     

        private void Button1_Click(object sender, EventArgs e)
        {
            F2 k = new F2();
            k.Show();
            //this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            F3 k = new F3();
            k.Show();
            //this.Close();
        }

        private void F1_Load(object sender, EventArgs e)
        {

        }
    }
}
