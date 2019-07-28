using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class WrongNumberException : Exception
    {
        public WrongNumberException(string message) : base(message)
        {
        }
    }
}
