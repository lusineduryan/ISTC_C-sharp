using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    interface Operations
    {
        double Sum(double number1, double number2);
        double Subtraction(double number1, double number2);
        double Product(double number1, double number2);
        double Division(double number1, double number2);
        double Module(double number);
    }
}
