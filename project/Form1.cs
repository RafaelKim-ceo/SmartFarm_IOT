using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Xml;
using System.Windows.Forms;
using System.Timers;


namespace project_test
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=greenglory;Uid=root;Pwd=1234");

        string strURL = "http://www.kma.go.kr/weather/forecast/mid-term-xml.jsp";
        string strCity = "";



        SerialPort ComPort = new SerialPort();

        private delegate void SetTextDelegate(string getString);

        public int Water_TempValue, LampState, PumpState, FanState, TempValue, HumiValue, LightValue, Water_LevelValue, GasValue, flag;

        public string Label_DateTime = DateTime.Now.ToString("HH:mm:ss");

        public static int LED_StartHour, LED_StartMin, LED_EndHour, LED_EndMin;
        public static int PUMP_StartHour, PUMP_StartMin, PUMP_EndHour, PUMP_EndMin;
        public static int Circulate_StartHour, Circulate_StartMin, Circulate_EndHour, Circulate_EndMin;
        public static bool LED_SET_STATE, PUMP_SET_STATE, CIRCULATE_SET_STATE;
        private System.Timers.Timer timer;


        public bool dB_Open = false;
        public bool DayOnOffState;


        public bool mySql_Open()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot contact MySQL Server", "mySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again", "mySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show(ex.ToString(), "mySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                return false;
            }
        }


        public bool mySql_Close()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public Form1()
        {
            InitializeComponent();
            ComPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);


            timer3.Interval = 1000;
            timer3.Enabled = true;
            timer3.Tick += timer3_Tick;

            timer4.Interval = 1000;
            timer4.Enabled = true;
            timer4.Tick += timer4_Tick;

            timer5.Interval = 1000;
            timer5.Enabled = true;
            timer5.Tick += timer5_Tick;


        }

        private void AutoSetting()
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer6.Interval = 1000;

            string Label_Today = DateTime.Now.ToString("yyyy-MM-dd");
            label5.Text = Label_Today;


            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


            lblDateText.Text = Label_DateTime;

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;                          // 1 seconds
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();


            cmbCity.SelectedIndex = cmbCity.Items.Count - 1;
            cmbBaudRate.Items.Clear();
            cmbCity.Items.Add("청주");
            cmbCity.Items.Add("서울");
            cmbCity.Items.Add("인천");
            cmbCity.Items.Add("수원");
            cmbCity.Items.Add("대전");
            cmbCity.Items.Add("춘천");
            cmbCity.Items.Add("전주");
            cmbCity.Items.Add("광주");
            cmbCity.Items.Add("목포");
            cmbCity.Items.Add("여수");
            cmbCity.Items.Add("대구");
            cmbCity.Items.Add("부산");
            cmbCity.Items.Add("울산");
            cmbCity.Items.Add("제주");
            cmbCity.SelectedIndex = 0;

            btnAuto.Checked = true;

            cmbComPort.Items.Clear();
            var portName = System.IO.Ports.SerialPort.GetPortNames();
            cmbComPort.Items.AddRange(portName);
            cmbComPort.SelectedIndex = cmbComPort.Items.Count - 1;
            cmbBaudRate.Items.Clear();
            cmbBaudRate.Items.Add("9600");
            cmbBaudRate.Items.Add("19200");
            cmbBaudRate.Items.Add("57600");
            cmbBaudRate.Items.Add("115200");
            cmbBaudRate.SelectedIndex = 0;

            TempProgressBar.Value = 0;
            TempProgressBar.Minimum = 0;
            TempProgressBar.Maximum = 100;

            HumiProgressBar.Value = 0;
            HumiProgressBar.Minimum = 0;
            HumiProgressBar.Maximum = 100;

            LightProgressBar.Value = 0;
            LightProgressBar.Minimum = 300;
            LightProgressBar.Maximum = 1500;

            Water_Level_Bar.Value = 0;
            Water_Level_Bar.Minimum = 0;
            Water_Level_Bar.Maximum = 100;

            ChartDraw();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.Close();
                ComPort.Dispose();
                ComPort = null;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)  //시리얼 오픈
        {
            if (btnCon.Text == "Connect")
            {
                ComPort.PortName = cmbComPort.Text;
                ComPort.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                ComPort.DataBits = 8;
                ComPort.Parity = Parity.None;
                ComPort.StopBits = StopBits.One;
                ComPort.Handshake = Handshake.None;
                ComPort.Open();
                ComPort.DiscardInBuffer();
                btnCon.Text = "Close";
            }
            else
            {
                ComPort.Close();
                btnCon.Text = "Connect";
            }
        }

        private void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string rxd = ComPort.ReadTo("\n");
            this.BeginInvoke(new SetTextDelegate(SerialReceived), new object[] { rxd });

        }

        private void SerialReceived(string inString)
        {
            string InputData = inString;

            if (InputData == null)
            {
                flag = 1;
            }
            string Head = InputData.Substring(0, 1);
            string Data = InputData.Substring(1);
            Data_listBox.Items.Add(InputData);
            Data_listBox.SelectedIndex = Data_listBox.Items.Count - 1;


            if (Head == "@")
            {
                string[] PasingData = Data.Split(',');

                TempValue = (int)float.Parse(PasingData[1]);
                HumiValue = (int)float.Parse(PasingData[2]);
                LightValue = (int)float.Parse(PasingData[3]);
                GasValue = (int)float.Parse(PasingData[4]);
                Water_LevelValue = (int)float.Parse(PasingData[5]);
                Water_TempValue = (int)float.Parse(PasingData[6]);

                LampState = int.Parse(PasingData[7]);
                FanState = int.Parse(PasingData[8]);
                PumpState = int.Parse(PasingData[9]);


                LampStateCheck(LampState);
                FanStateCheck(FanState);
                PumpStateCheck(PumpState);


                lblTemp_in.Text = TempValue.ToString();
                lblHumi_in.Text = HumiValue.ToString();
                lblLight_in.Text = LightValue.ToString();
                lblWaterTemp.Text = Water_TempValue.ToString();


                TempProgressBar.Value = TempValue;
                HumiProgressBar.Value = HumiValue;
                LightProgressBar.Value = LightValue;
                Water_Level_Bar.Value = Water_LevelValue;
                label9.Text = Water_LevelValue.ToString();
                TankTempProgressBar1.Value = Water_TempValue;

                lblCo2.Text = GasValue.ToString();

                TempProgressBar.Update();
                HumiProgressBar.Update();
                LightProgressBar.Update();
                Water_Level_Bar.Update();
                TankTempProgressBar1.Update();

                ChartDraw();

                InsertData(TempValue, HumiValue, LightValue, GasValue, Water_LevelValue, Water_TempValue);
            }
            else if (Head == "?")
            {

                lblTemp_in.Text = "Error";
                lblHumi_in.Text = "Error";
                lblLight_in.Text = "Error";
            }

        }

        public void ChartDraw()
        {

            chart1.Series["Series1"].Points.Add(TempValue);

            if (chart1.Series["Series1"].Points.Count > 50)
            {
                chart1.Series["Series1"].Points.RemoveAt(0);
            }


            chart2.Series["Series1"].Points.Add(HumiValue);

            if (chart2.Series["Series1"].Points.Count > 50)
            {
                chart2.Series["Series1"].Points.RemoveAt(0);
            }

        }


        private void LampStateCheck(int State)
        {


            if (State == 1)
            {
                btnLampOff.BackColor = Color.DarkGray;
                btnLamp1.BackColor = Color.ForestGreen;
                btnLamp2.BackColor = Color.DarkGray;
                btnLamp3.BackColor = Color.DarkGray;
            }

            else if (State == 2)
            {
                btnLampOff.BackColor = Color.DarkGray;
                btnLamp1.BackColor = Color.DarkGray;
                btnLamp2.BackColor = Color.ForestGreen;
                btnLamp3.BackColor = Color.DarkGray;
            }

            else if (State == 3)
            {
                btnLampOff.BackColor = Color.DarkGray;
                btnLamp1.BackColor = Color.DarkGray;
                btnLamp2.BackColor = Color.DarkGray;
                btnLamp3.BackColor = Color.ForestGreen;
            }

            else
            {
                btnLampOff.BackColor = Color.ForestGreen;
                btnLamp1.BackColor = Color.DarkGray;
                btnLamp2.BackColor = Color.DarkGray;
                btnLamp3.BackColor = Color.DarkGray;
            }
        }

        private void FanStateCheck(int State)
        {


            if (State == 1)
            {
                btn_Fan_Upper.BackColor = Color.ForestGreen;
                btn_Fan_Lower.BackColor = Color.DarkGray;
                btn_FanAll.BackColor = Color.DarkGray;
                btn_FanOff.BackColor = Color.DarkGray;
            }

            else if (State == 2)
            {
                btn_Fan_Upper.BackColor = Color.DarkGray;
                btn_Fan_Lower.BackColor = Color.ForestGreen;
                btn_FanAll.BackColor = Color.DarkGray;
                btn_FanOff.BackColor = Color.DarkGray;
            }

            else if (State == 3)
            {
                btn_Fan_Upper.BackColor = Color.DarkGray;
                btn_Fan_Lower.BackColor = Color.DarkGray;
                btn_FanAll.BackColor = Color.ForestGreen;
                btn_FanOff.BackColor = Color.DarkGray;
            }

            else
            {
                btn_Fan_Upper.BackColor = Color.DarkGray;
                btn_Fan_Lower.BackColor = Color.DarkGray;
                btn_FanAll.BackColor = Color.DarkGray;
                btn_FanOff.BackColor = Color.ForestGreen;
            }
        }


        private void PumpStateCheck(int State)
        {
            if (State == 1)
            {
                btnPumpOn.BackColor = Color.ForestGreen;
                btnPumpOff.BackColor = Color.DarkGray;
            }

            else
            {
                btnPumpOn.BackColor = Color.DarkGray;
                btnPumpOff.BackColor = Color.ForestGreen;
            }


        }

       

      





        public void InsertData(int Data_1, int Data_2, int Data_3, int Data_4, int Data_5, int Data_6)
        {
            if (dB_Open)
            {
                try
                {
                    MySqlCommand command = connection.CreateCommand();

                    command.CommandText = "INSERT INTO save_sensor(date,time,temp,humi,lux,co2,water_level,water_temp) VALUES(@date,@time,@temp,@humi,@light,@co2,@water_level,@water_temp)";
                    command.Parameters.Add("@date", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    command.Parameters.Add("@time", MySqlDbType.VarChar).Value = DateTime.Now.ToString("HH:mm:ss");
                    command.Parameters.Add("@temp", MySqlDbType.VarChar).Value = Data_1.ToString();
                    command.Parameters.Add("@humi", MySqlDbType.VarChar).Value = Data_2.ToString();
                    command.Parameters.Add("@light", MySqlDbType.VarChar).Value = Data_3.ToString();
                    command.Parameters.Add("@co2", MySqlDbType.VarChar).Value = Data_4.ToString();
                    command.Parameters.Add("@water_level", MySqlDbType.VarChar).Value = Data_5.ToString();
                    command.Parameters.Add("@water_temp", MySqlDbType.VarChar).Value = Data_6.ToString();

                    command.ExecuteNonQuery();
                }
                catch
                {
                    //
                }
            }

        }

        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.
            Invoke((MethodInvoker)delegate
            {
                lblDateText.Text = System.DateTime.Now.ToString("HH:mm:ss");
            });
        }


        private void btnAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAuto.Checked == true)
            {
                //groupBox_Manual.Enabled = false;
                //btnPumpOn.Enabled = false;
                //   groupBox_Manual.ForeColor = Color.DarkGray;
                grpWaterPump.Enabled = false;
                grpLED.Enabled = false;
                grpFan.Enabled = false;

                if(PUMP_SET_STATE == true)
                {
                    MessageBox.Show("수동모드가 수행중입니다.");
                    btnAuto.Checked = false;
                }
            }



            else
            {
                // groupBox_Manual.Enabled = true;
                //btnPumpOn.Enabled = true;
                //  groupBox_Manual.ForeColor = Color.WhiteSmoke;
                grpWaterPump.Enabled = true;
                grpLED.Enabled = true;
                grpFan.Enabled = true;


            }


        }

        private void picDBoff_Click(object sender, EventArgs e)
        {
            if (picDBoff.Visible == true)
            {
                if (mySql_Open())
                {
                    picDBon.Visible = true;
                    picDBoff.Visible = false;

                    Status.Text = "Connection Ok.";

                    dB_Open = true;
                }
                else
                {
                    picDBon.Visible = false;
                    picDBoff.Visible = true;


                    Status.Text = "Connection Failed.";

                    dB_Open = false;
                }
            }

            else
            {
                if (mySql_Close())
                {
                    picDBoff.Visible = true;
                    picDBon.Visible = false;

                    Status.Text = "dB Closing Ok.";
                    dB_Open = false;
                }
                else
                {
                    picDBoff.Visible = true;
                    picDBon.Visible = false;

                    Status.Text = "dB Closing Failed.";
                    dB_Open = false;
                }
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (XmlReader xr = XmlReader.Create(strURL))
                {
                    string strMsg = "";
                    XmlWriterSettings ws = new XmlWriterSettings();
                    ws.Indent = true;
                    bool bCheck = false;
                    int iCount = 0;
                    strCity = cmbCity.Text;

                    while (xr.Read())
                    {
                        switch (xr.NodeType)
                        {
                            case XmlNodeType.Element:
                                {
                                    break;
                                }

                            case XmlNodeType.Text:
                                {
                                    if (xr.Value.Equals(strCity))
                                    {
                                        bCheck = true;
                                    }

                                    if (bCheck)
                                    {
                                        DateTime dt;
                                        bool b = DateTime.TryParse(xr.Value.ToString(), out dt);
                                        if (b)
                                        {
                                            strMsg += "/";
                                        }

                                        strMsg += xr.Value + ",";
                                        iCount += 1;
                                        if (iCount > 36)
                                        {
                                            bCheck = false;
                                        }
                                    }

                                    break;
                                }

                            case XmlNodeType.XmlDeclaration:
                                {
                                    break;
                                }

                            case XmlNodeType.ProcessingInstruction:
                                {
                                    break;
                                }

                            case XmlNodeType.Comment:
                                {
                                    break;
                                }

                            case XmlNodeType.EndElement:
                                {
                                    break;
                                }

                        }
                    }

                    string[] strTmp = strMsg.Split('/');

                    string[] strWh1 = strTmp[1].Split(',');
                    label12.Text = strWh1[0];
                    label13.Text = "최저 :" + strWh1[2] + "℃";
                    label14.Text = "최고 :" + strWh1[3] + "℃";
                    label15.Text = strWh1[1];

                    string[] strWh2 = strTmp[2].Split(',');
                    label19.Text = strWh2[0];
                    label17.Text = "최저 :" + strWh2[2] + "℃";
                    label16.Text = "최고 :" + strWh2[3] + "℃";
                    label18.Text = strWh2[1];

                    string[] strWh3 = strTmp[3].Split(',');
                    label25.Text = strWh3[0];
                    label23.Text = "최저 :" + strWh3[2] + "℃";
                    label22.Text = "최고 :" + strWh3[3] + "℃";
                    label24.Text = strWh3[1];

                    string[] strWh4 = strTmp[4].Split(',');
                    label31.Text = strWh4[0];
                    label29.Text = "최저 :" + strWh4[2] + "℃";
                    label28.Text = "최고 :" + strWh4[3] + "℃";
                    label30.Text = strWh4[1];

                    string[] strWh5 = strTmp[5].Split(',');
                    label37.Text = strWh5[0];
                    label35.Text = "최저 :" + strWh5[2] + "℃";
                    label34.Text = "최고 :" + strWh5[3] + "℃";
                    label36.Text = strWh5[1];

                    string[] strWh6 = strTmp[6].Split(',');
                    //label43.Text = strWh6[0];
                    //label41.Text = "MIN :" + strWh6[2] + "℃";
                    //label40.Text = "MAX :" + strWh6[3] + "℃";
                    //label42.Text = strWh6[1];

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void btnPumpSet_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }


        //Manual Switch Operating======================================================
        private void btnPumpOn_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#P:1");
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            if((date.Hour < 09)|| (date.Hour > 17))
            {

                if (ComPort.IsOpen)
                {
                    ComPort.WriteLine("#L:0");
                }

               
            }

            else
            {
                if (ComPort.IsOpen)
                {
                    ComPort.WriteLine("#L:3");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer6.Enabled = true;
            DayOnOffState = true;

            if(DayOnOffState == true)
            {
                button2.BackColor = Color.ForestGreen;
                button3.BackColor = Color.DarkGray;
            }
            else
            {
                button2.BackColor = Color.DarkGray;
                button3.BackColor = Color.ForestGreen;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer6.Enabled = false;
            DayOnOffState = false;

            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#L:0");
            }

            if (DayOnOffState == false)
            {
                button2.BackColor = Color.DarkGray;
                button3.BackColor = Color.ForestGreen;
            }
            else
            {
                button2.BackColor = Color.ForestGreen;
                button3.BackColor = Color.DarkGray;


            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString("HH:mm:ss");

            LED_Set(LED_StartHour, LED_EndHour, LED_StartMin, LED_EndMin);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString("HH:mm:ss");

            Circulate_Set(Circulate_StartHour, Circulate_EndHour, Circulate_StartMin, Circulate_EndMin);
        }

        private void btnSetCirculate_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }

        //Auto Mode Logic=============================================================


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dB_Open == true)
            {
                MessageBox.Show( "DB가 커넥트 되어있습니다.", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("종료하시겠습니까 ?", "알림", MessageBoxButtons.YesNo);

                if (MessageBox.Show("종료하시겠습니까 ?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }


                else
                {
                    MessageBox.Show("종료하지 않았습니다.");
                }


            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dB_Open = false;
            picDBoff.Visible = true;
            Status.Text = "dB Closing Disconnected";

        }

        private void btnSetLED_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

 

        public void LED_Set(int Data1, int Data2, int Data3, int Data4)
        {

            //string NowDateTime = System.DateTime.Now.ToString("HH:mm:ss");

            string[] SetData = label10.Text.Split(':');

            int NowHour = Convert.ToInt32(SetData[0]);
            int NowMin = Convert.ToInt32(SetData[1]);

            if ((Data1 == NowHour) && (Data3 == NowMin))
            {
                if (ComPort.IsOpen)
                {
                    ComPort.WriteLine("#L:3");
                }

            }

            else if ((Data2 == NowHour) && (Data4 == NowMin))
            {
                if (ComPort.IsOpen)
                {
                    ComPort.WriteLine("#L:0");
                }
            }
        }


        public void PUMP_Set(int Data1, int Data2, int Data3, int Data4)
        {

            //string NowDateTime = System.DateTime.Now.ToString("HH:mm:ss");

            string[] SetData = label10.Text.Split(':');

            int NowHour = Convert.ToInt32(SetData[0]);
            int NowMin = Convert.ToInt32(SetData[1]);

            if ((Data1 == NowHour) && (Data3 == NowMin))
            {
                if (ComPort.IsOpen)
                {
                    ComPort.WriteLine("#P:1");
                }

            }

            else if ((Data2 == NowHour) && (Data4 == NowMin))
            {
                if (ComPort.IsOpen)
                {
                    ComPort.WriteLine("#P:0");
                }

                
            }
        }


        public void Circulate_Set(int Data1, int Data2, int Data3, int Data4)
        {

            //string NowDateTime = System.DateTime.Now.ToString("HH:mm:ss");

            string[] SetData = label10.Text.Split(':');

            int NowHour = Convert.ToInt32(SetData[0]);
            int NowMin = Convert.ToInt32(SetData[1]);

            if ((Data1 == NowHour) && (Data3 == NowMin))
            {
                if (ComPort.IsOpen)
                {
                    ComPort.WriteLine("#F:3");
                }
            }

            else if ((Data2 == NowHour) && (Data4 == NowMin))
            {
                if (ComPort.IsOpen)
                {
                    ComPort.WriteLine("#F:0");
                }
            }
        }



        private void btnSet_Click(object sender, EventArgs e)
        {
            /*

            string SetStartTime = setData1.Text;
            string SetEndTime = setData2.Text;

            string[] ParsingStartData = SetStartTime.Split(':');
            string[] ParsingEndData = SetEndTime.Split(':');

            LED_StartHour = Convert.ToInt32(ParsingStartData[0]);
            LED_StartMin = Convert.ToInt32(ParsingStartData[1]);

            LED_EndHour = Convert.ToInt32(ParsingEndData[0]);
            LED_EndMin = Convert.ToInt32(ParsingEndData[1]);


            //timer3.Enabled = true;

            //timer3.Interval = ((LED_EndHour * 3600000) - (LED_StartHour * 3600000)) + ((LED_EndMin * 60000) - (LED_StartMin * 60000));
            */
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString("HH:mm:ss");
            //LED_Set(LED_StartHour, LED_EndHour, LED_StartMin, LED_EndMin);
            PUMP_Set(PUMP_StartHour, PUMP_EndHour, PUMP_StartMin, PUMP_EndMin);
            //Circulate_Set(Circulate_StartHour, Circulate_StartMin, Circulate_EndHour, Circulate_EndMin);
        }


        private void btnPumpOff_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#P:0");
            }
        }

        private void btnLampOff_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#L:0");
            }
        }

        private void btnLamp1_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#L:1");
            }
        }

        private void btnLamp2_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#L:2");
            }
        }

        private void btnLamp3_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#L:3");
            }
        }

        private void btn_FanAll_Click_1(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#F:3");
            }
        }

        private void btn_Fan_Upper_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#F:1");
            }
        }

        private void btn_Fan_Lower_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#F:2");
            }
        }

        private void btn_FanOff_Click_1(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.WriteLine("#F:0");
            }
        }
    }
}



