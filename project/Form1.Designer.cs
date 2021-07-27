
namespace project_test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.RadioButton();
            this.btnAuto = new System.Windows.Forms.RadioButton();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Data_listBox = new System.Windows.Forms.ListBox();
            this.grpAutoManual = new System.Windows.Forms.GroupBox();
            this.grpWaterPump = new System.Windows.Forms.GroupBox();
            this.btnPumpSet = new System.Windows.Forms.Button();
            this.btnPumpOff = new System.Windows.Forms.Button();
            this.btnPumpOn = new System.Windows.Forms.Button();
            this.grpFan = new System.Windows.Forms.GroupBox();
            this.btnSetCirculate = new System.Windows.Forms.Button();
            this.btn_FanOff = new System.Windows.Forms.Button();
            this.btn_FanAll = new System.Windows.Forms.Button();
            this.btn_Fan_Lower = new System.Windows.Forms.Button();
            this.btn_Fan_Upper = new System.Windows.Forms.Button();
            this.grpLED = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLamp3 = new System.Windows.Forms.Button();
            this.btnLamp2 = new System.Windows.Forms.Button();
            this.btnSetLed = new System.Windows.Forms.Button();
            this.btnLampOff = new System.Windows.Forms.Button();
            this.btnLamp1 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.picDBoff = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.picDBon = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblDateText = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTemp_in = new System.Windows.Forms.Label();
            this.TempProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label32 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHumi_in = new System.Windows.Forms.Label();
            this.HumiProgressBar = new CircularProgressBar.CircularProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLight_in = new System.Windows.Forms.Label();
            this.LightProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCo2 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWaterTemp = new System.Windows.Forms.Label();
            this.TankTempProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label33 = new System.Windows.Forms.Label();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.Water_Level_Bar = new VerticalProgressBar();
            this.statusbar.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpAutoManual.SuspendLayout();
            this.grpWaterPump.SuspendLayout();
            this.grpFan.SuspendLayout();
            this.grpLED.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDBoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDBon)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // cmbComPort
            // 
            resources.ApplyResources(this.cmbComPort, "cmbComPort");
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Name = "cmbComPort";
            // 
            // cmbBaudRate
            // 
            resources.ApplyResources(this.cmbBaudRate, "cmbBaudRate");
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Name = "cmbBaudRate";
            // 
            // btnCon
            // 
            resources.ApplyResources(this.btnCon, "btnCon");
            this.btnCon.ForeColor = System.Drawing.Color.Black;
            this.btnCon.Name = "btnCon";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManual
            // 
            resources.ApplyResources(this.btnManual, "btnManual");
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Name = "btnManual";
            this.btnManual.TabStop = true;
            this.btnManual.UseVisualStyleBackColor = true;
            // 
            // btnAuto
            // 
            resources.ApplyResources(this.btnAuto, "btnAuto");
            this.btnAuto.ForeColor = System.Drawing.Color.White;
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.TabStop = true;
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.CheckedChanged += new System.EventHandler(this.btnAuto_CheckedChanged);
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            resources.ApplyResources(this.statusbar, "statusbar");
            this.statusbar.Name = "statusbar";
            // 
            // Status
            // 
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Name = "Status";
            resources.ApplyResources(this.Status, "Status");
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Data_listBox);
            this.groupBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // Data_listBox
            // 
            this.Data_listBox.ForeColor = System.Drawing.Color.Black;
            this.Data_listBox.FormattingEnabled = true;
            resources.ApplyResources(this.Data_listBox, "Data_listBox");
            this.Data_listBox.Name = "Data_listBox";
            // 
            // grpAutoManual
            // 
            this.grpAutoManual.Controls.Add(this.grpWaterPump);
            this.grpAutoManual.Controls.Add(this.grpFan);
            this.grpAutoManual.Controls.Add(this.btnManual);
            this.grpAutoManual.Controls.Add(this.btnAuto);
            this.grpAutoManual.Controls.Add(this.grpLED);
            resources.ApplyResources(this.grpAutoManual, "grpAutoManual");
            this.grpAutoManual.ForeColor = System.Drawing.Color.White;
            this.grpAutoManual.Name = "grpAutoManual";
            this.grpAutoManual.TabStop = false;
            // 
            // grpWaterPump
            // 
            this.grpWaterPump.Controls.Add(this.btnPumpSet);
            this.grpWaterPump.Controls.Add(this.btnPumpOff);
            this.grpWaterPump.Controls.Add(this.btnPumpOn);
            resources.ApplyResources(this.grpWaterPump, "grpWaterPump");
            this.grpWaterPump.ForeColor = System.Drawing.Color.White;
            this.grpWaterPump.Name = "grpWaterPump";
            this.grpWaterPump.TabStop = false;
            // 
            // btnPumpSet
            // 
            this.btnPumpSet.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnPumpSet, "btnPumpSet");
            this.btnPumpSet.Name = "btnPumpSet";
            this.btnPumpSet.UseVisualStyleBackColor = true;
            this.btnPumpSet.Click += new System.EventHandler(this.btnPumpSet_Click);
            // 
            // btnPumpOff
            // 
            this.btnPumpOff.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnPumpOff, "btnPumpOff");
            this.btnPumpOff.Name = "btnPumpOff";
            this.btnPumpOff.UseVisualStyleBackColor = true;
            this.btnPumpOff.Click += new System.EventHandler(this.btnPumpOff_Click);
            // 
            // btnPumpOn
            // 
            this.btnPumpOn.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnPumpOn, "btnPumpOn");
            this.btnPumpOn.Name = "btnPumpOn";
            this.btnPumpOn.UseVisualStyleBackColor = true;
            this.btnPumpOn.Click += new System.EventHandler(this.btnPumpOn_Click);
            // 
            // grpFan
            // 
            this.grpFan.Controls.Add(this.btnSetCirculate);
            this.grpFan.Controls.Add(this.btn_FanOff);
            this.grpFan.Controls.Add(this.btn_FanAll);
            this.grpFan.Controls.Add(this.btn_Fan_Lower);
            this.grpFan.Controls.Add(this.btn_Fan_Upper);
            resources.ApplyResources(this.grpFan, "grpFan");
            this.grpFan.ForeColor = System.Drawing.Color.White;
            this.grpFan.Name = "grpFan";
            this.grpFan.TabStop = false;
            // 
            // btnSetCirculate
            // 
            this.btnSetCirculate.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnSetCirculate, "btnSetCirculate");
            this.btnSetCirculate.Name = "btnSetCirculate";
            this.btnSetCirculate.UseVisualStyleBackColor = true;
            this.btnSetCirculate.Click += new System.EventHandler(this.btnSetCirculate_Click);
            // 
            // btn_FanOff
            // 
            this.btn_FanOff.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_FanOff, "btn_FanOff");
            this.btn_FanOff.Name = "btn_FanOff";
            this.btn_FanOff.UseVisualStyleBackColor = true;
            this.btn_FanOff.Click += new System.EventHandler(this.btn_FanOff_Click_1);
            // 
            // btn_FanAll
            // 
            this.btn_FanAll.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_FanAll, "btn_FanAll");
            this.btn_FanAll.Name = "btn_FanAll";
            this.btn_FanAll.UseVisualStyleBackColor = true;
            this.btn_FanAll.Click += new System.EventHandler(this.btn_FanAll_Click_1);
            // 
            // btn_Fan_Lower
            // 
            this.btn_Fan_Lower.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_Fan_Lower, "btn_Fan_Lower");
            this.btn_Fan_Lower.Name = "btn_Fan_Lower";
            this.btn_Fan_Lower.UseVisualStyleBackColor = true;
            this.btn_Fan_Lower.Click += new System.EventHandler(this.btn_Fan_Lower_Click);
            // 
            // btn_Fan_Upper
            // 
            this.btn_Fan_Upper.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_Fan_Upper, "btn_Fan_Upper");
            this.btn_Fan_Upper.Name = "btn_Fan_Upper";
            this.btn_Fan_Upper.UseVisualStyleBackColor = true;
            this.btn_Fan_Upper.Click += new System.EventHandler(this.btn_Fan_Upper_Click);
            // 
            // grpLED
            // 
            this.grpLED.Controls.Add(this.button3);
            this.grpLED.Controls.Add(this.button2);
            this.grpLED.Controls.Add(this.btnLamp3);
            this.grpLED.Controls.Add(this.btnLamp2);
            this.grpLED.Controls.Add(this.btnSetLed);
            this.grpLED.Controls.Add(this.btnLampOff);
            this.grpLED.Controls.Add(this.btnLamp1);
            resources.ApplyResources(this.grpLED, "grpLED");
            this.grpLED.ForeColor = System.Drawing.Color.White;
            this.grpLED.Name = "grpLED";
            this.grpLED.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLamp3
            // 
            this.btnLamp3.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnLamp3, "btnLamp3");
            this.btnLamp3.Name = "btnLamp3";
            this.btnLamp3.UseVisualStyleBackColor = true;
            this.btnLamp3.Click += new System.EventHandler(this.btnLamp3_Click);
            // 
            // btnLamp2
            // 
            this.btnLamp2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnLamp2, "btnLamp2");
            this.btnLamp2.Name = "btnLamp2";
            this.btnLamp2.UseVisualStyleBackColor = true;
            this.btnLamp2.Click += new System.EventHandler(this.btnLamp2_Click);
            // 
            // btnSetLed
            // 
            this.btnSetLed.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnSetLed, "btnSetLed");
            this.btnSetLed.Name = "btnSetLed";
            this.btnSetLed.UseVisualStyleBackColor = true;
            this.btnSetLed.Click += new System.EventHandler(this.btnSetLED_Click);
            // 
            // btnLampOff
            // 
            this.btnLampOff.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnLampOff, "btnLampOff");
            this.btnLampOff.Name = "btnLampOff";
            this.btnLampOff.UseVisualStyleBackColor = true;
            this.btnLampOff.Click += new System.EventHandler(this.btnLampOff_Click);
            // 
            // btnLamp1
            // 
            this.btnLamp1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnLamp1, "btnLamp1");
            this.btnLamp1.Name = "btnLamp1";
            this.btnLamp1.UseVisualStyleBackColor = true;
            this.btnLamp1.Click += new System.EventHandler(this.btnLamp1_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.groupBox10.Controls.Add(this.button1);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Controls.Add(this.btnCon);
            this.groupBox10.Controls.Add(this.cmbCity);
            this.groupBox10.Controls.Add(this.picDBoff);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.cmbComPort);
            this.groupBox10.Controls.Add(this.cmbBaudRate);
            this.groupBox10.Controls.Add(this.picDBon);
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.ForeColor = System.Drawing.Color.White;
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Name = "label10";
            // 
            // cmbCity
            // 
            resources.ApplyResources(this.cmbCity, "cmbCity");
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // picDBoff
            // 
            this.picDBoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picDBoff.Image = global::project_test.Properties.Resources.DBoff;
            resources.ApplyResources(this.picDBoff, "picDBoff");
            this.picDBoff.Name = "picDBoff";
            this.picDBoff.TabStop = false;
            this.picDBoff.Click += new System.EventHandler(this.picDBoff_Click);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Name = "label20";
            // 
            // picDBon
            // 
            this.picDBon.Image = global::project_test.Properties.Resources.DBon;
            resources.ApplyResources(this.picDBon, "picDBon");
            this.picDBon.Name = "picDBon";
            this.picDBon.TabStop = false;
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label26.ForeColor = System.Drawing.SystemColors.Window;
            this.label26.Name = "label26";
            // 
            // lblDateText
            // 
            resources.ApplyResources(this.lblDateText, "lblDateText");
            this.lblDateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateText.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateText.Name = "lblDateText";
            this.lblDateText.UseCompatibleTextRendering = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lblTemp_in);
            this.panel6.Controls.Add(this.TempProgressBar);
            this.panel6.Controls.Add(this.label32);
            this.panel6.Controls.Add(this.chart1);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // lblTemp_in
            // 
            this.lblTemp_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.lblTemp_in, "lblTemp_in");
            this.lblTemp_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTemp_in.Name = "lblTemp_in";
            // 
            // TempProgressBar
            // 
            this.TempProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.TempProgressBar.AnimationSpeed = 500;
            this.TempProgressBar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TempProgressBar, "TempProgressBar");
            this.TempProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TempProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TempProgressBar.InnerMargin = 2;
            this.TempProgressBar.InnerWidth = -1;
            this.TempProgressBar.MarqueeAnimationSpeed = 2000;
            this.TempProgressBar.Name = "TempProgressBar";
            this.TempProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.TempProgressBar.OuterMargin = -25;
            this.TempProgressBar.OuterWidth = 26;
            this.TempProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TempProgressBar.ProgressWidth = 10;
            this.TempProgressBar.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.TempProgressBar.StartAngle = 270;
            this.TempProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TempProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.TempProgressBar.SubscriptText = ".23";
            this.TempProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TempProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.TempProgressBar.SuperscriptText = "°C";
            this.TempProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.TempProgressBar.Value = 68;
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Name = "label32";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart1.BorderlineWidth = 3;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalOffset = 5D;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 5;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Interval = 5D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Maximum = 50D;
            chartArea1.AxisX.MaximumAutoSize = 0F;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.ScrollBar.Enabled = false;
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Maximum = 50D;
            chartArea1.AxisY.Minimum = -10D;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.CursorX.Interval = 0D;
            chartArea1.CursorX.LineWidth = 10;
            chartArea1.CursorY.LineWidth = 10;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.SuppressExceptions = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.chart2);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lblHumi_in);
            this.panel7.Controls.Add(this.HumiProgressBar);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart2.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart2.BorderlineWidth = 3;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalOffset = 5D;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 5;
            chartArea2.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Interval = 5D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.Maximum = 50D;
            chartArea2.AxisX.MaximumAutoSize = 0F;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.ScrollBar.Enabled = false;
            chartArea2.AxisY.Interval = 20D;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.CursorX.Interval = 0D;
            chartArea2.CursorX.LineWidth = 10;
            chartArea2.CursorY.LineWidth = 10;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            resources.ApplyResources(this.chart2, "chart2");
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.DarkBlue;
            series2.IsVisibleInLegend = false;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.SuppressExceptions = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // lblHumi_in
            // 
            this.lblHumi_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.lblHumi_in, "lblHumi_in");
            this.lblHumi_in.ForeColor = System.Drawing.Color.Blue;
            this.lblHumi_in.Name = "lblHumi_in";
            // 
            // HumiProgressBar
            // 
            this.HumiProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.HumiProgressBar.AnimationSpeed = 500;
            this.HumiProgressBar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.HumiProgressBar, "HumiProgressBar");
            this.HumiProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HumiProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HumiProgressBar.InnerMargin = 2;
            this.HumiProgressBar.InnerWidth = -1;
            this.HumiProgressBar.MarqueeAnimationSpeed = 2000;
            this.HumiProgressBar.Name = "HumiProgressBar";
            this.HumiProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.HumiProgressBar.OuterMargin = -25;
            this.HumiProgressBar.OuterWidth = 26;
            this.HumiProgressBar.ProgressColor = System.Drawing.Color.Navy;
            this.HumiProgressBar.ProgressWidth = 10;
            this.HumiProgressBar.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.HumiProgressBar.StartAngle = 270;
            this.HumiProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.HumiProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.HumiProgressBar.SubscriptText = ".23";
            this.HumiProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.HumiProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.HumiProgressBar.SuperscriptText = "°C";
            this.HumiProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.HumiProgressBar.Value = 68;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.label35);
            this.panel5.Controls.Add(this.label36);
            this.panel5.Controls.Add(this.label37);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Name = "label34";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Name = "label35";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Name = "label36";
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Name = "label37";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.label31);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Name = "label28";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Name = "label29";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Name = "label30";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Name = "label31";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label24);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Name = "label25";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Name = "label22";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Name = "label23";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Name = "label24";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Name = "label19";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label15);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Name = "label12";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Name = "label13";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Name = "label15";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Name = "label38";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            // 
            // lblLight_in
            // 
            this.lblLight_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.lblLight_in, "lblLight_in");
            this.lblLight_in.ForeColor = System.Drawing.Color.Yellow;
            this.lblLight_in.Name = "lblLight_in";
            // 
            // LightProgressBar
            // 
            this.LightProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.LightProgressBar.AnimationSpeed = 500;
            this.LightProgressBar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LightProgressBar, "LightProgressBar");
            this.LightProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LightProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LightProgressBar.InnerMargin = 2;
            this.LightProgressBar.InnerWidth = -1;
            this.LightProgressBar.MarqueeAnimationSpeed = 2000;
            this.LightProgressBar.Name = "LightProgressBar";
            this.LightProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.LightProgressBar.OuterMargin = -25;
            this.LightProgressBar.OuterWidth = 26;
            this.LightProgressBar.ProgressColor = System.Drawing.Color.Khaki;
            this.LightProgressBar.ProgressWidth = 10;
            this.LightProgressBar.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.LightProgressBar.StartAngle = 270;
            this.LightProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LightProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LightProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.LightProgressBar.SubscriptText = ".23";
            this.LightProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LightProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.LightProgressBar.SuperscriptText = "°C";
            this.LightProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LightProgressBar.Value = 68;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Name = "label11";
            // 
            // lblCo2
            // 
            this.lblCo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.lblCo2, "lblCo2");
            this.lblCo2.ForeColor = System.Drawing.Color.Yellow;
            this.lblCo2.Name = "lblCo2";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.circularProgressBar1, "circularProgressBar1");
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.circularProgressBar1.ProgressWidth = 10;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Name = "label40";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Name = "label39";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
            // 
            // lblWaterTemp
            // 
            this.lblWaterTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.lblWaterTemp, "lblWaterTemp");
            this.lblWaterTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblWaterTemp.Name = "lblWaterTemp";
            // 
            // TankTempProgressBar1
            // 
            this.TankTempProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.TankTempProgressBar1.AnimationSpeed = 500;
            this.TankTempProgressBar1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TankTempProgressBar1, "TankTempProgressBar1");
            this.TankTempProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TankTempProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TankTempProgressBar1.InnerMargin = 2;
            this.TankTempProgressBar1.InnerWidth = -1;
            this.TankTempProgressBar1.MarqueeAnimationSpeed = 2000;
            this.TankTempProgressBar1.Name = "TankTempProgressBar1";
            this.TankTempProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.TankTempProgressBar1.OuterMargin = -25;
            this.TankTempProgressBar1.OuterWidth = 26;
            this.TankTempProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TankTempProgressBar1.ProgressWidth = 10;
            this.TankTempProgressBar1.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.TankTempProgressBar1.StartAngle = 270;
            this.TankTempProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TankTempProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.TankTempProgressBar1.SubscriptText = ".23";
            this.TankTempProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TankTempProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.TankTempProgressBar1.SuperscriptText = "°C";
            this.TankTempProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.TankTempProgressBar1.Value = 68;
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Name = "label33";
            // 
            // metroListView1
            // 
            resources.ApplyResources(this.metroListView1, "metroListView1");
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Name = "label9";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Name = "label5";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.pictureBox1.BackgroundImage = global::project_test.Properties.Resources.title;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Water_Level_Bar
            // 
            resources.ApplyResources(this.Water_Level_Bar, "Water_Level_Bar");
            this.Water_Level_Bar.Name = "Water_Level_Bar";
            this.Water_Level_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.Water_Level_Bar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLight_in);
            this.Controls.Add(this.LightProgressBar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCo2);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblWaterTemp);
            this.Controls.Add(this.TankTempProgressBar1);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDateText);
            this.Controls.Add(this.grpAutoManual);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.statusbar);
            this.ForeColor = System.Drawing.Color.Violet;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.grpAutoManual.ResumeLayout(false);
            this.grpAutoManual.PerformLayout();
            this.grpWaterPump.ResumeLayout(false);
            this.grpFan.ResumeLayout(false);
            this.grpLED.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDBoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDBon)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.RadioButton btnManual;
        private System.Windows.Forms.RadioButton btnAuto;
        private System.Windows.Forms.PictureBox picDBoff;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox Data_listBox;
        private System.Windows.Forms.GroupBox grpAutoManual;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.PictureBox picDBon;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateText;
        private System.Windows.Forms.GroupBox grpWaterPump;
        private System.Windows.Forms.Button btnPumpOff;
        private System.Windows.Forms.Button btnPumpOn;
        private System.Windows.Forms.GroupBox grpFan;
        private System.Windows.Forms.Button btn_FanOff;
        private System.Windows.Forms.Button btn_FanAll;
        private System.Windows.Forms.Button btn_Fan_Lower;
        private System.Windows.Forms.Button btn_Fan_Upper;
        private System.Windows.Forms.GroupBox grpLED;
        private System.Windows.Forms.Button btnLamp3;
        private System.Windows.Forms.Button btnLamp2;
        private System.Windows.Forms.Button btnLampOff;
        private System.Windows.Forms.Button btnLamp1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTemp_in;
        private CircularProgressBar.CircularProgressBar TempProgressBar;
        private System.Windows.Forms.Label label32;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHumi_in;
        private CircularProgressBar.CircularProgressBar HumiProgressBar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label38;
        private VerticalProgressBar Water_Level_Bar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLight_in;
        private CircularProgressBar.CircularProgressBar LightProgressBar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCo2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWaterTemp;
        private CircularProgressBar.CircularProgressBar TankTempProgressBar1;
        private System.Windows.Forms.Label label33;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPumpSet;
        private System.Windows.Forms.Button btnSetCirculate;
        private System.Windows.Forms.Button btnSetLed;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

