using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Classmate
{
    public static class Model
    {
        public static string user_id;
        public static string stu_no;
        public static string class_id;
        public static string class_name;
        public static string name;
        public static string tel;
        public static string addr;
        public static string email;
        public static string qq_no;
        public static string wx_no;
        public static string description;
    }
    public class Util
    {
        public const string Constr = "Server=localhost;User ID=root;Password=5680weikun;Database=my_schema;CharSet=gbk;";
        public void Init()
        {          
            string SQL = "select * from txl_user where user_id ='" + Model.user_id + "'";
            MySqlConnection mycon = new MySqlConnection(Constr);
            Util util = new Util();
            if (!util.OpenMysql(ref mycon))
            {
                Console.WriteLine("数据库连接失败");
                return;
            }
            DataSet ds = new DataSet();
            ds = SelectMysql(ref mycon, SQL);
            if (ds != null)
            {
                Model.name = ds.Tables[0].Rows[0][0].ToString();
                Model.tel = ds.Tables[0].Rows[0][1].ToString();
                Model.addr = ds.Tables[0].Rows[0][2].ToString();
                Model.email = ds.Tables[0].Rows[0][3].ToString();
                Model.wx_no = ds.Tables[0].Rows[0][4].ToString();
                Model.qq_no = ds.Tables[0].Rows[0][5].ToString();
                Model.description = ds.Tables[0].Rows[0][6].ToString();
                Model.class_id = ds.Tables[0].Rows[0][12].ToString();
                Model.class_name = ds.Tables[0].Rows[0][13].ToString();
            }
            if (!util.CloseMysql(ref mycon))
            {
                Console.WriteLine("数据库关闭连接失败");
                return;
            }
        }
        //连接数据库
        public bool OpenMysql(ref MySqlConnection con)
        {
            try
            {
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        //查
        public DataSet SelectMysql(ref MySqlConnection con, string strcmd)
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
        //删改
        public bool UpdataMysql(ref MySqlConnection con, string strcmd)
        {
            try
            {
                //命令
                MySqlCommand cmd = new MySqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        //增
        public bool InsertMysql(ref MySqlConnection con, string strcmd)
        {
            try
            {
                //命令
                MySqlCommand cmd = new MySqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        //关闭数据库
        public bool CloseMysql(ref MySqlConnection con)
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
    

}
