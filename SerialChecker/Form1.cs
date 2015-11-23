using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace SerialChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //! 利用可能なシリアルポート名の配列を取得する.
            string[] PortList = SerialPort.GetPortNames();

            comboBox1.Items.Clear();

            //! シリアルポート名をコンボボックスにセットする.
            foreach (string PortName in PortList)
            {
                comboBox1.Items.Add(PortName);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            IDList = new System.Windows.Forms.Label[10];
            StatusList = new System.Windows.Forms.Label[10];
            TTmpList = new System.Windows.Forms.Label[10];
            VTmpList = new System.Windows.Forms.Label[10];
            IDList[1] = ID1;
            IDList[2] = ID2;
            IDList[3] = ID3;
            StatusList[1] = status1;
            StatusList[2] = status2;
            StatusList[3] = status3;
            TTmpList[1] = temp1;
            TTmpList[2] = temp2;
            TTmpList[3] = temp3;
            VTmpList[1] = Vtmp1;
            VTmpList[2] = Vtmp2;
            VTmpList[3] = Vtmp3;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //! シリアルポートをオープンしている場合、クローズする.
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
        System.Timers.Timer timer;
        private void connectButton_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                //! シリアルポートをクローズする.
                serialPort1.Dispose();
                serialPort1.Close();
                timer.Close();

                //! ボタンの表示を[切断]から[接続]に変える.
                Connect.Text = "接続";
            }
            else
            {
                //タイマー設定処理
                timer = new System.Timers.Timer();
                timer.Elapsed += new ElapsedEventHandler(OnElapsed_TimersTimer);
                timer.Start();
                timer.Interval = 1000;
                //! オープンするシリアルポートをコンボボックスから取り出す.
                serialPort1.PortName = comboBox1.SelectedItem.ToString();

                //! ボーレートをコンボボックスから取り出す.
                serialPort1.BaudRate = 9600;

                //! データビットをセットする. (データビット = 8ビット)
                serialPort1.DataBits = 8;

                //! パリティビットをセットする. (パリティビット = なし)
                serialPort1.Parity = Parity.None;

                //! ストップビットをセットする. (ストップビット = 1ビット)
                serialPort1.StopBits = StopBits.One;

                //! フロー制御をコンボボックスから取り出す.
                //! 文字コードをセットする.
                serialPort1.Encoding = Encoding.ASCII;

                try
                {
                    //! シリアルポートをオープンする.
                    serialPort1.Open();

                    //! ボタンの表示を[接続]から[切断]に変える.
                    Connect.Text = "切断";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //! シリアルポートをオープンしていない場合、処理を行わない.
            if (serialPort1.IsOpen == false)
            {
                return;
            }

            try
            {
                //! 受信データを読み込む.
                String data = serialPort1.ReadTo("|");
                serialPort1.DiscardInBuffer();



                //! 受信したデータをテキストボックスに書き込む.
                Invoke(new Delegate_RcvDataToTextBox(RcvDataToTextBox), new Object[] { data });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private delegate void Delegate_RcvDataToTextBox(string data);
        private void RcvDataToTextBox(string data)
        {
            
            //! 受信データをテキストボックスの最後に追記する.
            if (data != "")
            {
                data.Replace("/n","");
                string[] dates = new String[4];
                dates = data.Split(':');
                Console.WriteLine("--------------");
                Console.WriteLine(data);
                double tmp = 0.0;
                if (dates.Length == 4 ) {
                    int id = 0;
                    if (dates[0] == "1")
                    {
                        id = 1;
                    }else
                    if (dates[0] == "2")
                    {
                        id = 2;
                    }
                    else 
                    if (dates[0] == "3")
                    {
                        id = 3;
                    }
                    else
                    {
                        return;
                    }

                    IDList[id].Text = "ID:"+id.ToString();
                      
                        refleshint(1,id);
                    
                    
                    switch (dates[1])
                        {
                            case "1":
                                StatusList[id].BackColor = Color.LightGreen;
                            StatusList[id].Text = "Ready";
                                break;
                            case "2":
                            StatusList[id].BackColor = Color.LightBlue;
                            StatusList[id].Text = "Running";
                                break;
                            case "3":
                            StatusList[id].BackColor = Color.Red;

                            LoggerSample.Debug("ErrorCode:"+id);
                            StatusList[id].Text = "Error";
                                break;
                        case "4":
                            StatusList[id].BackColor = Color.Aqua;

                            LoggerSample.Debug("Complete:"+id);
                            StatusList[id].Text = "Complete";
                            break;

                    }
                    if (double.TryParse(dates[2], out tmp))
                    {
                        tmp = tmp / 100;
                        if (tmp < 10) { return; }
                        TTmpList[id].Text = tmp.ToString()+"℃";
                    }
                    if (double.TryParse(dates[3], out tmp))
                    {
                        tmp = tmp / 100;
                        if (tmp < 10) { return; }
                        VTmpList[id].Text = tmp.ToString() + "℃";
                    }
                }
            }
        }

        public  int[] id= {0,0,0,0,0,0,0,0};
        delegate void SetFocusDelegate();
        void setColor(int id) { StatusList[id].BackColor = Color.Red; }
        void setText(int id)
        {
            StatusList[id].Text = "Error";
        }

        public  int nowtime = 0;
        public int xbid = 0;
         void OnElapsed_TimersTimer(object sender, ElapsedEventArgs e)
        {
            nowtime++;
            int ids = 1;
            foreach (int i in id){
                if (i != 0)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(nowtime);
                    if (i+10 <= nowtime) {
                        switch (ids)
                        {

                            case 1:

                                setColor(xbid);
                                setText(xbid);
                                break;

                        }



                    }                  
                }
                ids++;
            }



        }
         void refleshint(int i,int xbeeid) {
            i = i - 1;
            id[i] = nowtime;
            xbid = xbeeid;

        }
        static LogForm lgf;
        private void button1_Click(object sender, EventArgs e)
            
        {

         lgf = new LogForm();
            lgf.Visible = true;
            fileload(filepath);
            LogIn(st,lgf);
        }
       static  string st;
        public void fileload(String str)
        {
            StreamReader sr;
            
                 sr = new StreamReader(filepath, Encoding.GetEncoding("Shift_JIS"));
                st = sr.ReadToEnd();
                sr.Close();
            
                StreamWriter sw = new StreamWriter(filepath, false, Encoding.GetEncoding("Shift_JIS"));
                sw.Write(st);
                sw.Close();

            
        }
        public static void LogIn(String st,LogForm lgf)
        {
            lgf.changeBox(st);   

        }
        public static string filepath = "Log.txt";
      

    }
}

