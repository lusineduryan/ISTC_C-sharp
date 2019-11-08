using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Services;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly ITime _iTimeService;
        public TimeController(ITime iTimeService)
        {
            _iTimeService = iTimeService;
        }

        [HttpGet]
        [Route("CurrentTime")]
        public IActionResult CurrentTime()
        {
            var age = _iTimeService.GetCurrentTime();
            return Ok(age);
        }

        [HttpGet]
        [Route("Age")]
        public IActionResult Age()
        {
            var age = _iTimeService.GetAge();
            return Ok(age);
        }
    }
}
