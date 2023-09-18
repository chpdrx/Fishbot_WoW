using CSCore.CoreAudioAPI;
using Lowdps;
using System.Runtime.InteropServices;

public class DwarfTrip
{
    [DllImport("user32.dll")]
    static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
    [DllImport("user32.dll")]
    static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

    static int application_id = 0;
    float do_volume = 0.01f;
    IntPtr WindowToFind = FindWindow(null, "World of Warcraft");
    Random rnd = new();
    int counter = 0;
    int round_times = 25;
    int bobber_timer = 4601;
    static AudioSessionManager2 sessionManager = GetDefaultAudioSessionManager2();
    AudioMeterInformation audioMeterInformation;

    static AudioMeterInformation GetApp(AudioSessionManager2 sessionManager, int application_id)
    {
        var sessionEnumerator = sessionManager.GetSessionEnumerator();
        var audioMeterInformation = sessionEnumerator[application_id].QueryInterface<AudioMeterInformation>();
        return audioMeterInformation;
    }

    float GetVolume()
    {
        return audioMeterInformation.GetPeakValue();
    }

    static AudioSessionManager2 GetDefaultAudioSessionManager2()
    {
        using (var enumerator = new MMDeviceEnumerator())
        {
            using (var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia))
            {
                Console.WriteLine("DefaultDevice: " + device.FriendlyName);
                var sessionManager = AudioSessionManager2.FromMMDevice(device);
                return sessionManager;
            }
        }
    }

    void StartFishing()
    {
        Thread.Sleep(rnd.Next(300, 600));
        const int WM_SYSKEYDOWN = 0x0104;
        const int WM_KEYUP = 0x0101;
        const int VK_KEY_J = 0x4A;
        PostMessage(WindowToFind, WM_SYSKEYDOWN, VK_KEY_J, 0);
        Thread.Sleep(rnd.Next(30, 100));
        PostMessage(WindowToFind, WM_KEYUP, VK_KEY_J, 0);
        //Console.WriteLine("Start");
    }

    bool IsFished()
    {
        var volume = GetVolume();
        //Console.WriteLine(volume);
        if (volume > do_volume)
        {
            const int WM_SYSKEYDOWN = 0x0104;
            const int WM_KEYUP = 0x0101;
            const int VK_KEY_H = 0x48;
            Thread.Sleep(rnd.Next(200, 500));
            PostMessage(WindowToFind, WM_SYSKEYDOWN, VK_KEY_H, 0);
            Thread.Sleep(rnd.Next(30, 100));
            PostMessage(WindowToFind, WM_KEYUP, VK_KEY_H, 0);
            Thread.Sleep(rnd.Next(500, 800));
            counter++;
            //Console.WriteLine(counter);
            return true;
        }
        else return false;
    }

    private void MainCycle()
    {
        if (bobber_timer > rnd.Next(4500, 4600))
        {
            bobber_timer = 0;
            const int WM_SYSKEYDOWN = 0x0104;
            const int WM_KEYUP = 0x0101;
            const int VK_KEY_O = 0x4F;
            Thread.Sleep(rnd.Next(200, 500));
            PostMessage(WindowToFind, WM_SYSKEYDOWN, VK_KEY_O, 0);
            Thread.Sleep(rnd.Next(30, 100));
            PostMessage(WindowToFind, WM_KEYUP, VK_KEY_O, 0);
            Thread.Sleep(rnd.Next(1550, 2000));
        }

        bool canFish = true;

        round_times += 1;
        bobber_timer += 1;

        if (round_times > 30)
        {
            round_times = 0;
            StartFishing();
        }
        else
        {
            if (IsFished() && canFish)
            {
                canFish = false;
                round_times = 0;
                StartFishing();
            }
        }
        Data.Counter = counter;
        Thread.Sleep(700);
        if (!Data.StopTrip)
        {
            MainCycle();
        }  
    }

    public void MainJob(int channel_id, float volume)
    {
        audioMeterInformation = GetApp(sessionManager, channel_id);
        application_id = channel_id;
        do_volume = volume;
        MainCycle();
    }
}


