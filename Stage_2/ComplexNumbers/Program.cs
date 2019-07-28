using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public struct ComplexNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }
        public ComplexNumber(double realPart, double imaginaryPart)
        {
            this.RealPart = realPart;
            this.ImaginaryPart = imaginaryPart;
        }

        public string number()
        {
            return $"{RealPart}+{ImaginaryPart}*i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber number1 = new ComplexNumber(0, 0);
            try
            {
               number1 = new ComplexNumber(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Please enter a number!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a double type number!");
            }
            ComplexNumber number2 = new ComplexNumber(0, 0);
            try
            {
               number2 = new ComplexNumber(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Please enter a number!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a double type number!");
            }

            OperationsClass operations = new OperationsClass();

            ComplexNumber sum = operations.Sum(number1, number2);
            ComplexNumber subtraction = operations.Subtraction(number1, number2);
            ComplexNumber product = operations.Product(number1, number2);
            ComplexNumber division = operations.Division(number1, number2);
            double module = operations.Module(number1);
            Console.ReadKey();

        }
    }
}
