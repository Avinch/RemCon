using System.Diagnostics;
using RemCon.Shared.Config;

namespace RemCon.Server.Services
{
    public class ControlService
    {
        private readonly RemConConfig _config;
        
        public ControlService(RemConConfig config)
        {
            _config = config;
        }
        
        public void Lock()
        {
            SendCommand("lockws");
        }

        public void SetAudioDevice(string device)
        {
            SendCommand($"setdefaultsounddevice \"{device}\"");
        }

        public void SetVolume(int volume)
        {
            SendCommand($"setsysvolume {volume}");
        }

        private void SendCommand(string cmd)
        {
            Process.Start(_config.NirCmdExeLocation, cmd);
        } 
    }
}
