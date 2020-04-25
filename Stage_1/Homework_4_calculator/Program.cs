using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nPlease enter the second number: ");
            
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nPlease enter the operation type: ");
            string operationType = Console.ReadLine();
            
            double result = 0;
            if (operationType == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operationType == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operationType == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operationType == "/" && secondNumber !=0)
            {
                result = firstNumber / secondNumber;
            }
            else if (operationType == "%")
            {
                result = firstNumber % secondNumber;
            }
            else if (operationType == "^")
            {
                result = Math.Pow(firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Please enter a valid operation type");
            }
            Console.WriteLine($"\nYour result is: {Math.Abs(result)}");
            Console.ReadKey();




        }
    }
}
