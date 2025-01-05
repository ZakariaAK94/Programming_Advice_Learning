using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave.SampleProviders;

namespace TestAudioUsingAPI
{    
    public partial class Form1 : Form
    {
        private float _Volume;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _Volume = trackBar1.Value;
            label1.Text = "Volume "+_Volume.ToString()+"%";
            var volumeControl = new VolumeControl();
            volumeControl.SetVolume(_Volume / 100.0f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Volume 0%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text.Trim(), out _Volume) && _Volume >= 0 && _Volume <= 100)
            {
                label1.Text = "Volume " + _Volume.ToString() + "%";
                var volumeControl = new VolumeControl();
                volumeControl.SetVolume(_Volume / 100.0f);
                trackBar1.Enabled = false;
            }else
            {
                trackBar1_Scroll(null, null);
                trackBar1.Enabled=true;
            }
        }
    }

    public class VolumeControl
    {
        private MMDevice defaultDevice;

        public VolumeControl()
        {
            // Get the default playback device (usually speakers or headphones)
            var deviceEnumerator = new MMDeviceEnumerator();
            defaultDevice = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        }

        // Adjust volume by a certain amount (positive to increase, negative to decrease)
        public void AdjustVolume(float change)
        {
            float currentVolume = defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar;
            float newVolume = Clamp(currentVolume + change, 0.0f, 1.0f); // Ensure volume stays within 0-1
            defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = newVolume;
            Console.WriteLine($"Volume set to {newVolume * 100}%");
        }

        // Set volume to a specific level (normalized between 0 and 1)
        public void SetVolume(float volume)
        {
            float clampedVolume = Clamp(volume, 0.0f, 1.0f); // Ensure volume stays within 0-1
            defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = clampedVolume;
            Console.WriteLine($"Volume set to {clampedVolume * 100}%");
        }

        public float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
