namespace Net_test_jiemian1
{
    partial class Form2
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.data_list = new System.Windows.Forms.DataGridView();
            this.名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.total_count = new System.Windows.Forms.Label();
            this.max_value = new System.Windows.Forms.Label();
            this.min_value = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.curpage = new System.Windows.Forms.Label();
            this.cur_page = new System.Windows.Forms.TextBox();
            this.totalpage = new System.Windows.Forms.Label();
            this.total_page = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_list)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(58, 25);
            this.btn_start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(121, 33);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "开始采集";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(596, 25);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(124, 33);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "停止采集";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // data_list
            // 
            this.data_list.AllowUserToAddRows = false;
            this.data_list.AllowUserToResizeRows = false;
            this.data_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名字,
            this.性别,
            this.学号});
            this.data_list.Location = new System.Drawing.Point(57, 103);
            this.data_list.Margin = new System.Windows.Forms.Padding(2);
            this.data_list.Name = "data_list";
            this.data_list.ReadOnly = true;
            this.data_list.RowHeadersVisible = false;
            this.data_list.RowTemplate.Height = 27;
            this.data_list.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.data_list.Size = new System.Drawing.Size(663, 178);
            this.data_list.TabIndex = 2;
            // 
            // 名字
            // 
            this.名字.HeaderText = "序号";
            this.名字.MinimumWidth = 220;
            this.名字.Name = "名字";
            this.名字.Width = 220;
            // 
            // 性别
            // 
            this.性别.HeaderText = "温度值";
            this.性别.MinimumWidth = 220;
            this.性别.Name = "性别";
            this.性别.Width = 220;
            // 
            // 学号
            // 
            this.学号.HeaderText = "获取时间";
            this.学号.MinimumWidth = 220;
            this.学号.Name = "学号";
            this.学号.Width = 220;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "历史最高温度:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(169, 322);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(7, 6);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_pre
            // 
            this.btn_pre.Location = new System.Drawing.Point(327, 313);
            this.btn_pre.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(87, 31);
            this.btn_pre.TabIndex = 7;
            this.btn_pre.Text = "上一页";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(499, 313);
            this.btn_end.Margin = new System.Windows.Forms.Padding(2);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(85, 30);
            this.btn_end.TabIndex = 8;
            this.btn_end.Text = "末页";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(58, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "总条数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "历史最低温度:";
            // 
            // total_count
            // 
            this.total_count.AutoSize = true;
            this.total_count.Location = new System.Drawing.Point(115, 290);
            this.total_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_count.Name = "total_count";
            this.total_count.Size = new System.Drawing.Size(12, 12);
            this.total_count.TabIndex = 11;
            this.total_count.Text = "0";
            // 
            // max_value
            // 
            this.max_value.AutoSize = true;
            this.max_value.Location = new System.Drawing.Point(152, 74);
            this.max_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.max_value.Name = "max_value";
            this.max_value.Size = new System.Drawing.Size(26, 12);
            this.max_value.TabIndex = 12;
            this.max_value.Text = "100";
            // 
            // min_value
            // 
            this.min_value.AutoSize = true;
            this.min_value.Location = new System.Drawing.Point(548, 74);
            this.min_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.min_value.Name = "min_value";
            this.min_value.Size = new System.Drawing.Size(19, 12);
            this.min_value.TabIndex = 13;
            this.min_value.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "LX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "LX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 290);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "条";
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(239, 313);
            this.btn_first.Margin = new System.Windows.Forms.Padding(2);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(87, 31);
            this.btn_first.TabIndex = 17;
            this.btn_first.Text = "首页";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(414, 313);
            this.btn_next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(85, 30);
            this.btn_next.TabIndex = 18;
            this.btn_next.Text = "下一页";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // curpage
            // 
            this.curpage.AutoSize = true;
            this.curpage.Location = new System.Drawing.Point(505, 290);
            this.curpage.Name = "curpage";
            this.curpage.Size = new System.Drawing.Size(64, 12);
            this.curpage.TabIndex = 19;
            this.curpage.Text = "当前页数:";
            // 
            // cur_page
            // 
            this.cur_page.Location = new System.Drawing.Point(576, 287);
            this.cur_page.Name = "cur_page";
            this.cur_page.Size = new System.Drawing.Size(29, 21);
            this.cur_page.TabIndex = 20;
            // 
            // totalpage
            // 
            this.totalpage.AutoSize = true;
            this.totalpage.Location = new System.Drawing.Point(622, 289);
            this.totalpage.Name = "totalpage";
            this.totalpage.Size = new System.Drawing.Size(51, 12);
            this.totalpage.TabIndex = 21;
            this.totalpage.Text = "总页数:";
            // 
            // total_page
            // 
            this.total_page.Location = new System.Drawing.Point(680, 285);
            this.total_page.Name = "total_page";
            this.total_page.Size = new System.Drawing.Size(35, 21);
            this.total_page.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 356);
            this.Controls.Add(this.total_page);
            this.Controls.Add(this.totalpage);
            this.Controls.Add(this.cur_page);
            this.Controls.Add(this.curpage);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.min_value);
            this.Controls.Add(this.max_value);
            this.Controls.Add(this.total_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_list);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "温度采集器";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.DataGridView data_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total_count;
        private System.Windows.Forms.Label max_value;
        private System.Windows.Forms.Label min_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名字;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.Label curpage;
        private System.Windows.Forms.TextBox cur_page;
        private System.Windows.Forms.Label totalpage;
        private System.Windows.Forms.TextBox total_page;
    }
}