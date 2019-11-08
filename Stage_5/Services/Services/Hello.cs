using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class Hello : IHello
    {
        public string SayHello()
        {
            return "Bonjour!";
        }
    }
}
