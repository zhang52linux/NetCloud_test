namespace Net_test_jiemian1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.btn_init = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.rb1.Location = new System.Drawing.Point(43, 22);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(62, 16);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "折线图";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.rb2.Location = new System.Drawing.Point(153, 22);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(62, 16);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "波线图";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // btn_init
            // 
            this.btn_init.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btn_init.Location = new System.Drawing.Point(358, 22);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(116, 23);
            this.btn_init.TabIndex = 2;
            this.btn_init.Text = "初始化";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click_1);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btn_start.Location = new System.Drawing.Point(497, 22);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(116, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click_1);
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btn_end.Location = new System.Drawing.Point(631, 22);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(116, 23);
            this.btn_end.TabIndex = 4;
            this.btn_end.Text = "结束";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click_1);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(43, 81);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(704, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 437);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Timer timer1;
    }
}