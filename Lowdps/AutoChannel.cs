using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.CoreAudioAPI;
using System.Runtime.InteropServices;

namespace Lowdps
{
    internal class AutoChannel
    {
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        static AudioMeterInformation GetApp(AudioSessionManager2 sessionManager, int application_id)
        {
            var sessionEnumerator = sessionManager.GetSessionEnumerator();
            var audioMeterInformation = sessionEnumerator[application_id].QueryInterface<AudioMeterInformation>();
            return audioMeterInformation;
        }

        float GetVolume(AudioMeterInformation audioMeterInformation)
        {
            return audioMeterInformation.GetPeakValue();
        }

        static AudioSessionManager2 GetDefaultAudioSessionManager2()
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia))
                {
                    //Console.WriteLine("DefaultDevice: " + device.FriendlyName);
                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
            }
        }

        public void ChannelDetector()
        {
            //Console.WriteLine("Start Detector");
            AudioSessionManager2 sessionManager = GetDefaultAudioSessionManager2();
            var sessionEnumerator = sessionManager.GetSessionEnumerator();
            for (int app_id = 0; app_id < sessionEnumerator.Count; app_id++)
            {
                //Console.WriteLine("Channel: " + app_id);
                List<float> audio_picks = new List<float>();
                AudioMeterInformation audioMeterInformation = GetApp(sessionManager, app_id);
                for (int t = 0; t < 20; t++)
                {
                    float volume = GetVolume(audioMeterInformation);
                    //Console.WriteLine(volume);
                    audio_picks.Add(volume);
                    Thread.Sleep(5);
                }
                if ((audio_picks.Sum() > 0.0001f) && (audio_picks.Sum() < 50.0f)) Data.Channel_id = app_id;
            }
        }
    }
}
