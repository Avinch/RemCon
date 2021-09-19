using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
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

        public async Task SetDevice(string device)
        {
            await _http.GetAsync($"api/control/SetAudioDevice?device={device}");
        }

        public async Task SetVolume(int volume)
        {
            await _http.GetAsync($"api/control/SetVolume?volume={volume}");
        }
        
        public async Task<List<string>> GetAudioDevices()
        {
            var result = await _http.GetFromJsonAsync<List<string>>($"api/control/GetAudioDevices");
            return result;
        }
    }
}
