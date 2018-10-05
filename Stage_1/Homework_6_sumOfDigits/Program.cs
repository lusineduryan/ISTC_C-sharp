using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_sumOfDigits
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter the input number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int firstAdd = inputNumber / 1000;
            int secondAdd = (inputNumber % 1000) / 100;
            int thirdAdd = ((inputNumber % 1000) % 100) / 10;
            int forthAdd = ((inputNumber % 1000) % 100) % 10;
            int sum = firstAdd + secondAdd + thirdAdd + forthAdd;

            Console.WriteLine($"Sum of digits is\n{sum}");
            Console.ReadKey();

        }
    }
}
