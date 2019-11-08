﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IFirstService _iFirstService;
        public HelloController(IFirstService firstService)
        {
            _iFirstService = firstService;
        }

        [Route("SayHello/{id}")]
        public IActionResult SayHello(int id, string name, string age, string k)
        {
            var welcomeIstc = _iFirstService.WelcomeISTC();
            return Ok(welcomeIstc);
        }
    }

}