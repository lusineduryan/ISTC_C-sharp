using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static int Factorial (int number)
        {
            if (number == 1) return 1;
            return number * Factorial(number - 1);
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int factorialResult = Factorial(inputNumber);
            Console.WriteLine($"The factorial of {inputNumber} is {factorialResult}.");
            Console.ReadKey();
        }
    }
}
