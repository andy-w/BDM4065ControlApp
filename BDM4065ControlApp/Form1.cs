namespace BDM4065ControlApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO.Ports;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Net;
    using System.Net.Sockets;

    public partial class Form1 : Form
    {
        private byte[] msgHeader = new byte[] { 0xA6, 0x01, 0x00, 0x00, 0x00 };

        private SerialPort comPort = new SerialPort("COM1");

        private TcpListener server;

        private Thread serverThread;

        private PowerState powerState = PowerState.Off;
        private InputSourceNumber currentSource = InputSourceNumber.VGA;
        private byte screenBrightness = 0;
        private byte screenContrast = 0;
        private byte screenSharpness = 0;
        private PictureFormat pictureFormat;
        private byte volume = 0;

        public Form1()
        {
            this.InitializeComponent();

            serverThread = new Thread(new ThreadStart(StartServer));

            serverThread.Start();

            var timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(this.RefreshTick);
            timer.Interval = 10000; // 10 seconds
            timer.Start();

            foreach (PictureFormat format in Enum.GetValues(typeof(PictureFormat)))
            {
                PictureFormatComboBox.Items.Add(format);
            }

            this.comPort.BaudRate = 9600;
            this.comPort.DataBits = 8;
            this.comPort.Parity = Parity.None;
            this.comPort.StopBits = StopBits.One;
            this.comPort.Handshake = Handshake.None;
            this.comPort.ReadTimeout = 100;
        }

        private void StartServer()
        {
            IPAddress localAddr = GetLocalIPAddress();

            this.server = new TcpListener(localAddr, 11000);

            this.server.Start();

            while (true)
            {
                Socket socket = this.server.AcceptSocket();

                if (socket.Connected)
                {
                }
            }
        }

        private enum MessageSet : byte
        {
            PowerStateSet = 0x18,
            PowerStateGet = 0x19,
            VideoParametersSet = 0x32,
            VideoParametersGet = 0x33,
            PictureFormatSet = 0x3A,
            PictureFormatGet = 0x3B,
            PictureInPictureSet = 0x3C,
            VolumeSet = 0x44,
            VolumeGet = 0x45,
            PictureInPictureSourceGet = 0x85,
            InputSourceSet = 0xAC,
            CurrentSourceGet = 0xAD,
        }

        private enum PowerState : byte
        {
            Off = 0x01,
            On = 0x02,
        }

        private enum PIP_Position : byte
        {
            BottomLeft = 0x00,
            TopLeft = 0x01,
            TopRight = 0x02,
            BottomRight = 0x03
        }

        private enum InputSourceType : byte
        {
            Video = 0x01,
            SVideo = 0x02,
            DVDHD = 0x03,
            RGBHV = 0x04,
            VGA = 0x05,
            HDMI = 0x06,
            DVI = 0x07,
            CardOPS = 0x08,
            DisplayPort = 0x09
        }

        private enum InputSourceNumber : byte
        {
            VGA = 0x00,
            DVI = 0x01,
            HDMI = 0x02,
            MHLHDMI2 = 0x03,
            DP = 0x04,
            miniDP = 0x05,
        }

        private enum PictureFormat
        {
            FULL = 0x00,
            NORMAL = 0x01,
            DYNAMIC = 0x02,
            CUSTOM = 0x03,
            REAL = 0x04,
        }

        private void RefreshTick(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            byte[] msgSet_PiP_On_BL = new byte[] { 0x07, 0x01, (byte)MessageSet.PictureInPictureSet, 0x01, (byte)PIP_Position.BottomRight, 0x00, 0x00, 0x00 };
            byte[] msgSet_PiP_Off = new byte[] { 0x07, 0x01, (byte)MessageSet.PictureInPictureSet, 0x00, 0x03, 0x00, 0x00, 0x00 };
            byte[] response = new byte[255];
        }

        private int SendMessage(byte[] msgData, out byte[] msgReport)
        {
            msgReport = null;

            byte[] msg = new byte[this.msgHeader.Length + msgData.Length];

            System.Buffer.BlockCopy(this.msgHeader, 0, msg, 0, this.msgHeader.Length);

            System.Buffer.BlockCopy(msgData, 0, msg, this.msgHeader.Length, msgData.Length);

            msg[msg.Length - 1] = this.CheckSum(msg);

            try
            {
                this.comPort.Open();

                this.comPort.Write(msg, 0, msg.Length);

                Thread.Sleep(250);

                if (this.comPort.BytesToRead > 0)
                {
                    byte[] responseMsg = new byte[this.comPort.BytesToRead];

                    this.comPort.Read(responseMsg, 0, this.comPort.BytesToRead);

                    if (this.CheckSum(responseMsg) == responseMsg[responseMsg.Length - 1])
                    {
                        msgReport = new byte[responseMsg[4] - 2];

                        System.Buffer.BlockCopy(responseMsg, 6, msgReport, 0, responseMsg[4] - 2);

                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 2;
                }
            }
            finally
            {
                this.comPort.Close();
            }
        }

        private byte CheckSum(byte[] msg)
        {
            byte hashValue = 0;

            for (int i = 0; i < msg.Length - 1; i++)
            {
                hashValue ^= msg[i];
            }

            return hashValue;
        }

        private void InputSourceHDMIButton_Click(object sender, EventArgs e)
        {
            this.SetInputSource(InputSourceNumber.HDMI);
        }

        private void InputSourceDPButton_Click(object sender, EventArgs e)
        {
            this.SetInputSource(InputSourceNumber.DP);
        }

        private int SetInputSource(InputSourceNumber sourceNumber)
        {
            byte[] msgData = new byte[] 
            { 
                0x07, 
                0x01, 
                (byte)MessageSet.InputSourceSet, 
                (byte)InputSourceType.DisplayPort, 
                (byte)sourceNumber, 
                0x01, 
                0x00, 
                0x00
            };

            byte[] responseData;

            if (this.SendMessage(msgData, out responseData) == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private int GetCurrentSource()
        {
            byte[] msgData = new byte[] 
            { 
                0x03, 
                0x01, 
                (byte)MessageSet.CurrentSourceGet, 
                0x00
            };

            byte[] msgReport;

            if (this.SendMessage(msgData, out msgReport) == 0)
            {
                this.currentSource = (InputSourceNumber)msgReport[2];

                return 0;
            }
            else
            {
                return 1;
            }
        }

        private int GetVolume()
        {
            byte[] msgData = new byte[] 
            { 
                0x03, 
                0x01, 
                (byte)MessageSet.VolumeGet, 
                0x00
            };

            byte[] msgReport;

            if (this.SendMessage(msgData, out msgReport) == 0)
            {
                this.volume = msgReport[1];

                return 0;
            }
            else
            {
                return 1;
            }
        }

        private int GetPowerState()
        {
            byte[] msgData = new byte[] 
            { 
                0x03, 
                0x01, 
                (byte)MessageSet.PowerStateGet, 
                0x00
            };

            byte[] msgReport;

            if (this.SendMessage(msgData, out msgReport) == 0)
            {
                this.powerState = (PowerState)msgReport[1];

                return 0;
            }
            else
            {
                return 1;
            }
        }

        private int GetVideoParameters()
        {
            byte[] msgData = new byte[] 
            { 
                0x03, 
                0x01, 
                (byte)MessageSet.VideoParametersGet, 
                0x00
            };

            byte[] msgReport;

            if (this.SendMessage(msgData, out msgReport) == 0)
            {
                if (msgReport[0] == (byte)MessageSet.VideoParametersGet)
                {
                    this.screenBrightness = msgReport[1];
                    this.screenContrast = msgReport[3];
                    this.screenSharpness = msgReport[5];

                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }

        private int GetPictureFormat()
        {
            byte[] msgData = new byte[] 
            { 
                0x03, 
                0x01, 
                (byte)MessageSet.PictureFormatGet, 
                0x00
            };

            byte[] msgReport;

            if (this.SendMessage(msgData, out msgReport) == 0)
            {
                this.pictureFormat = (PictureFormat)(msgReport[1] & 0x03);

                return 0;
            }
            else
            {
                return 1;
            }
        }

        private InputSourceNumber GetPiPSource()
        {
            byte[] msgData = new byte[] 
            { 
                0x03, 
                0x01, 
                (byte)MessageSet.PictureInPictureSourceGet, 
                0x00
            };

            byte[] msgReport;

            if (this.SendMessage(msgData, out msgReport) == 0)
            {
                if (msgReport[0] == (byte)MessageSet.PictureInPictureSourceGet)
                {
                    return (InputSourceNumber)msgReport[2];
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void RefreshData()
        {
            PowerStateGroupBox.Enabled = this.GetPowerState() == 0;

            PowerStateOffButton.Enabled = this.powerState != PowerState.Off;
            PowerStateOnButton.Enabled = this.powerState != PowerState.On;

            CurrentSourceGroupBox.Enabled = this.GetCurrentSource() == 0;

            InputSourceVGAButton.Enabled = this.currentSource != InputSourceNumber.VGA;
            InputSourceDVIButton.Enabled = this.currentSource != InputSourceNumber.DVI;
            InputSourceHDMIButton.Enabled = this.currentSource != InputSourceNumber.HDMI;
            InputSourceHDMI2Button.Enabled = this.currentSource != InputSourceNumber.MHLHDMI2;
            InputSourceDPButton.Enabled = this.currentSource != InputSourceNumber.DP;
            InputSourcemDPButton.Enabled = this.currentSource != InputSourceNumber.miniDP;

            VideoParametersGroupBox.Enabled = this.GetVideoParameters() == 0;

            BrightnessUpDown.Value = this.screenBrightness;
            ContrastUpDown.Value = this.screenContrast;
            SharpnessUpDown.Value = this.screenSharpness;

            VolumeGroupBox.Enabled = this.GetVolume() == 0;

            VolumeUpDown.Value =  this.volume;

            PictureFormatGroupBox.Enabled = this.GetPictureFormat() == 0;
            
            PictureFormatComboBox.SelectedItem = this.pictureFormat;

            this.GetPiPSource();
        }

        private void InputSourceVGAButton_Click(object sender, EventArgs e)
        {
            this.SetInputSource(InputSourceNumber.VGA);
        }

        private void InputSourceDVIButton_Click(object sender, EventArgs e)
        {
            this.SetInputSource(InputSourceNumber.DVI);
        }

        private void InputSourceHDMI2Button_Click(object sender, EventArgs e)
        {
            this.SetInputSource(InputSourceNumber.MHLHDMI2);
        }

        private void InputSourcemDPButton_Click(object sender, EventArgs e)
        {
            this.SetInputSource(InputSourceNumber.miniDP);
        }

        private void PowerStateOffButton_Click(object sender, EventArgs e)
        {
            PowerStateOffButton.Enabled = false;

            this.SetPowerState(PowerState.Off);
        }

        private void PowerStateOnButton_Click(object sender, EventArgs e)
        {
            PowerStateOnButton.Enabled = false;

            this.SetPowerState(PowerState.On);
        }

        private int SetPowerState(PowerState powerState)
        {
            byte[] msgData = new byte[] 
            { 
                0x04, 
                0x01, 
                (byte)MessageSet.PowerStateSet, 
                (byte)powerState, 
                0x00
            };

            byte[] responseData;

            if (this.SendMessage(msgData, out responseData) == 0)
            {
                Thread.Sleep(250);

                return 0;
            }
            else
            {
                return 1;
            }
        }

        private int SetPictureFormat(PictureFormat pictureFormat)
        {
            byte[] msgData = new byte[] 
            { 
                0x04, 
                0x01, 
                (byte)MessageSet.PictureFormatSet, 
                (byte)pictureFormat, 
                0x00
            };

            byte[] responseData;

            if (this.SendMessage(msgData, out responseData) == 0)
            {
                Thread.Sleep(250);

                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void PictureFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetPictureFormat((PictureFormat)this.PictureFormatComboBox.SelectedItem);
        }

        private static IPAddress GetLocalIPAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        private void VolumeResetButton_Click(object sender, EventArgs e)
        {
            SetVolume(50);
        }

        private int SetVolume(byte volume)
        {
            byte[] msgData = new byte[] 
            { 
                0x04, 
                0x01, 
                (byte)MessageSet.VolumeSet, 
                volume, 
                0x00
            };

            byte[] responseData;

            if (this.SendMessage(msgData, out responseData) == 0)
            {
                Thread.Sleep(250);

                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void VolumeUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetVolume((byte)VolumeUpDown.Value);
        }
    }
}
