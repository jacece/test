using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Classmate
{
    public partial class Login : Form
    {
        Util util=new Util();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string Conn = "Server=localhost;User ID=root;Password=5680weikun;Database=my_schema;CharSet=gbk;";
            MySqlConnection mycon = new MySqlConnection(Conn);
            string SQL = "select user_id from txl_user where stu_no ='"+ textBox1.Text + "'and pwd='"+textBox2.Text+"'";        
            if (!util.OpenMysql(ref mycon))
            {
                MessageBox.Show("数据库连接失败");
                return;
            }
            MySqlCommand cmd = new MySqlCommand(SQL, mycon);
            MySqlDataReader sdr;
            sdr = cmd.ExecuteReader();         
             if (sdr.Read())
            {
                Model.stu_no = textBox1.Text;
                Model.user_id= sdr[0].ToString();
                util.Init();
                if (comboBox1.Text == "学生")
                {                  
                    this.Hide();
                    Form1 newFrm = new Form1();
                    newFrm.Show();
                }
                else
                {
                    this.Hide();
                    F1 newFrm = new F1();
                    newFrm.Show();
                }
            }
            else
            {
                MessageBox.Show("登录失败");
            }
            //关闭数据库
            if (!util.CloseMysql(ref mycon))
            {
                MessageBox.Show("数据库关闭连接失败");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
