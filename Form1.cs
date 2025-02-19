using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

//外部库引用

//用户库引用
using xbox_server.MyXBOX;


namespace xbox_server
{
    public partial class Form1 : Form
    {
        Thread threadA;
        Thread thread_Paint;
        System.Threading.Timer Timer1;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //开启双缓冲

            this.FormClosing += new FormClosingEventHandler(Form1_Closing);
            tabPage1.Paint += TabPage1_Paint;//重绘控件的回调

            XInputController.Instance.CheckXbox();

            threadA = new Thread(Xbox_test);
            threadA.Start();

            //thread_Paint = new Thread(thread_Paint_entry);
            //thread_Paint.Start();

            Timer1 = new System.Threading.Timer(Timer1Callback, null, 1000, 10);

        }
        public void Timer1Callback(object state) // 入参对象为 Timer 对象
        {
            tabPage1.Invalidate();

            //Timer t = (Timer)state;
            //t.Dispose(); // 调用一次就释放掉，或者添加条件释放
            //Console.WriteLine("The timer callback executes.");

        }

        //窗体关闭事件回调
        public void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            threadA.Abort();
            //thread_Paint.Abort();
            Timer1.Dispose();
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
                else if(this.IsHandleCreated && true != XInputController.Instance.CheckXbox())
                    Invoke(action_);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void metroSwitch1_SwitchedChanged(object sender)
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
    }
}
