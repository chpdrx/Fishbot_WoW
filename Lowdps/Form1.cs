using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.CoreAudioAPI;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;
using Microsoft.Win32;

namespace Lowdps
{
    public partial class Form1 : Form
    {
        int channel_id;
        private Timer holder;
        float volume;

        public Form1()
        {
            InitializeComponent();

            holder = new Timer { Interval = 10000 };
            holder.Tick += CountLabel_Click;
            holder.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChannelDetect_Click(object sender, EventArgs e)
        {
            var channelDetect = new AutoChannel();
            Task.Run(() => channelDetect.ChannelDetector());
            channel_id = Data.Channel_id;
            ChannelBox.Text = channel_id.ToString();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var job = new DwarfTrip();
            channel_id = int.Parse(ChannelBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            volume = float.Parse(VolumeBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            Task.Run(() => job.MainJob(channel_id, volume));
        }

        public void CountLabel_Click(object sender, EventArgs e)
        {
            CountLabel.Text = Data.Counter.ToString();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Data.StopTrip = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}