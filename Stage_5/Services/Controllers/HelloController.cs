using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IHello _iHelloService;
        public HelloController(Hello iHelloService)
        {
            _iHelloService = iHelloService;
        }

        [Route("Hello")]
        public IActionResult Hello()
        {
            var hello = _iHelloService.SayHello();
            return Ok(hello);
        }
    }
}
