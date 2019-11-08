using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public interface ICalculator
    {
        double Add(double number1, double number2);
        double Subtract(double number1, double number2);
        double Multiple(double number1, double number2);
        double Divide(double number1, double number2);
        double SquareRoot(double number1);
    }
}
