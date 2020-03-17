namespace DHT11APP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelConnection = new System.Windows.Forms.Panel();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ComboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.LabelBaudRate = new System.Windows.Forms.Label();
            this.ComboBoxPort = new System.Windows.Forms.ComboBox();
            this.ButtonScanPort = new System.Windows.Forms.Button();
            this.LabelConnectionTitle = new System.Windows.Forms.Label();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.PanelHumidity = new System.Windows.Forms.Panel();
            this.CircularProgressBarHumidity = new CircularProgressBar.CircularProgressBar();
            this.LabelHumidityTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTempMin = new System.Windows.Forms.Label();
            this.LabelTemperature = new System.Windows.Forms.Label();
            this.LabelTempMax = new System.Windows.Forms.Label();
            this.PictureBoxPBTemp = new System.Windows.Forms.PictureBox();
            this.PictureBoxPBTempBack = new System.Windows.Forms.PictureBox();
            this.LabelTemperatureTitle = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.PictureBoxStatusConnection = new System.Windows.Forms.PictureBox();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TimerSerial = new System.Windows.Forms.Timer(this.components);
            this.PanelConnection.SuspendLayout();
            this.PanelHumidity.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPBTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPBTempBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStatusConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelConnection
            // 
            this.PanelConnection.BackColor = System.Drawing.Color.White;
            this.PanelConnection.Controls.Add(this.ButtonConnect);
            this.PanelConnection.Controls.Add(this.ComboBoxBaudRate);
            this.PanelConnection.Controls.Add(this.LabelBaudRate);
            this.PanelConnection.Controls.Add(this.ComboBoxPort);
            this.PanelConnection.Controls.Add(this.ButtonScanPort);
            this.PanelConnection.Controls.Add(this.LabelConnectionTitle);
            this.PanelConnection.Controls.Add(this.ButtonDisconnect);
            this.PanelConnection.Location = new System.Drawing.Point(12, 12);
            this.PanelConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelConnection.Name = "PanelConnection";
            this.PanelConnection.Size = new System.Drawing.Size(488, 187);
            this.PanelConnection.TabIndex = 0;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(193)))), ((int)(((byte)(115)))));
            this.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(154)))), ((int)(((byte)(92)))));
            this.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(173)))), ((int)(((byte)(103)))));
            this.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnect.ForeColor = System.Drawing.Color.White;
            this.ButtonConnect.Location = new System.Drawing.Point(9, 126);
            this.ButtonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(463, 36);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.BackColor = System.Drawing.Color.DodgerBlue;
            this.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBaudRate.ForeColor = System.Drawing.Color.White;
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(348, 80);
            this.ComboBoxBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxBaudRate.TabIndex = 3;
            this.ComboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBaudRate_SelectedIndexChanged);
            this.ComboBoxBaudRate.Click += new System.EventHandler(this.ComboBoxBaudRate_Click);
            // 
            // LabelBaudRate
            // 
            this.LabelBaudRate.AutoSize = true;
            this.LabelBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaudRate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LabelBaudRate.Location = new System.Drawing.Point(249, 85);
            this.LabelBaudRate.Name = "LabelBaudRate";
            this.LabelBaudRate.Size = new System.Drawing.Size(89, 17);
            this.LabelBaudRate.TabIndex = 2;
            this.LabelBaudRate.Text = "Baud Rate:";
            // 
            // ComboBoxPort
            // 
            this.ComboBoxPort.BackColor = System.Drawing.Color.DodgerBlue;
            this.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPort.ForeColor = System.Drawing.Color.White;
            this.ComboBoxPort.FormattingEnabled = true;
            this.ComboBoxPort.Location = new System.Drawing.Point(116, 80);
            this.ComboBoxPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxPort.Name = "ComboBoxPort";
            this.ComboBoxPort.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxPort.TabIndex = 1;
            this.ComboBoxPort.DropDown += new System.EventHandler(this.ComboBoxPort_DropDown_1);
            this.ComboBoxPort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPort_SelectedIndexChanged);
            this.ComboBoxPort.Click += new System.EventHandler(this.ComboBoxPort_Click);
            // 
            // ButtonScanPort
            // 
            this.ButtonScanPort.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonScanPort.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(182)))));
            this.ButtonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonScanPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonScanPort.ForeColor = System.Drawing.Color.White;
            this.ButtonScanPort.Location = new System.Drawing.Point(9, 78);
            this.ButtonScanPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonScanPort.Name = "ButtonScanPort";
            this.ButtonScanPort.Size = new System.Drawing.Size(100, 30);
            this.ButtonScanPort.TabIndex = 1;
            this.ButtonScanPort.Text = "Scan Port";
            this.ButtonScanPort.UseVisualStyleBackColor = false;
            this.ButtonScanPort.Click += new System.EventHandler(this.ButtonScanPort_Click);
            // 
            // LabelConnectionTitle
            // 
            this.LabelConnectionTitle.AutoSize = true;
            this.LabelConnectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConnectionTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LabelConnectionTitle.Location = new System.Drawing.Point(172, 12);
            this.LabelConnectionTitle.Name = "LabelConnectionTitle";
            this.LabelConnectionTitle.Size = new System.Drawing.Size(122, 25);
            this.LabelConnectionTitle.TabIndex = 0;
            this.LabelConnectionTitle.Text = "Connection";
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.ButtonDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ButtonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ButtonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDisconnect.ForeColor = System.Drawing.Color.White;
            this.ButtonDisconnect.Location = new System.Drawing.Point(11, 126);
            this.ButtonDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(461, 36);
            this.ButtonDisconnect.TabIndex = 5;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = false;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // PanelHumidity
            // 
            this.PanelHumidity.BackColor = System.Drawing.Color.White;
            this.PanelHumidity.Controls.Add(this.CircularProgressBarHumidity);
            this.PanelHumidity.Controls.Add(this.LabelHumidityTitle);
            this.PanelHumidity.Location = new System.Drawing.Point(12, 206);
            this.PanelHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelHumidity.Name = "PanelHumidity";
            this.PanelHumidity.Size = new System.Drawing.Size(224, 194);
            this.PanelHumidity.TabIndex = 1;
            // 
            // CircularProgressBarHumidity
            // 
            this.CircularProgressBarHumidity.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CircularProgressBarHumidity.AnimationSpeed = 500;
            this.CircularProgressBarHumidity.BackColor = System.Drawing.Color.Transparent;
            this.CircularProgressBarHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CircularProgressBarHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            this.CircularProgressBarHumidity.InnerColor = System.Drawing.Color.White;
            this.CircularProgressBarHumidity.InnerMargin = 2;
            this.CircularProgressBarHumidity.InnerWidth = -1;
            this.CircularProgressBarHumidity.Location = new System.Drawing.Point(37, 38);
            this.CircularProgressBarHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CircularProgressBarHumidity.MarqueeAnimationSpeed = 2000;
            this.CircularProgressBarHumidity.Name = "CircularProgressBarHumidity";
            this.CircularProgressBarHumidity.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.CircularProgressBarHumidity.OuterMargin = -25;
            this.CircularProgressBarHumidity.OuterWidth = 26;
            this.CircularProgressBarHumidity.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            this.CircularProgressBarHumidity.ProgressWidth = 25;
            this.CircularProgressBarHumidity.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CircularProgressBarHumidity.Size = new System.Drawing.Size(149, 133);
            this.CircularProgressBarHumidity.StartAngle = 90;
            this.CircularProgressBarHumidity.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircularProgressBarHumidity.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CircularProgressBarHumidity.SubscriptText = "";
            this.CircularProgressBarHumidity.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircularProgressBarHumidity.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CircularProgressBarHumidity.SuperscriptText = "";
            this.CircularProgressBarHumidity.TabIndex = 2;
            this.CircularProgressBarHumidity.Text = "00%";
            this.CircularProgressBarHumidity.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.CircularProgressBarHumidity.Value = 68;
            // 
            // LabelHumidityTitle
            // 
            this.LabelHumidityTitle.AutoSize = true;
            this.LabelHumidityTitle.BackColor = System.Drawing.Color.White;
            this.LabelHumidityTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHumidityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            this.LabelHumidityTitle.Location = new System.Drawing.Point(61, 11);
            this.LabelHumidityTitle.Name = "LabelHumidityTitle";
            this.LabelHumidityTitle.Size = new System.Drawing.Size(95, 25);
            this.LabelHumidityTitle.TabIndex = 0;
            this.LabelHumidityTitle.Text = "Humidity";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LabelTempMin);
            this.panel1.Controls.Add(this.LabelTemperature);
            this.panel1.Controls.Add(this.LabelTempMax);
            this.panel1.Controls.Add(this.PictureBoxPBTemp);
            this.panel1.Controls.Add(this.PictureBoxPBTempBack);
            this.panel1.Controls.Add(this.LabelTemperatureTitle);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel1.Location = new System.Drawing.Point(241, 206);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 194);
            this.panel1.TabIndex = 2;
            // 
            // LabelTempMin
            // 
            this.LabelTempMin.AutoSize = true;
            this.LabelTempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTempMin.ForeColor = System.Drawing.Color.Silver;
            this.LabelTempMin.Location = new System.Drawing.Point(121, 155);
            this.LabelTempMin.Name = "LabelTempMin";
            this.LabelTempMin.Size = new System.Drawing.Size(32, 17);
            this.LabelTempMin.TabIndex = 5;
            this.LabelTempMin.Text = "-20";
            // 
            // LabelTemperature
            // 
            this.LabelTemperature.AutoSize = true;
            this.LabelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.LabelTemperature.Location = new System.Drawing.Point(121, 97);
            this.LabelTemperature.Name = "LabelTemperature";
            this.LabelTemperature.Size = new System.Drawing.Size(97, 25);
            this.LabelTemperature.TabIndex = 4;
            this.LabelTemperature.Text = "00.00 °C";
            // 
            // LabelTempMax
            // 
            this.LabelTempMax.AutoSize = true;
            this.LabelTempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTempMax.ForeColor = System.Drawing.Color.Silver;
            this.LabelTempMax.Location = new System.Drawing.Point(121, 46);
            this.LabelTempMax.Name = "LabelTempMax";
            this.LabelTempMax.Size = new System.Drawing.Size(26, 17);
            this.LabelTempMax.TabIndex = 3;
            this.LabelTempMax.Text = "60";
            // 
            // PictureBoxPBTemp
            // 
            this.PictureBoxPBTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.PictureBoxPBTemp.Location = new System.Drawing.Point(88, 64);
            this.PictureBoxPBTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxPBTemp.Name = "PictureBoxPBTemp";
            this.PictureBoxPBTemp.Size = new System.Drawing.Size(27, 103);
            this.PictureBoxPBTemp.TabIndex = 2;
            this.PictureBoxPBTemp.TabStop = false;
            // 
            // PictureBoxPBTempBack
            // 
            this.PictureBoxPBTempBack.Location = new System.Drawing.Point(88, 46);
            this.PictureBoxPBTempBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxPBTempBack.Name = "PictureBoxPBTempBack";
            this.PictureBoxPBTempBack.Size = new System.Drawing.Size(27, 121);
            this.PictureBoxPBTempBack.TabIndex = 1;
            this.PictureBoxPBTempBack.TabStop = false;
            // 
            // LabelTemperatureTitle
            // 
            this.LabelTemperatureTitle.AutoSize = true;
            this.LabelTemperatureTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTemperatureTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.LabelTemperatureTitle.Location = new System.Drawing.Point(35, 11);
            this.LabelTemperatureTitle.Name = "LabelTemperatureTitle";
            this.LabelTemperatureTitle.Size = new System.Drawing.Size(135, 25);
            this.LabelTemperatureTitle.TabIndex = 0;
            this.LabelTemperatureTitle.Text = "Temperature";
            // 
            // Chart1
            // 
            chartArea13.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            chartArea13.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea13.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea13.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea13.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            chartArea13.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea13.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea13.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            chartArea13.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea13);
            legend13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            legend13.IsTextAutoFit = false;
            legend13.Name = "Legend1";
            this.Chart1.Legends.Add(legend13);
            this.Chart1.Location = new System.Drawing.Point(507, 12);
            this.Chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chart1.Name = "Chart1";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            series13.Legend = "Legend1";
            series13.Name = "Humidity       ";
            this.Chart1.Series.Add(series13);
            this.Chart1.Size = new System.Drawing.Size(588, 187);
            this.Chart1.TabIndex = 3;
            this.Chart1.Text = "chart1";
            // 
            // Chart2
            // 
            chartArea14.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            chartArea14.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea14.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea14.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea14.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            chartArea14.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea14.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea14.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(180)))), ((int)(((byte)(249)))));
            chartArea14.Name = "ChartArea1";
            this.Chart2.ChartAreas.Add(chartArea14);
            legend14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            legend14.IsTextAutoFit = false;
            legend14.Name = "Legend1";
            this.Chart2.Legends.Add(legend14);
            this.Chart2.Location = new System.Drawing.Point(507, 206);
            this.Chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chart2.Name = "Chart2";
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            series14.Legend = "Legend1";
            series14.Name = "Temperature";
            this.Chart2.Series.Add(series14);
            this.Chart2.Size = new System.Drawing.Size(588, 194);
            this.Chart2.TabIndex = 4;
            this.Chart2.Text = "chart2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(968, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(968, 250);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(8, 416);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(126, 17);
            this.LabelStatus.TabIndex = 7;
            this.LabelStatus.Text = "Status: Disconnect";
            // 
            // PictureBoxStatusConnection
            // 
            this.PictureBoxStatusConnection.BackColor = System.Drawing.Color.Red;
            this.PictureBoxStatusConnection.Location = new System.Drawing.Point(145, 417);
            this.PictureBoxStatusConnection.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxStatusConnection.Name = "PictureBoxStatusConnection";
            this.PictureBoxStatusConnection.Size = new System.Drawing.Size(13, 15);
            this.PictureBoxStatusConnection.TabIndex = 8;
            this.PictureBoxStatusConnection.TabStop = false;
            // 
            // TimerSerial
            // 
            this.TimerSerial.Tick += new System.EventHandler(this.TimerSerial_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 443);
            this.Controls.Add(this.PictureBoxStatusConnection);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Chart2);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelHumidity);
            this.Controls.Add(this.PanelConnection);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelConnection.ResumeLayout(false);
            this.PanelConnection.PerformLayout();
            this.PanelHumidity.ResumeLayout(false);
            this.PanelHumidity.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPBTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPBTempBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStatusConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelConnection;
        private System.Windows.Forms.Button ButtonScanPort;
        private System.Windows.Forms.Label LabelConnectionTitle;
        private System.Windows.Forms.ComboBox ComboBoxPort;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.ComboBox ComboBoxBaudRate;
        private System.Windows.Forms.Label LabelBaudRate;
        private System.Windows.Forms.Panel PanelHumidity;
        private System.Windows.Forms.Label LabelHumidityTitle;
        private CircularProgressBar.CircularProgressBar CircularProgressBarHumidity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTempMin;
        private System.Windows.Forms.Label LabelTemperature;
        private System.Windows.Forms.Label LabelTempMax;
        private System.Windows.Forms.PictureBox PictureBoxPBTemp;
        private System.Windows.Forms.PictureBox PictureBoxPBTempBack;
        private System.Windows.Forms.Label LabelTemperatureTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.PictureBox PictureBoxStatusConnection;
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.Timer TimerSerial;
    }
}

