using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class Calculator<T> : ICalculator<T>
    {
        public T Add<T>(T number1, T number2)
        {
            return (dynamic)number1 + number2;
        }

        public T Divide<T>(T number1, T number2)
        {
            return (dynamic)number1 / number2;
        }

        public T Multiple<T>(T number1, T number2)
        {
            return (dynamic)number1 * number2;
        }

        public T SquareRoot<T>(T number1)
        {
            return Math.Sqrt((dynamic)number1);
        }

        public T Subtract<T>(T number1, T number2)
        {
            return (dynamic)number1 - number2;
        }
    }
}
