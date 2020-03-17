using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Timers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic;

namespace DHT11APP
{
    public partial class Form1 : Form
    {
        private int vpb_sy, vpb_ly;
        private int TempL, HumL;
        private string Temp, Hum, TempResult, HumResult;
        private float TempToProgressBar;
        private int ChartLimit = 30;
        private string StrSerialIn, StrSerialInRam;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            PanelConnection.Focus();
            TimerSerial.Stop();
            SerialPort1.Close();
            ButtonDisconnect.SendToBack();
            ButtonConnect.BringToFront();
            LabelStatus.Text = "Status : Disconnect";
            PictureBoxStatusConnection.Visible = true;
            PictureBoxStatusConnection.BackColor = Color.Red;
        }

        private void TimerSerial_Tick(object sender, EventArgs e)
        {
            try
            {
                StrSerialIn = SerialPort1.ReadExisting();  // --> Read incoming serial data
                var TB = new TextBox();
                TB.Multiline = true;
                TB.Text = StrSerialIn;   // --> Enter serial data into the textbox
                if (TB.Lines.Count() > 0)
                {
                    if (TB.Lines[0] == "Failed to read from DHT sensor!") // --> Check Arduino if it fails to read the DHT sensor, if this happens the connection is disconnected
                    {
                        TimerSerial.Stop();
                        SerialPort1.Close();
                        LabelStatus.Text = "Status : Disconnect";
                        ButtonDisconnect.SendToBack();
                        ButtonConnect.BringToFront();
                        PictureBoxStatusConnection.Visible = true;
                        PictureBoxStatusConnection.BackColor = Color.Red;
                        MessageBox.Show("Failed to read from DHT sensor !!!, Please check the Hardware and Please connect again.", MessageBoxButtons.OK.ToString());
                        return;
                    }



                    StrSerialInRam = TB.Lines[0].Substring(0, 1);
                    if ((StrSerialInRam ?? "") == "H")
                    {
                        Hum = TB.Lines[0];
                        HumL = Hum.Length;
                    }
                    else
                    {
                        Hum = Hum;
                    }

                    StrSerialInRam = TB.Lines[1].Substring(0, 1);
                    if ((StrSerialInRam ?? "") == "T")
                    {
                        Temp = TB.Lines[1];
                        TempL = Temp.Length;
                    }
                    else
                    {
                        Temp = Temp;
                    }

                    HumResult = Strings.Mid(Hum, 2, HumL);
                    TempResult = Strings.Mid(Temp, 2, TempL);
                    TempToProgressBar = Conversions.ToSingle(TempResult);
                    CircularProgressBarHumidity.Value = Convert.ToInt32(HumResult);
                    CircularProgressBarHumidity.Text = CircularProgressBarHumidity.Value + " %";
                    LabelTemperature.Text = TempResult + " °C";

                    // -----------The process for making a progress bar using a picturebox (Vertical progress bar)-----------
                    vpb_sy = this.Map(TempToProgressBar, -20.0f, 60.0f, (float)0, (float)120);
                    if (vpb_sy > 120)
                    {
                        vpb_sy = 120;
                    }

                    if (vpb_sy < 0)
                    {
                        vpb_sy = 0;
                    }

                    PictureBoxPBTemp.Height = PictureBoxPBTempBack.Height * vpb_sy / 120;
                    vpb_ly = PictureBoxPBTempBack.Height - vpb_sy + PictureBoxPBTempBack.Location.Y;
                    PictureBoxPBTemp.Location = new Point(PictureBoxPBTemp.Location.X, vpb_ly);
                    // ------------------------------------------------------------------------------------------------------

                    // -----------Enter the temperature and humidity values into the chart-----------------------------------
                    Chart1.Series["Humidity       "].Points.AddY(HumResult);
                    if (Chart1.Series[0].Points.Count == ChartLimit)
                    {
                        Chart1.Series[0].Points.RemoveAt(0);
                    }

                    Chart2.Series["Temperature"].Points.AddY(TempResult);
                    if (Chart2.Series[0].Points.Count == ChartLimit)
                    {
                        Chart2.Series[0].Points.RemoveAt(0);
                    }
                    // ------------------------------------------------------------------------------------------------------

                    // -----------If the Then connection Is successful And running, PictureBoxStatusConnection will blink----
                    if (PictureBoxStatusConnection.Visible == true)
                    {
                        PictureBoxStatusConnection.Visible = false;
                    }
                    else if (PictureBoxStatusConnection.Visible == false)
                    {
                        PictureBoxStatusConnection.Visible = true;
                    }
                    // ------------------------------------------------------------------------------------------------------
                }
            }
            catch (Exception ex)
            {
                TimerSerial.Stop();
                SerialPort1.Close();
                LabelStatus.Text = "Status : Disconnect";
                ButtonDisconnect.SendToBack();
                ButtonConnect.BringToFront();
                PictureBoxStatusConnection.BackColor = Color.Red;
                MessageBox.Show("Please check the Hardware and Please connect again." + ex.Message);
                return;
            
            }
         }

        private void ComboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelConnection.Focus();
        }

        private void ComboBoxPort_Click(object sender, EventArgs e)
        {
            if (LabelStatus.Text == "Status : Connected")
            {
                MessageBox.Show("Conncetion in progress, please Disconnect to change COM.", MessageBoxButtons.OK.ToString());
                return;
            }
        }

        private void ComboBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelConnection.Focus();
        }

        private void ComboBoxBaudRate_Click(object sender, EventArgs e)
        {
            if (LabelStatus.Text == "Status : Connected")
            {
                MessageBox.Show("Conncetion in progress, please Disconnect to change Baud Rate.", MessageBoxButtons.OK.ToString());
                return;
            }
        }

        private void ComboBoxPort_DropDown_1(object sender, EventArgs e)
        {
            PanelConnection.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            PanelConnection.Focus();
            CircularProgressBarHumidity.Value = 0;
            ComboBoxBaudRate.SelectedIndex = 0;
            for (int i = 0; i <= 30; i += 1)
            {
                Chart1.Series["Humidity       "].Points.AddY(0);
                if (Chart1.Series[0].Points.Count == ChartLimit)
                {
                    Chart1.Series[0].Points.RemoveAt(0);
                }

                Chart2.Series["Temperature"].Points.AddY(0);
                if (Chart2.Series[0].Points.Count == ChartLimit)
                {
                    Chart2.Series[0].Points.RemoveAt(0);
                }
            }

            Chart1.ChartAreas[0].AxisY.Maximum = 180;
            Chart1.ChartAreas[0].AxisY.Minimum = -20;
            Chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            Chart2.ChartAreas[0].AxisY.Maximum = 70;
            Chart2.ChartAreas[0].AxisY.Minimum = -30;
            Chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            PictureBoxPBTemp.Height = 0;
        }

       

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            PanelConnection.Focus();
            try
            {
                SerialPort1.BaudRate = Convert.ToInt32(ComboBoxBaudRate.SelectedItem);
                SerialPort1.PortName = ComboBoxPort.SelectedItem.ToString();
                SerialPort1.Open();
                TimerSerial.Start();
                LabelStatus.Text = "Status : Connected";
                ButtonConnect.SendToBack();
                ButtonDisconnect.BringToFront();
                PictureBoxStatusConnection.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the Hardware, COM, Baud Rate and try again.", ex.Message);
            }
        }

      

        private void ButtonScanPort_Click(object sender, EventArgs e)
        {
            PanelConnection.Focus();
            if (LabelStatus.Text == "Status : Connected")
            {
                MessageBox.Show("Conncetion in progress, please Disconnect to scan the new port.", MessageBoxButtons.OK.ToString());
                return;
            }

            ComboBoxPort.Items.Clear();
            Array myPort;
            int i;
            myPort = System.IO.Ports.SerialPort.GetPortNames();
            ComboBoxPort.Items.AddRange((object[])myPort);
            i = ComboBoxPort.Items.Count;
            i = i - i;
            try
            {
                ComboBoxPort.SelectedIndex = i;
                ButtonConnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Com port not detected", ex.Message);
                ComboBoxPort.Text = "";
                ComboBoxPort.Items.Clear();
                return;
            }

            ComboBoxPort.DroppedDown = true;
        }
      
       
        public int Map(float X, float In_min, float In_max, float Out_min, float Out_max)
        {
            int MapVPBRet = default(int);
            float A;
            float B;
            A = X - In_min;
            B = Out_max - Out_min;
            A = A * B;
            B = In_max - In_min;
            A = A / B;
            MapVPBRet = (int)(A + Out_min);
            return MapVPBRet;
        }
       
    }
}
