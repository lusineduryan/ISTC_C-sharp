using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_14_twiceSumOfDigits
{
    class Program
    {
        static void EqualToDoubleSumOfDigits(int number)
        {
            int sum = 0;
            for (int i = 0; (int)(number / Math.Pow(10, i)) != 0; i++)
            {
                sum += (int)(number / Math.Pow(10, i) % 10);
            }
            Console.WriteLine(number == 2 * sum ? "yes" : "no");
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            EqualToDoubleSumOfDigits(inputNumber);
            Console.ReadKey();
        }
    }
}