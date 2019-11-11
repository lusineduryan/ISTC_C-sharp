using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly ITime _iTimeService;
        private readonly ILogger _logger;
        public TimeController(ITime iTimeService, ILogger logger)
        {
            _iTimeService = iTimeService;
            _logger = logger;
        }

        [HttpGet]
        [Route("CurrentTime")]
        public IActionResult CurrentTime()
        {
            var time = _iTimeService.GetCurrentTime();
            _logger.LogInformation($"new time {time}");
            return Ok(time);
        }

        [HttpGet]
        [Route("Age")]
        public IActionResult Age()
        {
            var age = _iTimeService.GetAge();
            _logger.LogInformation($"new age {age}");
            return Ok(age);
        }
    }
}
