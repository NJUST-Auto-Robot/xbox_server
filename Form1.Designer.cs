namespace xbox_server
{
    partial class Form1
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
            this.serial_infos = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.serial_refresh_btn = new System.Windows.Forms.Button();
            this.serial_open_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroSwitch1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.foreverTabPage1 = new ReaLTaiizor.Controls.ForeverTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.leftThumb_y_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.leftThumb_x_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.XBOXinfo = new ReaLTaiizor.Controls.FoxButton();
            this.rightThumb_y_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rightThumb_x_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.foreverTabPage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serial_infos
            // 
            this.serial_infos.AutoSize = true;
            this.serial_infos.Location = new System.Drawing.Point(8, 6);
            this.serial_infos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serial_infos.Name = "serial_infos";
            this.serial_infos.Size = new System.Drawing.Size(53, 108);
            this.serial_infos.TabIndex = 0;
            this.serial_infos.Text = "串口号：\r\n\r\n波特率：\r\n\r\n数据位：\r\n\r\n校验位：\r\n\r\n停止位:";
            this.serial_infos.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(65, 29);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(65, 53);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(82, 20);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(65, 75);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(82, 20);
            this.comboBox4.TabIndex = 4;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(65, 99);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(82, 20);
            this.comboBox5.TabIndex = 5;
            // 
            // serial_refresh_btn
            // 
            this.serial_refresh_btn.Location = new System.Drawing.Point(10, 131);
            this.serial_refresh_btn.Margin = new System.Windows.Forms.Padding(2);
            this.serial_refresh_btn.Name = "serial_refresh_btn";
            this.serial_refresh_btn.Size = new System.Drawing.Size(67, 21);
            this.serial_refresh_btn.TabIndex = 6;
            this.serial_refresh_btn.Text = "刷新串口";
            this.serial_refresh_btn.UseVisualStyleBackColor = true;
            // 
            // serial_open_btn
            // 
            this.serial_open_btn.Location = new System.Drawing.Point(81, 131);
            this.serial_open_btn.Margin = new System.Windows.Forms.Padding(2);
            this.serial_open_btn.Name = "serial_open_btn";
            this.serial_open_btn.Size = new System.Drawing.Size(65, 21);
            this.serial_open_btn.TabIndex = 7;
            this.serial_open_btn.Text = "打开串口";
            this.serial_open_btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::xbox_server.Properties.Resources.xbox;
            this.pictureBox1.Location = new System.Drawing.Point(75, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // metroSwitch1
            // 
            this.metroSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.metroSwitch1.BackgroundColor = System.Drawing.Color.Empty;
            this.metroSwitch1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.metroSwitch1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSwitch1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.metroSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSwitch1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSwitch1.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSwitch1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSwitch1.IsDerivedStyle = true;
            this.metroSwitch1.Location = new System.Drawing.Point(15, 285);
            this.metroSwitch1.Name = "metroSwitch1";
            this.metroSwitch1.Size = new System.Drawing.Size(58, 22);
            this.metroSwitch1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroSwitch1.StyleManager = null;
            this.metroSwitch1.Switched = false;
            this.metroSwitch1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.metroSwitch1.TabIndex = 14;
            this.metroSwitch1.Text = "metroSwitch1";
            this.metroSwitch1.ThemeAuthor = "Taiizor";
            this.metroSwitch1.ThemeName = "MetroLight";
            this.metroSwitch1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSwitch1.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.metroSwitch1_SwitchedChanged);
            // 
            // foreverTabPage1
            // 
            this.foreverTabPage1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverTabPage1.ActiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverTabPage1.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverTabPage1.Controls.Add(this.tabPage1);
            this.foreverTabPage1.Controls.Add(this.tabPage2);
            this.foreverTabPage1.DeactiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.foreverTabPage1.ItemSize = new System.Drawing.Size(100, 20);
            this.foreverTabPage1.Location = new System.Drawing.Point(168, 6);
            this.foreverTabPage1.Name = "foreverTabPage1";
            this.foreverTabPage1.SelectedIndex = 0;
            this.foreverTabPage1.Size = new System.Drawing.Size(397, 306);
            this.foreverTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.foreverTabPage1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.rightThumb_y_text);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rightThumb_x_text);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.leftThumb_y_text);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.leftThumb_x_text);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(389, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "手柄信息";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // leftThumb_y_text
            // 
            this.leftThumb_y_text.Location = new System.Drawing.Point(38, 157);
            this.leftThumb_y_text.Name = "leftThumb_y_text";
            this.leftThumb_y_text.Size = new System.Drawing.Size(48, 25);
            this.leftThumb_y_text.TabIndex = 3;
            this.leftThumb_y_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // leftThumb_x_text
            // 
            this.leftThumb_x_text.Location = new System.Drawing.Point(38, 126);
            this.leftThumb_x_text.Name = "leftThumb_x_text";
            this.leftThumb_x_text.Size = new System.Drawing.Size(48, 25);
            this.leftThumb_x_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(389, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "协议帧";
            // 
            // foxLabel1
            // 
            this.foxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(82, 288);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(65, 19);
            this.foxLabel1.TabIndex = 16;
            this.foxLabel1.Text = "发送关闭";
            // 
            // XBOXinfo
            // 
            this.XBOXinfo.BackColor = System.Drawing.Color.Red;
            this.XBOXinfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.XBOXinfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.XBOXinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XBOXinfo.DisabledBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.XBOXinfo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.XBOXinfo.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.XBOXinfo.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.XBOXinfo.EnabledCalc = true;
            this.XBOXinfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.XBOXinfo.ForeColor = System.Drawing.Color.Black;
            this.XBOXinfo.Location = new System.Drawing.Point(12, 238);
            this.XBOXinfo.Name = "XBOXinfo";
            this.XBOXinfo.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.XBOXinfo.Size = new System.Drawing.Size(134, 30);
            this.XBOXinfo.TabIndex = 17;
            this.XBOXinfo.Text = "XBOX未连接";
            this.XBOXinfo.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.foxButton1_Click);
            // 
            // rightThumb_y_text
            // 
            this.rightThumb_y_text.Location = new System.Drawing.Point(296, 157);
            this.rightThumb_y_text.Name = "rightThumb_y_text";
            this.rightThumb_y_text.Size = new System.Drawing.Size(48, 25);
            this.rightThumb_y_text.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(273, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Y";
            // 
            // rightThumb_x_text
            // 
            this.rightThumb_x_text.Location = new System.Drawing.Point(296, 126);
            this.rightThumb_x_text.Name = "rightThumb_x_text";
            this.rightThumb_x_text.Size = new System.Drawing.Size(48, 25);
            this.rightThumb_x_text.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(273, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 333);
            this.Controls.Add(this.XBOXinfo);
            this.Controls.Add(this.foxLabel1);
            this.Controls.Add(this.foreverTabPage1);
            this.Controls.Add(this.metroSwitch1);
            this.Controls.Add(this.serial_open_btn);
            this.Controls.Add(this.serial_refresh_btn);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.serial_infos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.foreverTabPage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label serial_infos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button serial_refresh_btn;
        private System.Windows.Forms.Button serial_open_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MetroSwitch metroSwitch1;
        private ReaLTaiizor.Controls.ForeverTabPage foreverTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.FoxButton XBOXinfo;
        private System.Windows.Forms.TextBox leftThumb_x_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox leftThumb_y_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rightThumb_y_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rightThumb_x_text;
        private System.Windows.Forms.Label label4;
    }
}

