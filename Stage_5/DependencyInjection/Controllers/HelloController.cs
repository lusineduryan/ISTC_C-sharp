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
    public class HelloController : ControllerBase
    {
        private readonly IHello _iHelloService;
        public HelloController(IHello iHelloService)
        {
            _iHelloService = iHelloService;
        }
        
        [HttpGet]
        [Route("Hello")]
        public IActionResult Hello()
        {
            var hello = _iHelloService.SayHello();
            return Ok(hello);
        }
    }
}
