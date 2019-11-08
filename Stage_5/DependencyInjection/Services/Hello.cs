using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class Hello : IHello
    {
        public string HelloMsg { get; set; }

        public Hello()
        {
            HelloMsg = "Bonjour!";
        }
        public string SayHello()
        {
            return HelloMsg;
        }
    }
}
