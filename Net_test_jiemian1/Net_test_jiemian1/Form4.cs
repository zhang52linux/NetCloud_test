using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Net_test_jiemian1
{
    public partial class Form4 : Form
    {
        private Queue<double> dataQueue = new Queue<double>(50);  //初始化一个队列，存放200个数据
        private int curValue = 0;
        private int num = 5;             //每次删除增加几个点

        public Form4()
        {
            InitializeComponent();
        }

        private void InitChart()
        {
            //定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("S1");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            //设置图表显示样式
            this.chart1.ChartAreas[0].AxisY.Minimum = 30;     //最小值
            this.chart1.ChartAreas[0].AxisY.Maximum = 100;   //最大值
            this.chart1.ChartAreas[0].AxisX.Interval = 3;    //间隔
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //设置标题
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "温度显示";
            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //设置图表显示样式
            this.chart1.Series[0].Color = Color.Red;
            if (rb1.Checked)
            {
                this.chart1.Titles[0].Text = string.Format("温度 {0} 显示", rb1.Text);
                this.chart1.Series[0].ChartType = SeriesChartType.Line;
            }
            if (rb2.Checked)
            {
                this.chart1.Titles[0].Text = string.Format("温度 {0} 显示", rb2.Text);
                this.chart1.Series[0].ChartType = SeriesChartType.Spline;
            }
            this.chart1.Series[0].Points.Clear();
        }
        private void UpdateQueueValue()
        {

            if (dataQueue.Count > 50)   // 当队列中的数据满了后，开始从队列中取出数据
            {
                //先出列
                for (int i = 0; i < num; i++)
                {
                    dataQueue.Dequeue();
                }
            }
            if (rb1.Checked)   // 这是折线图
            {
                Random r = new Random();     // 先随机获取数据，以后可以从云平台上进行获取
                for (int i = 0; i < num; i++)
                {
                    dataQueue.Enqueue(r.Next(30, 100));   //直接在这里获取云平台上的数据即可
                }
            }
            if (rb2.Checked)   //这是波形图
            {
                for (int i = 0; i < num; i++)
                {
                    //对curValue只取[0,360]之间的值
                    curValue = curValue % 360;
                    //对得到的正玄值，放大50倍，并上移50
                    dataQueue.Enqueue((50 * Math.Sin(curValue * Math.PI / 180)) + 50);
                    curValue = curValue + 10;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateQueueValue();
            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataQueue.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue.ElementAt(i));
            }
        }

        private void btn_init_Click_1(object sender, EventArgs e)
        {
            InitChart();
        }

        private void btn_start_Click_1(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void btn_end_Click_1(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }
    }
}

