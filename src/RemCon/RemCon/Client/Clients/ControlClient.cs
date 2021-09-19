using RemCon.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RemCon.Client.Clients
{
    public class ControlClient
    {
        private readonly HttpClient _http;

        public ControlClient(HttpClient http)
        {
            _http = http;
        }

        public async Task SetDevice(AudioDevice device)
        {
            await _http.GetAsync($"api/control/SetAudioDevice?device={device}");
        }

        public async Task SetVolume(int volume)
        {
            await _http.GetAsync($"api/control/SetVolume?volume={volume}");
        }
    }
}
