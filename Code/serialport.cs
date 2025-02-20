
using System.Collections.Generic;
using System;
using System.IO.Ports;

namespace xbox_server.SerialPorts
{
    public class serialport
    {
        private SerialPort sp;
        public byte[] received_data = new byte[1024];

        //用户定义委托
        public delegate void Dataprocess(byte[] data);
        public Dataprocess OnDataReceived;

        private static serialport _instance;
        //构建函数
        private serialport()
        {
            sp = new SerialPort();
            sp.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
        }

        public static serialport Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new serialport();
                }
                return _instance;
            }
        }

        //扫描所有串口号
        public string[] ScanPorts()
        {
            string[] portList = SerialPort.GetPortNames();
            return portList;
        }

        public bool ISopen()
        {
            if (sp == null)
                return false;
            else
            {
                if (sp.IsOpen)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="_portName">端口号</param>
        /// <param name="_baudRate">波特率</param>
        /// <param name="_parity">校验位</param>
        /// <param name="dataBits">数据位</param>
        /// <param name="_stopbits">停止位</param>
        public bool OpenSerialPort(string _portName, int _baudRate, Parity _parity, int dataBits, StopBits _stopbits)
        {
            sp.PortName = _portName;
            sp.BaudRate = _baudRate;
            sp.Parity = _parity;
            sp.DataBits = dataBits;
            sp.StopBits = _stopbits;

            if (!sp.IsOpen)
            {
                sp.Open();
            }

            if (sp.IsOpen) { return true; }
            else { return false; }
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        public void CloseSerialPort()
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
        }


        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="_info">string数据</param>
        public void SendData(byte[] _info)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Write(_info, 0, _info.Length);
                }
            }
            catch (Exception)
            {

            }
        }


        /// <summary>
        /// 接收数据 回调函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[sp.BytesToRead];
            sp.Read(ReDatas, 0, ReDatas.Length);//读取数据

            received_data = ReDatas;

            OnDataReceived(ReDatas);

            string hexOutput = BitConverter.ToString(received_data).Replace("-", "");
            Console.WriteLine(hexOutput);

        }

    }


    //发送数据帧定义
    public class XboxDataFrame
    {
        public enum GamepadButtonFlags : ushort
        {
            None = 0,
            DPadUp = 1,
            DPadDown = 2,
            DPadLeft = 4,
            DPadRight = 8,
            Start = 0x10,
            Back = 0x20,
            LeftThumb = 0x40,
            RightThumb = 0x80,
            LeftShoulder = 0x100,
            RightShoulder = 0x200,
            A = 0x1000,
            B = 0x2000,
            X = 0x4000,
            Y = 0x8000
        }

        public ushort Head { get; set; } = 0xFB7A;
        public short leftThumb_x { get; set; }
        public short leftThumb_y { get; set; }
        public short rightThumb_x { get; set; }
        public short rightThumb_y { get; set; }
        public byte leftTrigger { get; set; }
        public byte rightTrigger { get; set; }
        public ushort buttons { get; set; }
        public ushort ddr16 { get; set; }

        // 将数据帧转换为字节数组
        public byte[] ToByteArray()
        {
            List<byte> byteList = new List<byte>();

            // 添加数据到数组
            byteList.AddRange(BitConverter.GetBytes(Head));
            byteList.AddRange(BitConverter.GetBytes(leftThumb_x));
            byteList.AddRange(BitConverter.GetBytes(leftThumb_y));
            byteList.AddRange(BitConverter.GetBytes(rightThumb_x));
            byteList.AddRange(BitConverter.GetBytes(rightThumb_y));
            byteList.AddRange(BitConverter.GetBytes(leftTrigger));
            byteList.AddRange(BitConverter.GetBytes(rightTrigger));
            byteList.AddRange(BitConverter.GetBytes(buttons));
            byteList.AddRange(BitConverter.GetBytes(ddr16));
            
            return byteList.ToArray();
        }
    }
}