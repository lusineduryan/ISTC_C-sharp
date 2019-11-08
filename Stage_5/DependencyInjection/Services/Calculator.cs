using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class Calculator : ICalculator
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Divide(double number1, double number2)
        {
            return number1 / number2;
        }

        public double Multiple(double number1, double number2)
        {
            return number1 * number2;
        }

        public double SquareRoot(double number1)
        {
            return Math.Sqrt(number1);
        }

        public double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}
