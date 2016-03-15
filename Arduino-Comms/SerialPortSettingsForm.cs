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


namespace Arduino_Comms
{
    public partial class SerialPortSettingsForm : Form
    {
        SerialPortManager _spManager;
        public SerialPortSettingsForm()
        {
            InitializeComponent();

            UserInitialization();
        }

        private void UserInitialization()
        {
            _spManager = new SerialPortManager();
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
            serialSettingsBindingSource.DataSource = mySerialSettings;
            portNameComboBox.DataSource = mySerialSettings.PortNameCollection;
            baudRateComboBox.DataSource = mySerialSettings.BaudRateCollection;
            dataBitsComboBox.DataSource = mySerialSettings.DataBitsCollection;
            parityComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.Parity));
            stopBitsComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.StopBits));
            

            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spManager.Dispose();
        }

        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
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
            //tbData.AppendText(str);
            //tbData.ScrollToCaret();

        }

        // Handles the "Start Listening"-buttom click event
        private void btnStart_Click(object sender, EventArgs e)
        {
            _spManager.StartListening();
        }

        // Handles the "Stop Listening"-buttom click event
        private void btnStop_Click(object sender, EventArgs e)
        {
            _spManager.StopListening();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _spManager.SaveSettings();
        }

        private void FrequencyTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FrequencyTackbar.Value = Convert.ToInt32(FrequencyTextbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Value out of bounds");
            }
        }

        private void FrequencyTackbar_Scroll(object sender, EventArgs e)
        {
            try
            {
                FrequencyTextbox.Text = Convert.ToString(FrequencyTackbar.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Value out of bounds");
            }
        }

        private void FrequencyTextbox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                FrequencyTackbar.Value = Convert.ToInt32(FrequencyTextbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Value out of bounds");
            }
        }


    }

    

}
