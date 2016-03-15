using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialPortListener.Serial;
using CoreAudioApi.Interfaces;
using CoreAudioApi;
using CoreAudioSample;

namespace Arduino_Comms
{
    public partial class MainForm : Form
    {
        SerialPortManager _spManager;
        private MMDevice device;
        private Color RGBColor = Color.Red;
        
        public MainForm()
        {
            InitializeComponent();

            UserInitialization();

            InitializeAudio();

        }

        private void InitializeAudio()
        {
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
           
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            UserInitialization();
            _spManager.StartListening();
        }

        private void PortSettingsButton_Click(object sender, EventArgs e)
        {
            SerialPortSettingsForm settingsform = new SerialPortSettingsForm();
            settingsform.ShowDialog();

        }

        private void UserInitialization()
        {
            _spManager = new SerialPortManager();
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;

            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spManager.Dispose();
        }

        private void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }

            //int maxTextLength = 1000; // maximum text length in text box
            //if (tbData.TextLength > maxTextLength)
            //    tbData.Text = tbData.Text.Remove(0, tbData.TextLength - maxTextLength);

            // This application is connected to a GPS sending ASCCI characters, so data is converted to text
            string str = Encoding.ASCII.GetString(e.Data);
            textBox1.AppendText (str) ;
            ReceivingDataLabel.ForeColor = System.Drawing.Color.Green;
            ReceivingDataTimer.Enabled = true;
            //tbData.AppendText(str);
            //tbData.ScrollToCaret();

        }

        private void StartSendData_Click(object sender, EventArgs e)
        {

            if (SoundRadioButton.Checked == true)
            {
                ReadVolumeLevelTimer.Interval = _spManager.CurrentSerialSettings.FrequencySend;
                ReadVolumeLevelTimer.Start();

                String OffPeak = Arduino_Comms.Properties.Settings.Default._OffPeak.ToString().PadLeft(3, '0');
                String OnPeak = Arduino_Comms.Properties.Settings.Default._OnPeak.ToString().PadLeft(3, '0');
                _spManager.WriteLine("PN: " + OnPeak);
                _spManager.WriteLine("PF: " + OffPeak);
            }
            else if (OnRadioButton.Checked == true)
            {
                _spManager.WriteLine("ON");
                ReadVolumeLevelTimer.Stop();
            }
            else if (OffRadioButton.Checked == true)
            {
                _spManager.WriteLine("OFF");
                ReadVolumeLevelTimer.Stop();
            }
            else if (DimRadioButton.Checked ==true)
            {
                _spManager.WriteLine("DIM:" + DimTrackBar.Value);
                ReadVolumeLevelTimer.Stop();
            }
        }

        private void ReadVolumeLevelTimer_Tick(object sender, EventArgs e)
        {

            string currentLevel = Convert.ToString((int)(device.AudioMeterInformation.MasterPeakValue * 100));
            _spManager.WriteLine("V: " + currentLevel);
            //pkMaster.Value = (int)(device.AudioMeterInformation.MasterPeakValue * 100);
            //pkLeft.Value = (int)(device.AudioMeterInformation.PeakValues[0]*100);
            //pkRight.Value = (int)(device.AudioMeterInformation.PeakValues[1]* 100);
        
        }

        private void ReceivingDataTimer_Tick(object sender, EventArgs e)
        {
            ReceivingDataLabel.ForeColor = System.Drawing.Color.Red;
            ReceivingDataTimer.Enabled = false;
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            _spManager.StopListening();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VolumeSettingsForm VolumeSettings = new VolumeSettingsForm();
            VolumeSettings.ShowDialog();
        }
        private void StopSendButton_Click(object sender, EventArgs e)
        {
            ReadVolumeLevelTimer.Stop();
        }
        
        private void DimTrackBar_Scroll(object sender, EventArgs e)
        {
            if (DimRadioButton.Checked == true)
            {
                _spManager.WriteLine("DIM: " + DimTrackBar.Value.ToString().PadLeft(3, '0'));
            }
        }


        private void ChooseColorButton_Click(object sender, EventArgs e)
        {
            if (rgbColorDialog.ShowDialog() == DialogResult.OK)
            {
                RGBColor = rgbColorDialog.Color;

                String r = String.Empty;
                String g = String.Empty;
                String b = String.Empty;
                try
                {

                    r = RGBColor.R.ToString().PadLeft(3, '0'); 
                    g = RGBColor.G.ToString().PadLeft(3, '0'); 
                    b = RGBColor.B.ToString().PadLeft(3, '0'); 


                    //MessageBox.Show("Red :" + r + ", Green :" + g + ", Blue :" + b);
                    SelectedColorRadioButton.Checked = true;

                }
                catch (Exception ex)
                {
                    //doing nothing
                }
            }
            

        }

        private void SetColorButton_Click(object sender, EventArgs e)
        {
            if (AutoChangeRadioButton.Checked == true)
            {
                _spManager.WriteLine("RGB:Auto");
            }
            else if (SelectedColorRadioButton.Checked == true)
            {
                _spManager.WriteLine("SET RGB");
                _spManager.WriteLine("RGB:R:" + RGBColor.R.ToString());
                _spManager.WriteLine("RGB:G:" + RGBColor.G.ToString());
                _spManager.WriteLine("RGB:B:" + RGBColor.B.ToString());
            }
            
        }

    }
}
