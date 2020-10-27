namespace Net_test_jiemian1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cur_temp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_setting = new System.Windows.Forms.Button();
            this.tb_max = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_ListImage12 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_autoclose = new System.Windows.Forms.Button();
            this.btn_autoopen = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.online_staus = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ListImage12)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cur_temp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(21, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(165, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "温度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "℃";
            // 
            // cur_temp
            // 
            this.cur_temp.AutoSize = true;
            this.cur_temp.Location = new System.Drawing.Point(87, 41);
            this.cur_temp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cur_temp.Name = "cur_temp";
            this.cur_temp.Size = new System.Drawing.Size(16, 15);
            this.cur_temp.TabIndex = 1;
            this.cur_temp.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前温度:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_setting);
            this.groupBox2.Controls.Add(this.tb_max);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_min);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(218, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(343, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "阀值设定";
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_setting.Location = new System.Drawing.Point(280, 34);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(2);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(56, 22);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.Text = "设置";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // tb_max
            // 
            this.tb_max.Location = new System.Drawing.Point(168, 34);
            this.tb_max.Margin = new System.Windows.Forms.Padding(2);
            this.tb_max.Name = "tb_max";
            this.tb_max.Size = new System.Drawing.Size(76, 24);
            this.tb_max.TabIndex = 3;
            this.tb_max.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "下限:";
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(46, 34);
            this.tb_min.Margin = new System.Windows.Forms.Padding(2);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(54, 24);
            this.tb_min.TabIndex = 1;
            this.tb_min.Text = "15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "上限:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_ListImage12);
            this.groupBox3.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(21, 152);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(553, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "风扇状态";
            // 
            // m_ListImage12
            // 
            this.m_ListImage12.Image = ((System.Drawing.Image)(resources.GetObject("m_ListImage12.Image")));
            this.m_ListImage12.Location = new System.Drawing.Point(164, 14);
            this.m_ListImage12.Margin = new System.Windows.Forms.Padding(2);
            this.m_ListImage12.Name = "m_ListImage12";
            this.m_ListImage12.Size = new System.Drawing.Size(188, 109);
            this.m_ListImage12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_ListImage12.TabIndex = 0;
            this.m_ListImage12.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_autoclose);
            this.groupBox4.Controls.Add(this.btn_autoopen);
            this.groupBox4.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(21, 284);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(262, 102);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "自动控制";
            // 
            // btn_autoclose
            // 
            this.btn_autoclose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_autoclose.Font = new System.Drawing.Font("新宋体", 8F, System.Drawing.FontStyle.Bold);
            this.btn_autoclose.Location = new System.Drawing.Point(144, 38);
            this.btn_autoclose.Margin = new System.Windows.Forms.Padding(2);
            this.btn_autoclose.Name = "btn_autoclose";
            this.btn_autoclose.Size = new System.Drawing.Size(104, 35);
            this.btn_autoclose.TabIndex = 1;
            this.btn_autoclose.Text = "关闭自动控制";
            this.btn_autoclose.UseVisualStyleBackColor = false;
            this.btn_autoclose.Click += new System.EventHandler(this.btn_autoclose_Click);
            // 
            // btn_autoopen
            // 
            this.btn_autoopen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_autoopen.Font = new System.Drawing.Font("新宋体", 8F, System.Drawing.FontStyle.Bold);
            this.btn_autoopen.Location = new System.Drawing.Point(4, 38);
            this.btn_autoopen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_autoopen.Name = "btn_autoopen";
            this.btn_autoopen.Size = new System.Drawing.Size(94, 35);
            this.btn_autoopen.TabIndex = 0;
            this.btn_autoopen.Text = "开启自动控制";
            this.btn_autoopen.UseVisualStyleBackColor = false;
            this.btn_autoopen.Click += new System.EventHandler(this.btn_autoopen_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_close);
            this.groupBox5.Controls.Add(this.btn_open);
            this.groupBox5.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(316, 284);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(257, 102);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "手动控制";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_close.Font = new System.Drawing.Font("新宋体", 8F, System.Drawing.FontStyle.Bold);
            this.btn_close.Location = new System.Drawing.Point(151, 38);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 35);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "手动关风扇";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_open.Font = new System.Drawing.Font("新宋体", 8F, System.Drawing.FontStyle.Bold);
            this.btn_open.Location = new System.Drawing.Point(11, 38);
            this.btn_open.Margin = new System.Windows.Forms.Padding(2);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(88, 35);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "手动开风扇";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "连接状态:";
            // 
            // online_staus
            // 
            this.online_staus.Font = new System.Drawing.Font("新宋体", 11F, System.Drawing.FontStyle.Bold);
            this.online_staus.Location = new System.Drawing.Point(100, 14);
            this.online_staus.Margin = new System.Windows.Forms.Padding(2);
            this.online_staus.Name = "online_staus";
            this.online_staus.ReadOnly = true;
            this.online_staus.Size = new System.Drawing.Size(76, 24);
            this.online_staus.TabIndex = 6;
            this.online_staus.Text = "离线";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 397);
            this.Controls.Add(this.online_staus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_ListImage12)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cur_temp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.TextBox tb_max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_autoclose;
        private System.Windows.Forms.Button btn_autoopen;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.PictureBox m_ListImage12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox online_staus;
        private System.Windows.Forms.Timer timer1;
    }
}