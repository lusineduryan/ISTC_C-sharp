using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface ICalculator<T>
    {
        T Add<T> (T number1, T number2);
        T Subtract<T>(T number1, T number2);
        T Multiple<T>(T number1, T number2);
        T Divide<T>(T number1, T number2);
        T SquareRoot<T>(T number1);
    }
}
