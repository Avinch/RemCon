using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RemCon.Server.Services;
using RemCon.Shared.Config;

namespace RemCon.Server.Controllers
{
    [ApiController]
    [Route("api/control")]
    public class ControlController : ControllerBase
    {
        private readonly ILogger<ControlController> _logger;
        private readonly ControlService _control;
        private readonly RemConConfig _config;

        public ControlController(ILogger<ControlController> logger, ControlService control, RemConConfig config)
        {
            _logger = logger;
            _control = control;
            _config = config;
        }

        [HttpGet("SetAudioDevice")]
        public IActionResult SetAudioDevice(string device)
        {
            _control.SetAudioDevice(device);
            return Ok();        
        }

        [HttpGet("SetVolume")]
        public IActionResult SetVolume(int volume)
        {
            _control.SetVolume(volume);
            return Ok();
        }
        
        [HttpGet("GetAudioDevices")]
        public IActionResult GetAudioDevices()
        {
            return Ok(_config.AudioDevices);
        }
    }
}
