
namespace PABAIDU
{
    partial class BaiDuSprider
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SelectPath = new System.Windows.Forms.Button();
            this.n_page = new System.Windows.Forms.NumericUpDown();
            this.btn_Download = new System.Windows.Forms.Button();
            this.t_SavePath = new System.Windows.Forms.TextBox();
            this.t_KeyWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.c_manual = new System.Windows.Forms.CheckBox();
            this.n_neight = new System.Windows.Forms.NumericUpDown();
            this.n_width = new System.Windows.Forms.NumericUpDown();
            this.c_size = new System.Windows.Forms.ComboBox();
            this.c_type = new System.Windows.Forms.ComboBox();
            this.c_color = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_logs = new System.Windows.Forms.TextBox();
            this.b_Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_page)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_neight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_width)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SelectPath);
            this.groupBox1.Controls.Add(this.n_page);
            this.groupBox1.Controls.Add(this.btn_Download);
            this.groupBox1.Controls.Add(this.t_SavePath);
            this.groupBox1.Controls.Add(this.t_KeyWord);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本设置";
            // 
            // btn_SelectPath
            // 
            this.btn_SelectPath.Location = new System.Drawing.Point(287, 62);
            this.btn_SelectPath.Name = "btn_SelectPath";
            this.btn_SelectPath.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectPath.TabIndex = 8;
            this.btn_SelectPath.Text = "选择路径";
            this.btn_SelectPath.UseVisualStyleBackColor = true;
            this.btn_SelectPath.Click += new System.EventHandler(this.btn_SelectPath_Click);
            // 
            // n_page
            // 
            this.n_page.Location = new System.Drawing.Point(201, 29);
            this.n_page.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_page.Name = "n_page";
            this.n_page.Size = new System.Drawing.Size(80, 21);
            this.n_page.TabIndex = 7;
            this.n_page.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_page.ValueChanged += new System.EventHandler(this.n_page_ValueChanged);
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(287, 29);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(75, 23);
            this.btn_Download.TabIndex = 6;
            this.btn_Download.Text = "开始下载";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // t_SavePath
            // 
            this.t_SavePath.Location = new System.Drawing.Point(80, 64);
            this.t_SavePath.Name = "t_SavePath";
            this.t_SavePath.Size = new System.Drawing.Size(201, 21);
            this.t_SavePath.TabIndex = 5;
            this.t_SavePath.TextChanged += new System.EventHandler(this.t_SavePath_TextChanged);
            // 
            // t_KeyWord
            // 
            this.t_KeyWord.Location = new System.Drawing.Point(80, 28);
            this.t_KeyWord.Name = "t_KeyWord";
            this.t_KeyWord.Size = new System.Drawing.Size(77, 21);
            this.t_KeyWord.TabIndex = 3;
            this.t_KeyWord.TextChanged += new System.EventHandler(this.t_KeyWord_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "页数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "保存路径";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "关键词";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.c_manual);
            this.groupBox2.Controls.Add(this.n_neight);
            this.groupBox2.Controls.Add(this.n_width);
            this.groupBox2.Controls.Add(this.c_size);
            this.groupBox2.Controls.Add(this.c_type);
            this.groupBox2.Controls.Add(this.c_color);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选设置";
            // 
            // c_manual
            // 
            this.c_manual.AutoSize = true;
            this.c_manual.Location = new System.Drawing.Point(182, 66);
            this.c_manual.Name = "c_manual";
            this.c_manual.Size = new System.Drawing.Size(15, 14);
            this.c_manual.TabIndex = 10;
            this.c_manual.UseVisualStyleBackColor = true;
            this.c_manual.CheckedChanged += new System.EventHandler(this.c_manual_CheckedChanged);
            // 
            // n_neight
            // 
            this.n_neight.Enabled = false;
            this.n_neight.Location = new System.Drawing.Point(308, 62);
            this.n_neight.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.n_neight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_neight.Name = "n_neight";
            this.n_neight.Size = new System.Drawing.Size(56, 21);
            this.n_neight.TabIndex = 9;
            this.n_neight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // n_width
            // 
            this.n_width.Enabled = false;
            this.n_width.Location = new System.Drawing.Point(222, 62);
            this.n_width.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.n_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_width.Name = "n_width";
            this.n_width.Size = new System.Drawing.Size(56, 21);
            this.n_width.TabIndex = 8;
            this.n_width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // c_size
            // 
            this.c_size.FormattingEnabled = true;
            this.c_size.Items.AddRange(new object[] {
            "全部尺寸",
            "小型图片",
            "中型图片",
            "大型图片",
            "特大型图片"});
            this.c_size.Location = new System.Drawing.Point(80, 63);
            this.c_size.Name = "c_size";
            this.c_size.Size = new System.Drawing.Size(95, 20);
            this.c_size.TabIndex = 7;
            // 
            // c_type
            // 
            this.c_type.FormattingEnabled = true;
            this.c_type.Items.AddRange(new object[] {
            "全部类型",
            "头像图片",
            "面部特写",
            "卡通画",
            "简笔画",
            "动态图片",
            "静态图片"});
            this.c_type.Location = new System.Drawing.Point(239, 28);
            this.c_type.Name = "c_type";
            this.c_type.Size = new System.Drawing.Size(125, 20);
            this.c_type.TabIndex = 6;
            // 
            // c_color
            // 
            this.c_color.FormattingEnabled = true;
            this.c_color.Items.AddRange(new object[] {
            "全部颜色",
            "红色",
            "黄色",
            "绿色",
            "青色",
            "蓝色",
            "紫色",
            "粉色",
            "棕色",
            "橙色",
            "黑色",
            "白色",
            "黑白"});
            this.c_color.Location = new System.Drawing.Point(80, 28);
            this.c_color.Name = "c_color";
            this.c_color.Size = new System.Drawing.Size(95, 20);
            this.c_color.TabIndex = 5;
            this.c_color.SelectedIndexChanged += new System.EventHandler(this.c_color_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "高";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "图片类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "宽";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "图片尺寸";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "图片主色调";
            // 
            // t_logs
            // 
            this.t_logs.Location = new System.Drawing.Point(12, 232);
            this.t_logs.Multiline = true;
            this.t_logs.Name = "t_logs";
            this.t_logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.t_logs.Size = new System.Drawing.Size(381, 193);
            this.t_logs.TabIndex = 2;
            this.t_logs.TextChanged += new System.EventHandler(this.t_KeyWord2_TextChanged);
            // 
            // b_Clear
            // 
            this.b_Clear.Location = new System.Drawing.Point(12, 431);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(381, 23);
            this.b_Clear.TabIndex = 3;
            this.b_Clear.Text = "清空";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // BaiDuSprider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 466);
            this.Controls.Add(this.b_Clear);
            this.Controls.Add(this.t_logs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaiDuSprider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度图片爬虫";
            this.Load += new System.EventHandler(this.BaiDuSprider_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_page)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_neight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_SavePath;
        private System.Windows.Forms.TextBox t_KeyWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_logs;
        private System.Windows.Forms.Button btn_SelectPath;
        private System.Windows.Forms.NumericUpDown n_page;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.CheckBox c_manual;
        private System.Windows.Forms.NumericUpDown n_neight;
        private System.Windows.Forms.NumericUpDown n_width;
        private System.Windows.Forms.ComboBox c_size;
        private System.Windows.Forms.ComboBox c_type;
        private System.Windows.Forms.ComboBox c_color;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_Clear;
    }
}

