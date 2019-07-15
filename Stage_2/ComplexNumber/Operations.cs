using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    public class Operations
    {
        public ComplexNumber Sum(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.RealPart + number2.ImaginaryPart, number2.RealPart + number2.ImaginaryPart);
        }
        public ComplexNumber Subtraction(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.RealPart - number2.ImaginaryPart, number2.RealPart - number2.ImaginaryPart);
        }
        public ComplexNumber Product(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.RealPart * number2.RealPart - number1.ImaginaryPart * number2.ImaginaryPart, number1.RealPart * number2.ImaginaryPart + number1.ImaginaryPart * number2.RealPart);
        }
        public ComplexNumber Division(ComplexNumber number1, ComplexNumber number2)
        {
            double ratio = 1 / (Math.Sqrt(number1.RealPart) + Math.Sqrt(number1.ImaginaryPart));
            return new ComplexNumber(ratio * (number2.RealPart * number1.RealPart + number2.ImaginaryPart * number1.ImaginaryPart), ratio * (number2.ImaginaryPart * number1.RealPart - number2.RealPart * number1.ImaginaryPart));
        }
        public double Module(ComplexNumber number)
        {
            return Math.Sqrt(number.RealPart * number.RealPart + number.ImaginaryPart * number.ImaginaryPart);
        }
    }
}
