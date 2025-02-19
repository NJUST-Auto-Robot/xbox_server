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
            this.button2 = new ReaLTaiizor.Controls.Button();
            this.dungeonTabPage1 = new ReaLTaiizor.Controls.DungeonTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.circleProgressBar1 = new ReaLTaiizor.Controls.CircleProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.metroSwitch1 = new ReaLTaiizor.Controls.MetroSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dungeonTabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.pictureBox1.Location = new System.Drawing.Point(206, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Image = null;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.Location = new System.Drawing.Point(10, 202);
            this.button2.Name = "button2";
            this.button2.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.Size = new System.Drawing.Size(67, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dungeonTabPage1
            // 
            this.dungeonTabPage1.ActivePageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dungeonTabPage1.ActivePageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(198)))), ((int)(((byte)(195)))));
            this.dungeonTabPage1.ActivePageTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.dungeonTabPage1.BaseColor = System.Drawing.Color.Transparent;
            this.dungeonTabPage1.Controls.Add(this.tabPage1);
            this.dungeonTabPage1.Controls.Add(this.tabPage2);
            this.dungeonTabPage1.DeactivePageTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.dungeonTabPage1.ItemSize = new System.Drawing.Size(80, 24);
            this.dungeonTabPage1.Location = new System.Drawing.Point(171, 6);
            this.dungeonTabPage1.Name = "dungeonTabPage1";
            this.dungeonTabPage1.PageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dungeonTabPage1.PageEdgeBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(198)))), ((int)(((byte)(195)))));
            this.dungeonTabPage1.PageEdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dungeonTabPage1.SelectedIndex = 0;
            this.dungeonTabPage1.Size = new System.Drawing.Size(394, 316);
            this.dungeonTabPage1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.circleProgressBar1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(386, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(83, 202);
            this.button1.Name = "button1";
            this.button1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(67, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // circleProgressBar1
            // 
            this.circleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.circleProgressBar1.Location = new System.Drawing.Point(16, 41);
            this.circleProgressBar1.Maximum = ((long)(100));
            this.circleProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.circleProgressBar1.Name = "circleProgressBar1";
            this.circleProgressBar1.PercentColor = System.Drawing.Color.White;
            this.circleProgressBar1.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.circleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.circleProgressBar1.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            this.circleProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.circleProgressBar1.TabIndex = 9;
            this.circleProgressBar1.Text = "circleProgressBar1";
            this.circleProgressBar1.Value = ((long)(0));
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(64, 193);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 11;
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
            this.metroSwitch1.Location = new System.Drawing.Point(15, 290);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 333);
            this.Controls.Add(this.metroSwitch1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dungeonTabPage1);
            this.Controls.Add(this.button2);
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
            this.dungeonTabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.DungeonTabPage dungeonTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private ReaLTaiizor.Controls.CircleProgressBar circleProgressBar1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.MetroSwitch metroSwitch1;
    }
}

