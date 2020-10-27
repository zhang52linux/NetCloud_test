using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_test_jiemian1
{
    public partial class Form2 : Form
    {
        private ArrayList arr = new ArrayList();
        public int pageSize = 8;      //每页记录数
        public int recordCount = 0;    //总记录数
        public int pageCount = 1;      //总页数
        public int currentPage = 1;    //当前页
        DataTable dtSource = new DataTable();
        private MySqlConnection conn = null;
        private MySqlCommand mycmd1 = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cur_page.Text = currentPage.ToString();
            total_page.Text = pageCount.ToString();
            String consqlserver = "server=localhost;user=root;password=linux250; database=c#_project;";
            conn = new MySqlConnection(consqlserver);
            conn.Open();//建立连接，可能出现异常,使用try catch语句
            init_dataGrid();
        }

        private void init_dataGrid()
        {
            mycmd1 = new MySqlCommand("select * from data_table limit 0,40;", conn);
            MySqlDataReader reader = mycmd1.ExecuteReader();
            this.data_list.Rows.Clear();
            while (reader.Read())
            {
                int index = this.data_list.Rows.Add();
                this.data_list.Rows[index].Cells[0].Value = reader[0];
                this.data_list.Rows[index].Cells[1].Value = reader[1];
                this.data_list.Rows[index].Cells[2].Value = reader[2];
                recordCount = recordCount + 1;
                if (recordCount % pageSize == 0)
                {
                    pageCount += 1;
                    total_page.Text = pageCount.ToString();
                }
                max_and_min(int.Parse(reader[1].ToString()));
            }
            total_count.Text = recordCount.ToString();
            reader.Close();
        }

        private void init()
        {
            recordCount = 0;    //总记录数
            pageCount = 1;      //总页数
            currentPage = 1;    //当前页
            total_count.Text = recordCount.ToString();
            total_page.Text = pageCount.ToString();
            cur_page.Text = currentPage.ToString();
            max_value.Text = "0";
            min_value.Text = "0";
            this.data_list.Rows.Clear();   //清除所有的行，形成翻页的效果
            arr.Clear();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            init();  //重新进行数据收集
            if (conn.State.ToString() != "Open")
                conn.Open();//建立连接，可能出现异常,使用try catch语句
            mycmd1 = new MySqlCommand("TRUNCATE TABLE data_table;", conn);   //重置id值
            MySqlDataReader reader = mycmd1.ExecuteReader();
            reader.Close();
            this.timer1.Interval = 3000;  //3s中添加一个
            this.timer1.Start();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int cur_value = r.Next(10, 30);
            string cur_time = DateTime.Now.ToString();
            try {
                mycmd1 = new MySqlCommand("INSERT INTO data_table(Light,gettime) VALUES('" + cur_value + "','" + cur_time + "');", conn);
                MySqlDataReader reader = mycmd1.ExecuteReader();
                reader.Close();
            }
            catch (MySqlException ex)
            {
                mycmd1 = new MySqlCommand("UPDATE data_table SET Light='" + cur_value + "',gettime='"+ cur_time + "' WHERE Id='"+ recordCount + "';", conn);
                MySqlDataReader reader = mycmd1.ExecuteReader();
                reader.Close();
            }
            recordCount = recordCount + 1;
            if (recordCount % pageSize == 0)
            {
                pageCount += 1;
                total_page.Text = pageCount.ToString();
            }
            max_and_min(cur_value);
            total_count.Text = recordCount.ToString();
            LoadPage();
        }

        private void max_and_min(int cur_value)
        {
            arr.Add(cur_value);
            arr.Sort();
            max_value.Text = arr[arr.Count - 1].ToString();
            min_value.Text = arr[0].ToString();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadPage();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadPage();
        }
        private void LoadPage()
        {
            MySqlDataReader reader = null;
            try
            {
                if (currentPage < 1) currentPage = 1;
                if (currentPage > pageCount) currentPage = pageCount;

                int beginRecord;
                int endRecord;

                beginRecord = pageSize * (currentPage - 1);
                if (currentPage == 1) beginRecord = 0;
                endRecord = pageSize * currentPage;

                if (currentPage == pageCount) endRecord = recordCount;
                beginRecord = pageSize * (currentPage - 1);
                if (currentPage == 1) beginRecord = 0;
                endRecord = pageSize * currentPage;

                if (currentPage == pageCount) endRecord = recordCount;
                mycmd1 = new MySqlCommand("select * from data_table limit " + beginRecord + "," + (endRecord + 1) + ";", conn);
                if (conn.State.ToString() == "Open")
                {
                    reader = mycmd1.ExecuteReader();
                }
                else
                { return; }
                this.data_list.Rows.Clear();   //清除所有的行，形成翻页的效果
                while (reader.Read())
                {
                    int index = this.data_list.Rows.Add();
                    this.data_list.Rows[index].Cells[0].Value = reader[0];
                    this.data_list.Rows[index].Cells[1].Value = reader[1];
                    this.data_list.Rows[index].Cells[2].Value = reader[2];
                }
                //MessageBox.Show(beginRecord.ToString(), endRecord.ToString());
                cur_page.Text = currentPage.ToString();//当前页
                total_page.Text = pageCount.ToString();//总页数
                total_count.Text = recordCount.ToString();//总记录数
                reader.Close();
            }
            catch(MySqlException ex) {
                Console.WriteLine("error");
                reader.Close();
            }
            
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadPage();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            currentPage = pageCount;
            LoadPage();
        }
    }
}
