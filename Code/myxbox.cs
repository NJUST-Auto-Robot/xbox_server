using System;
using System.Drawing;
using SharpDX.XInput;

namespace xbox_server.MyXBOX
{
    public class XInputController
    {
        private static XInputController _instance;

        Controller controller;
        Gamepad gamepad;
        public bool connected = false;
        public int deadband = 2500;
        public float leftThumb_x, leftThumb_y, rightThumb_x, rightThumb_y;
        public float leftTrigger, rightTrigger;

        //构建函数
        private XInputController()
        {
            //_instance = this;
            controller = new Controller(UserIndex.One);
            connected = CheckXbox();
        }

        //完全线程不安全单例获取
        //public static XInputController Instance { get { return _instance; } }
        public static XInputController Instance
        {
            get
            {
                if( _instance == null )
                    _instance = new XInputController();
                return _instance;
            }
        }

        public bool CheckXbox()
        {
            connected = controller.IsConnected;
            return connected;
        }

        public void Update()
        {
            if (!connected)
                return;

            gamepad = controller.GetState().Gamepad;

            leftThumb_x = (Math.Abs((float)gamepad.LeftThumbX) < deadband) ? 0 : (float)gamepad.LeftThumbX / short.MinValue * -100;
            leftThumb_y = (Math.Abs((float)gamepad.LeftThumbY) < deadband) ? 0 : (float)gamepad.LeftThumbY / short.MaxValue * 100;
            rightThumb_x = (Math.Abs((float)gamepad.RightThumbX) < deadband) ? 0 : (float)gamepad.RightThumbX / short.MaxValue * 100;
            rightThumb_y = (Math.Abs((float)gamepad.RightThumbY) < deadband) ? 0 : (float)gamepad.RightThumbY / short.MaxValue * 100;

            leftTrigger = gamepad.LeftTrigger;
            rightTrigger = gamepad.RightTrigger;
        }

    }
}
