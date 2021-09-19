using RemCon.Shared.Enums;
using RemCon.Shared.Extensions;
using System.Diagnostics;

namespace RemCon.Server.Services
{
    public class ControlService
    {

        private const string NirCmdPath =
            @"C:\nircmd\nircmd.exe";

        public void Lock()
        {
            SendCommand("lockws");
        }

        public void SetAudioDevice(AudioDevice device)
        {
            var deviceName = device.GetDescription();

            SendCommand($"setdefaultsounddevice \"{deviceName}\"");
        }

        public void SetVolume(int volume)
        {
            SendCommand($"setsysvolume {volume}");
        }

        private void SendCommand(string cmd)
        {
            Process.Start(NirCmdPath, cmd);
        } 
    }
}
