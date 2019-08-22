using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersArray = { 1.2, 1.5, 2.5, 2.8, 3, 3.9, 8, 10, 15, 20, 25 };
            Console.Write("Please input a number between 1 and 30: ");
            double inputNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Numbers.FindNearestNumber(numbersArray, inputNumber));
            Console.ReadKey();
        }
    }
}
