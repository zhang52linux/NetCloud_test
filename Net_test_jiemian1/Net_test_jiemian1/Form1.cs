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
using System.Windows.Threading;

namespace Net_test_jiemian1
{
    public partial class Form1 : Form
    {
        private NLECloudAPI SDK = null;
        private string accessToken = "";
        private bool Login_res = false;
        private ResultMsg<AccountLoginResultDTO> Login_obj = null;
        private int devi_id = 133741;  //133741 -135389
        private string tep_min = "0";   //设置自动控制的最低温度
        private string tep_max = "0";   //设置自动控制的最高温度
        private bool fan_status = false;  //初始化当前风扇状态为关闭
        public Form1(NLECloudAPI SDK,ResultMsg<AccountLoginResultDTO>  Login_obj,bool Login_res)
        {
            /*var account = "13974318856";  //13974318856
            var password = "djx123456";             //djx123456
            SDK = new NLECloudAPI("http://api.nlecloud.com");
            AccountLoginDTO submitData = new AccountLoginDTO()
            {
                Account = account,
                Password = password,
                IsRememberMe = false
            };
            Login_obj = SDK.UserLogin(submitData);
            Login_res = Login_obj.IsSuccess();
            */
            if (Login_res)
            {
                MessageBox.Show("登录成功!!!!!");
                this.SDK = SDK;
                accessToken = Login_obj.ResultObj.AccessToken; 
                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromMilliseconds(4000);
                timer.Tick += new EventHandler(update_data);
                timer.Start();
            }
            else
            {
                MessageBox.Show("登录失败！！！！！," + Login_obj.Msg, "提示");
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.m_ListImage12.Image = Image.FromFile("C://Microsoft Visual Studio//2017//projects//Net_test_jiemian1//Net_test_jiemian1//Properties//" + "1.png");
            this.btn_close.Enabled = false;
            this.btn_autoclose.Enabled = false;
            tep_min = tb_min.Text;  //获取最低预设值
            tep_max = tb_max.Text;  //获取最高预设值
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result res = SDK.Cmds(devi_id, "ctrl", 0, accessToken);
            if (res.IsSuccess())
            {
                this.m_ListImage12.Image = Image.FromFile("C://Microsoft Visual Studio//2017//projects//Net_test_jiemian1//Net_test_jiemian1//Properties//" + "1.png");
                MessageBox.Show("风扇关闭成功!!!!!", "提示");
            }
            else
            {
                MessageBox.Show("风扇关闭失败!!!!!," + res.Msg.ToString(), "提示");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            Result res = SDK.Cmds(devi_id, "ctrl", 1, accessToken);
            if (res.IsSuccess())
            {
                this.m_ListImage12.Image = Image.FromFile("C://Microsoft Visual Studio//2017//projects//Net_test_jiemian1//Net_test_jiemian1//Properties//" + "1.gif");
                MessageBox.Show("风扇打开成功!!!!!", "提示");
                this.btn_close.Enabled = true;
            }
            else
            {
                MessageBox.Show("风扇打开失败!!!!!," + res.Msg.ToString(), "提示");
            }
        }
        private void update_data(object sender, EventArgs e)
        {
            ResultMsg<SensorBaseInfoDTO> status = SDK.GetSensorInfo(devi_id, "nl_temperature", accessToken);
            if (status.IsSuccess())
            {
                string resu = status.ResultObj.Value.ToString();
            }
            ResultMsg<IEnumerable<OnlineDataDTO>> devi_status = SDK.GetDevicesStatus("" + devi_id, accessToken);
            bool is_online = false;
            foreach (var l in devi_status.ResultObj)
            {
                is_online = l.IsOnline;
            }
            if (is_online)
            {
                online_staus.Text = "在线";
            }
            else
            {
                online_staus.Text = "离线";
            }
        }

        private void btn_autoopen_Click(object sender, EventArgs e)
        {
            this.btn_autoclose.Enabled = true;
            this.btn_open.Enabled = false;   //关闭手动的打开按钮
            this.btn_close.Enabled = false;  //关闭手动的关闭按钮
            this.timer1.Interval = 5000;    //设置定时器的间隔,5s
            this.timer1.Start();   //启动定时器

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            tep_min = tb_min.Text;
            tep_max = tb_max.Text;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //从云端获取当前控件的温度
            Random r = new Random();
            string curTmp = r.Next(5, 50).ToString();
            cur_temp.Text = curTmp;  //获取当前的温度后，并将该温度更新到温度显示器上
            if (int.Parse(curTmp) > int.Parse(tep_min) && int.Parse(curTmp) < int.Parse(tep_max))
            {
                //向云端发送数据，控制打开风扇
                //代码优化，先获取云端状态已经打开就不用重复打开了
                if (fan_status != true)
                {
                    MessageBox.Show("风扇打开!!!");
                    fan_status = true;
                }               
            }
            else
            {
                //向云端发送数据，控制关闭风扇
                //代码优化，先获取云端状态已经关闭就不用重复关闭了
                if (fan_status != false)
                {
                    MessageBox.Show("风扇关闭!!!");
                    fan_status = false;
                }            
            }
        }

        private void btn_autoclose_Click(object sender, EventArgs e)
        {
            this.btn_open.Enabled = true;   //关闭手动的打开按钮
            this.timer1.Stop();   //启动定时器
        }
    }
}
