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
    public partial class Form1 : Form
    {
        Util util = new Util();
        public Form1()
        {
            InitializeComponent();
            MySqlConnection conn = new MySqlConnection(Util.Constr);
            if (!util.OpenMysql(ref conn))
            {
                Console.WriteLine("数据库连接失败");
                return;
            }
            string sql = "select * from txl_user  ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //建立数据集，收集数据
            MySqlDataAdapter ada = new MySqlDataAdapter();
            ada.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
            if (!util.CloseMysql(ref conn))
            {
                Console.WriteLine("数据库关闭连接失败");
                return;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newFrm = new Form2();
            newFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Server=127.0.0.1;User ID=root;Password=5680weikun;Database=my_schema;CharSet=gbk;";
            MySqlConnection conn = new MySqlConnection(str);

            conn.Open();
            string updatesql1 = "update txl_user set name='' , tel='', email=''  , wx_no='' , qq_no='' ,  descript=''  , addr=''where  user_id= '" + Model.user_id + "'";
            util.UpdataMysql(ref conn, updatesql1);
            conn.Close();
            MessageBox.Show("删除成功");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void myschemaDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void 刷新_Click(object sender, EventArgs e)
        {
            
        }
        private DataSet SelectMysql(ref MySqlConnection con, string strcmd)
        {
            try
            {
                //命令
                MySqlCommand cmd = new MySqlCommand(strcmd, con);

                //建立数据集，收集数据
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "127.0.0.1/txl/excel.php?class_id=" + Model.class_id;
            System.Diagnostics.Process.Start("chrome.exe", url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "Server=127.0.0.1;User ID=root;Password=5680weikun;Database=my_schema;CharSet=gbk;";
            MySqlConnection conn = new MySqlConnection(str);

            if (!util.OpenMysql(ref conn))
            {
                Console.WriteLine("数据库连接失败");
                return;
            }
            string sql = "select * from txl_user  ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //建立数据集，收集数据
            MySqlDataAdapter ada = new MySqlDataAdapter();
            ada.SelectCommand = cmd;
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
            if (!util.CloseMysql(ref conn))
            {
                Console.WriteLine("数据库关闭连接失败");
                return;
            }
        }
    }
}
