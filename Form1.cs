using System;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

//外部库引用

//用户库引用
using xbox_server.MyXBOX;
using xbox_server.SerialPorts;


namespace xbox_server
{
    public partial class Form1 : Form
    {
        Thread threadA;
        Thread thread_Paint;
        System.Threading.Timer Timer1;
        System.Threading.Timer timer_serial_send;

        XboxDataFrame xbox_data_frame = new XboxDataFrame();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //开启双缓冲

            this.FormClosing += new FormClosingEventHandler(Form1_Closing);
            tabPage1.Paint += TabPage1_Paint;//重绘控件的回调

            //串口接收回调绑定
            serialport.Instance.OnDataReceived = serial_received_callback;

            {
                //初始化串口列表
                string[] portnames = serialport.Instance.ScanPorts();
                foreach (string portname in portnames)
                {
                    portinfo_combox.Items.Add(portname);
                }
                // 设置波特率
                int[] baudRates = { 115200, 9600, 19200, 38400, 57600 };
                foreach (int rate in baudRates)
                {
                    baudrate_combox.Items.Add(rate);
                }
                // 设置奇偶校验位
                Parity[] paritys = { Parity.None, Parity.Odd, Parity.Even };
                foreach (Parity parity in paritys)
                {
                    parity_combox.Items.Add(parity);
                }
                // 设置停止位
                StopBits[] stopBits = { StopBits.One, StopBits.OnePointFive, StopBits.Two };
                foreach (StopBits bits in stopBits)
                {
                    stopbit_combox.Items.Add(bits);
                }

                // 设置数据位
                int[] dataBits = { 5, 6, 7, 8 };
                foreach (int bits in dataBits)
                {
                    databit_combox.Items.Add(bits);
                }
                // 选择默认值
                if (portinfo_combox.Items.Count > 0)
                {
                    portinfo_combox.SelectedIndex = 0; // 第一个可用的串口
                                                       //portinfo.Text = ports[0].ToString();
                }
                baudrate_combox.SelectedItem = 115200;  // 默认波特率
                stopbit_combox.SelectedItem = StopBits.One; // 默认停止位
                parity_combox.SelectedItem = Parity.None;   //默认校验位
                databit_combox.SelectedItem = 8;     // 默认数据位
            }


            XInputController.Instance.CheckXbox();

            threadA = new Thread(Xbox_test);
            threadA.Start();

            //thread_Paint = new Thread(thread_Paint_entry);
            //thread_Paint.Start();

            Timer1 = new System.Threading.Timer(Timer1Callback, null, 1000, 10);
            timer_serial_send = new System.Threading.Timer(timer_serial_send_callback, null, 0, 10);

        }
        public void Timer1Callback(object state) // 入参对象为 Timer 对象
        {
            tabPage1.Invalidate();

        }

        //窗体关闭事件回调
        public void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            threadA.Abort();
            //thread_Paint.Abort();
            Timer1.Dispose();
            timer_serial_send.Dispose();
        }

        public void TabPage1_Paint(object sender, PaintEventArgs e)
        {
            // 获取 Graphics 对象
            Graphics g = e.Graphics;

            // 定义画笔
            using (Pen pen = new Pen(Color.Yellow, 3)) // 黄色，宽度为 3
            {
                // 画虚拟外框
                g.DrawEllipse(pen, 50, 20, 100, 100);
                g.DrawEllipse(pen, 230, 20, 100, 100);
            }

            // 定义画刷
            using (Brush brush = new SolidBrush(Color.White))
            {
                // 画实心圆
                //g.FillEllipse(brush, 100, 100, 10, 10);

                // 画实心圆
                g.FillEllipse(brush, XInputController.Instance.leftThumb_x / 2 + 100,
                             -XInputController.Instance.leftThumb_y / 2 + 70, 7, 7);

                // 画实心圆
                g.FillEllipse(brush, XInputController.Instance.rightThumb_x / 2 + 280,
                             -XInputController.Instance.rightThumb_y / 2 + 70, 7, 7);
            }
        }

        public void Xbox_test()
        {
            while (true)
            {

                Action action_ = () =>
                {
                    XBOXinfo.Text = "手柄未连接";
                    XInputController.Instance.CheckXbox();

                    leftThumb_x_text.Clear();
                    leftThumb_y_text.Clear();
                    rightThumb_x_text.Clear();
                    rightThumb_y_text.Clear();
                };

                Action action = () =>
                {
                    XBOXinfo.Text = "手柄已连接";
                    XInputController.Instance.Update();

                    leftThumb_x_text.Text = (XInputController.Instance.leftThumb_x).ToString();
                    leftThumb_y_text.Text = (XInputController.Instance.leftThumb_y).ToString();
                    rightThumb_x_text.Text = (XInputController.Instance.rightThumb_x).ToString();
                    rightThumb_y_text.Text = (XInputController.Instance.rightThumb_y).ToString();


                };

                if (this.IsHandleCreated && true == XInputController.Instance.CheckXbox())
                    Invoke(action);
                else if (this.IsHandleCreated && true != XInputController.Instance.CheckXbox())
                    Invoke(action_);
            }
        }

        public void timer_serial_send_callback(object state)
        {
            Action action = () =>
            {
                if (send_swicth.Switched == true)
                {
                    sendinfo_label.Text = "发送开启";

                    xbox_data_frame.leftThumb_x = (short)(XInputController.Instance.leftThumb_x);
                    xbox_data_frame.leftThumb_y = (short)(XInputController.Instance.leftThumb_y);
                    xbox_data_frame.rightThumb_x = (short)(XInputController.Instance.rightThumb_x);
                    xbox_data_frame.rightThumb_y = (short)(XInputController.Instance.rightThumb_y);
                    xbox_data_frame.leftTrigger = XInputController.Instance.leftTrigger;
                    xbox_data_frame.rightTrigger = XInputController.Instance.rightTrigger;
                    xbox_data_frame.buttons = XInputController.Instance.buttons;

                    xbox_data_frame.ddr16 = (ushort)(xbox_data_frame.Head1 +
                                                    xbox_data_frame.Head2 +
                                                    xbox_data_frame.leftThumb_x +
                                                    xbox_data_frame.leftThumb_y +
                                                    xbox_data_frame.rightThumb_x +
                                                    xbox_data_frame.rightThumb_y +
                                                    xbox_data_frame.leftTrigger +
                                                    xbox_data_frame.rightTrigger +
                                                    xbox_data_frame.buttons);

                    if (send_mode_button.Text == "大端发送")
                    {
                        byte[] dataToSend = xbox_data_frame.ToByteArray_B();
                        serialport.Instance.SendData(dataToSend);
                    }
                    else if (send_mode_button.Text == "小端发送")
                    {
                        byte[] dataToSend = xbox_data_frame.ToByteArray_S();
                        serialport.Instance.SendData(dataToSend);
                    }
                }
                else
                {
                    sendinfo_label.Text = "发送关闭";
                }
            };
            if (this.IsHandleCreated)
                Invoke(action);
        }

        public void serial_received_callback(byte[] data)
        {
            Action action = () =>
            {
                string hexOutput = BitConverter.ToString(data).Replace("-", "");
                textBox1.AppendText(hexOutput + "\r\n");
            };
            if (this.IsHandleCreated)
                Invoke(action);
        }

        private void send_swicth_SwitchedChanged(object sender)
        {

        }


        private void serial_refresh_btn_Click(object sender, EventArgs e)
        {
            portinfo_combox.Items.Clear();
            string[] portnames = serialport.Instance.ScanPorts();
            foreach (string portname in portnames)
            {
                portinfo_combox.Items.Add(portname);
            }
        }

        private void serial_open_btn_Click(object sender, EventArgs e)
        {
            Action action = () =>
            {
                portinfo_combox.Items.Clear();
                string[] portnames = serialport.Instance.ScanPorts();
                foreach (string portname in portnames)
                {
                    portinfo_combox.Items.Add(portname);
                }
                string _portname = portinfo_combox.Text;

                if ("打开串口" == serial_open_btn.Text)
                {
                    try
                    {
                        if (true == serialport.Instance.OpenSerialPort(_portname, 115200, Parity.None, 8, StopBits.One))
                        {
                            serial_open_btn.Text = (String)("关闭串口");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("OpenError", "SoftError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if ("关闭串口" == serial_open_btn.Text)
                {
                    try
                    {
                        serialport.Instance.CloseSerialPort();
                    }
                    catch (Exception)
                    {

                    }
                    serial_open_btn.Text = (String)("打开串口");
                }
            };
            Invoke(action);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void foxButton1_Click(object sender, EventArgs e)
        {


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearbuffer_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void send_mode_button_Click(object sender, EventArgs e)
        {
            if (send_mode_button.Text == "大端发送")
            {
                send_mode_button.Text = "小端发送";
            }
            else
            {
                send_mode_button.Text = "大端发送";
            }
        }
    }
}
