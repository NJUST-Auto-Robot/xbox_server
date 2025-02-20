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
            this.portinfo_combox = new System.Windows.Forms.ComboBox();
            this.baudrate_combox = new System.Windows.Forms.ComboBox();
            this.databit_combox = new System.Windows.Forms.ComboBox();
            this.parity_combox = new System.Windows.Forms.ComboBox();
            this.stopbit_combox = new System.Windows.Forms.ComboBox();
            this.serial_refresh_btn = new System.Windows.Forms.Button();
            this.serial_open_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.send_swicth = new ReaLTaiizor.Controls.MetroSwitch();
            this.foreverTabPage1 = new ReaLTaiizor.Controls.ForeverTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rightThumb_y_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rightThumb_x_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leftThumb_y_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.leftThumb_x_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.XBOXinfo = new System.Windows.Forms.Label();
            this.sendinfo_label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clearbuffer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.foreverTabPage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            // portinfo_combox
            // 
            this.portinfo_combox.FormattingEnabled = true;
            this.portinfo_combox.Location = new System.Drawing.Point(65, 4);
            this.portinfo_combox.Margin = new System.Windows.Forms.Padding(2);
            this.portinfo_combox.Name = "portinfo_combox";
            this.portinfo_combox.Size = new System.Drawing.Size(82, 20);
            this.portinfo_combox.TabIndex = 1;
            // 
            // baudrate_combox
            // 
            this.baudrate_combox.FormattingEnabled = true;
            this.baudrate_combox.Location = new System.Drawing.Point(65, 29);
            this.baudrate_combox.Margin = new System.Windows.Forms.Padding(2);
            this.baudrate_combox.Name = "baudrate_combox";
            this.baudrate_combox.Size = new System.Drawing.Size(82, 20);
            this.baudrate_combox.TabIndex = 2;
            // 
            // databit_combox
            // 
            this.databit_combox.FormattingEnabled = true;
            this.databit_combox.Location = new System.Drawing.Point(65, 53);
            this.databit_combox.Margin = new System.Windows.Forms.Padding(2);
            this.databit_combox.Name = "databit_combox";
            this.databit_combox.Size = new System.Drawing.Size(82, 20);
            this.databit_combox.TabIndex = 3;
            // 
            // parity_combox
            // 
            this.parity_combox.FormattingEnabled = true;
            this.parity_combox.Location = new System.Drawing.Point(65, 75);
            this.parity_combox.Margin = new System.Windows.Forms.Padding(2);
            this.parity_combox.Name = "parity_combox";
            this.parity_combox.Size = new System.Drawing.Size(82, 20);
            this.parity_combox.TabIndex = 4;
            // 
            // stopbit_combox
            // 
            this.stopbit_combox.FormattingEnabled = true;
            this.stopbit_combox.Location = new System.Drawing.Point(65, 99);
            this.stopbit_combox.Margin = new System.Windows.Forms.Padding(2);
            this.stopbit_combox.Name = "stopbit_combox";
            this.stopbit_combox.Size = new System.Drawing.Size(82, 20);
            this.stopbit_combox.TabIndex = 5;
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
            this.serial_refresh_btn.Click += new System.EventHandler(this.serial_refresh_btn_Click);
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
            this.serial_open_btn.Click += new System.EventHandler(this.serial_open_btn_Click);
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
            // send_swicth
            // 
            this.send_swicth.BackColor = System.Drawing.Color.Transparent;
            this.send_swicth.BackgroundColor = System.Drawing.Color.Empty;
            this.send_swicth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.send_swicth.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.send_swicth.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.send_swicth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_swicth.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.send_swicth.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.send_swicth.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.send_swicth.IsDerivedStyle = true;
            this.send_swicth.Location = new System.Drawing.Point(15, 285);
            this.send_swicth.Name = "send_swicth";
            this.send_swicth.Size = new System.Drawing.Size(58, 22);
            this.send_swicth.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.send_swicth.StyleManager = null;
            this.send_swicth.Switched = false;
            this.send_swicth.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.send_swicth.TabIndex = 14;
            this.send_swicth.Text = "metroSwitch1";
            this.send_swicth.ThemeAuthor = "Taiizor";
            this.send_swicth.ThemeName = "MetroLight";
            this.send_swicth.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.send_swicth.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.send_swicth_SwitchedChanged);
            // 
            // foreverTabPage1
            // 
            this.foreverTabPage1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverTabPage1.ActiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverTabPage1.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverTabPage1.Controls.Add(this.tabPage1);
            this.foreverTabPage1.Controls.Add(this.tabPage2);
            this.foreverTabPage1.Controls.Add(this.tabPage3);
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
            // XBOXinfo
            // 
            this.XBOXinfo.AutoSize = true;
            this.XBOXinfo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XBOXinfo.Location = new System.Drawing.Point(20, 242);
            this.XBOXinfo.Name = "XBOXinfo";
            this.XBOXinfo.Size = new System.Drawing.Size(104, 19);
            this.XBOXinfo.TabIndex = 17;
            this.XBOXinfo.Text = "手柄未连接";
            // 
            // sendinfo_label
            // 
            this.sendinfo_label.AutoSize = true;
            this.sendinfo_label.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendinfo_label.Location = new System.Drawing.Point(85, 288);
            this.sendinfo_label.Name = "sendinfo_label";
            this.sendinfo_label.Size = new System.Drawing.Size(63, 14);
            this.sendinfo_label.TabIndex = 18;
            this.sendinfo_label.Text = "发送关闭";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.clearbuffer);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(389, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "串口接收区";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(377, 236);
            this.textBox1.TabIndex = 0;
            // 
            // clearbuffer
            // 
            this.clearbuffer.Location = new System.Drawing.Point(6, 247);
            this.clearbuffer.Name = "clearbuffer";
            this.clearbuffer.Size = new System.Drawing.Size(106, 28);
            this.clearbuffer.TabIndex = 1;
            this.clearbuffer.Text = "清除接收区";
            this.clearbuffer.UseVisualStyleBackColor = true;
            this.clearbuffer.Click += new System.EventHandler(this.clearbuffer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 333);
            this.Controls.Add(this.sendinfo_label);
            this.Controls.Add(this.XBOXinfo);
            this.Controls.Add(this.foreverTabPage1);
            this.Controls.Add(this.send_swicth);
            this.Controls.Add(this.serial_open_btn);
            this.Controls.Add(this.serial_refresh_btn);
            this.Controls.Add(this.stopbit_combox);
            this.Controls.Add(this.parity_combox);
            this.Controls.Add(this.databit_combox);
            this.Controls.Add(this.baudrate_combox);
            this.Controls.Add(this.portinfo_combox);
            this.Controls.Add(this.serial_infos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.foreverTabPage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label serial_infos;
        private System.Windows.Forms.ComboBox portinfo_combox;
        private System.Windows.Forms.ComboBox baudrate_combox;
        private System.Windows.Forms.ComboBox databit_combox;
        private System.Windows.Forms.ComboBox parity_combox;
        private System.Windows.Forms.ComboBox stopbit_combox;
        private System.Windows.Forms.Button serial_refresh_btn;
        private System.Windows.Forms.Button serial_open_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MetroSwitch send_swicth;
        private ReaLTaiizor.Controls.ForeverTabPage foreverTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox leftThumb_x_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox leftThumb_y_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rightThumb_y_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rightThumb_x_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label XBOXinfo;
        private System.Windows.Forms.Label sendinfo_label;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clearbuffer;
    }
}

