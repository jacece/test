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
    public partial class Form2 : Form
    {
        Util util = new Util();
        public Form2()
        {
            InitializeComponent();
            util.Init();
            textBox1.Text = Model.name;
            textBox2.Text = Model.tel;
            textBox3.Text = Model.email;
            textBox4.Text = Model.addr;
            textBox5.Text = Model.wx_no;
            textBox6.Text = Model.qq_no;
            textBox7.Text = Model.description;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "Server=127.0.0.1;User ID=root;Password=5680weikun;Database=my_schema;CharSet=gbk;";
            MySqlConnection conn = new MySqlConnection(str);
            if (!util.OpenMysql(ref conn))
            {
                Console.WriteLine("数据库连接失败");
                return;
            }
            string updatesql1 = "update txl_user set name='" + textBox1.Text + "' , tel='" + textBox2.Text + "', email='" + textBox3.Text + "'  , wx_no='" + textBox5.Text + "' , qq_no='" + textBox6.Text + "' ,  descript='" + textBox7.Text + "'  , addr='" + textBox4.Text + "'where  user_id= '" + Model.user_id + "'";
            //UpdataMysql(ref conn, updatesql1);
            MySqlCommand cmd = new MySqlCommand(updatesql1, conn);
            cmd.CommandType = CommandType.Text;
            int ret1 = (int)cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("保存成功");
            this.Hide();
            Form1 newFrm = new Form1();
            newFrm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newFrm = new Form1();
            newFrm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }       
    }
}
