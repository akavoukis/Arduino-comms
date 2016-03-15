using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoreAudioApi;



namespace CoreAudioSample
{
    public partial class VolumeSettingsForm : Form
    {
        private MMDevice device;



        public VolumeSettingsForm()
        {
            InitializeComponent();
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
            tbMaster.Value = (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            device.AudioEndpointVolume.OnVolumeNotification += new AudioEndpointVolumeNotificationDelegate(AudioEndpointVolume_OnVolumeNotification);
            timer1.Enabled = true;

            tbOffSet.Value = Arduino_Comms.Properties.Settings.Default._OffPeak;
            tbOnSet.Value = Arduino_Comms.Properties.Settings.Default._OnPeak;
            OnPeaktextBox1.Text  = Arduino_Comms.Properties.Settings.Default._OnPeak.ToString();
            OffPeaktextBox2.Text = Arduino_Comms.Properties.Settings.Default._OffPeak.ToString();

            
        }

        void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data)
        {
            if (this.InvokeRequired)
            {
                object[] Params = new object[1];
                Params[0] = data;
                this.Invoke(new AudioEndpointVolumeNotificationDelegate(AudioEndpointVolume_OnVolumeNotification), Params);
            }
            else
            {
                tbMaster.Value = (int)(data.MasterVolume * 100);
            }
        }

        private void tbMaster_Scroll(object sender, EventArgs e)
        {
            device.AudioEndpointVolume.MasterVolumeLevelScalar = ((float)tbMaster.Value / 100.0f);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pkMaster.Value = (int)(device.AudioMeterInformation.MasterPeakValue * 100);
            pkLeft.Value = (int)(device.AudioMeterInformation.PeakValues[0] * 100);
            pkRight.Value = (int)(device.AudioMeterInformation.PeakValues[1] * 100);
        }

        private void tbOnSet_Scroll(object sender, EventArgs e)
        {
            if (tbOnSet.Value < tbOffSet.Value )
            {
                if (tbOnSet.Value == tbOnSet.Minimum)
                {
                    tbOffSet.Value = tbOnSet.Minimum;
                }
                else
                {
                    tbOffSet.Value = tbOnSet.Value - 1;
                }               
            }
            OnPeaktextBox1.Text = tbOnSet.Value.ToString();
        }

        private void tbOffSet_Scroll(object sender, EventArgs e)
        {
            if ( tbOffSet.Value > tbOnSet.Value )
            {
                if (tbOffSet.Value == tbOffSet.Maximum)
                {
                    tbOnSet.Value = tbOffSet.Maximum;
                }
                else
                {
                    tbOnSet.Value = tbOffSet.Value + 1;
                }
            }
            OffPeaktextBox2.Text = tbOffSet.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arduino_Comms.Properties.Settings.Default._OffPeak = tbOffSet.Value;
            Arduino_Comms.Properties.Settings.Default._OnPeak = tbOnSet.Value;
            Arduino_Comms.Properties.Settings.Default.Save();
        }



    }
}