using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RemCon.Server.Services;
using RemCon.Shared;
using RemCon.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemCon.Server.Controllers
{
    [ApiController]
    [Route("api/control")]
    public class ControlController : ControllerBase
    {
        private readonly ILogger<ControlController> _logger;
        private readonly ControlService _control;

        public ControlController(ILogger<ControlController> logger, ControlService control)
        {
            _logger = logger;
            _control = control;
        }

        [HttpGet("SetAudioDevice")]
        public IActionResult SetAudioDevice(AudioDevice device)
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
    }
}
