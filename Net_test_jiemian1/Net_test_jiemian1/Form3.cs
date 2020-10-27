using NLECloudSDK;
using NLECloudSDK.Model;
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
using System.Windows;
using MessageBox = System.Windows.MessageBox;

namespace Net_test_jiemian1
{
    public partial class Form3 : Form
    {
        private NLECloudAPI SDK = null;
        private string accessToken = "";
        private bool Login_res = false;
        private ResultMsg<AccountLoginResultDTO> Login_obj = null;
        private int flag = 0;  //标识是否查找成功
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var input_username = username.Text;
            var input_password = password.Text;
            bool res = login_passwd(input_username, input_password);
            if (res)
            {
                SDK = new NLECloudAPI("http://api.nlecloud.com");
                AccountLoginDTO submitData = new AccountLoginDTO()
                {
                    Account = input_username,
                    Password = input_password,
                    IsRememberMe = false
                };
                Login_obj = SDK.UserLogin(submitData);
                Login_res = Login_obj.IsSuccess();
                if (Login_res)
                {
                    accessToken = Login_obj.ResultObj.AccessToken;
                    Form1 f1 = new Form1(SDK,Login_obj,Login_res);
                    f1.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("账号或密码错误，请重新输入!!!", "提示");
            } 
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool login_passwd(string username,string password)
        {
            String consqlserver = "server=localhost;user=root;password=linux250; database=c#_project;";
            MySqlConnection conn = new MySqlConnection(consqlserver);
            try
            {
                conn.Open();//建立连接，可能出现异常,使用try catch语句
                MySqlCommand mycmd1 = new MySqlCommand("select `username`,`password` from user WHERE username='" + username + "' AND password='" + password + "';", conn);
                MySqlDataReader reader = mycmd1.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);//有错则报出错误
            }
            finally
            {
                conn.Close();//关闭通道
                Console.WriteLine("数据库连接已断开");  //执行完try或者是catch中的语句后自动执行 
            }
            return false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            String consqlserver = "server=localhost;user=root;password=linux250; database=c#_project;";
            MySqlConnection conn = new MySqlConnection(consqlserver);
            try
            {
                conn.Open();//建立连接，可能出现异常,使用try catch语句
                MySqlCommand mycmd1 = new MySqlCommand("select * from user", conn);
                MySqlDataReader reader = mycmd1.ExecuteReader();
                while (reader.Read())
                {
                    username.Items.Add(reader[0].ToString());
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);//有错则报出错误
            }
            finally
            {
                conn.Close();//关闭通道
                Console.WriteLine("数据库连接已断开");  //执行完try或者是catch中的语句后自动执行
            }
        }
    }
}
