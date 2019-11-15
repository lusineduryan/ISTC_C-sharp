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
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _iCalcService;

        public CalculatorController(ICalculator iCalcService)
        {
            _iCalcService = iCalcService;
        }

        [HttpGet]
        [Route("Add/{number1:double}/{number2:double}")]
        public IActionResult Add(double number1, double number2)
        {
            var sum = _iCalcService.Add(number1, number2);
            return Ok(sum);
        }

        [HttpGet]
        [Route("Subtract/{number1:double}/{number2:double}")]
        public IActionResult Subtract(double number1, double number2)
        {
            var subtraction = _iCalcService.Subtract(number1, number2);
            return Ok(subtraction);
        }

        [HttpGet]
        [Route("Divide/{number1:double}/{number2:double}")]
        public IActionResult Divide(double number1, double number2)
        {
            var division = _iCalcService.Divide(number1, number2);
            return Ok(division);
        }

        [HttpGet]
        [Route("Multiple/{number1:double}/{number2:double}")]
        public IActionResult Multiple(double number1, double number2)
        {
            var product = _iCalcService.Multiple(number1, number2);
            return Ok(product);
        }

        [HttpGet]
        [Route("SquareRoot/{number1:double}")]
        public IActionResult SquareRoot(double number1)
        {
            
            var sqRoot = _iCalcService.SquareRoot(number1);
            return Ok(sqRoot);
        }
    }
}
