using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_18_sumOfOddDigitsExceeding4
{
    class Program
    {
        /// <summary>
        /// calculates the sum of all odd digits exceeding 4
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int SumOfOddDigitsExc4(int number)
        {
            int sum = 0;
            for (int i = 0; (int)(number / Math.Pow(10, i)) != 0; i++)
            {
                int digit = (int)(number / Math.Pow(10, i) % 10);
                if (digit % 2 != 0 && digit > 4)
                {
                    sum += digit;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int sumOfDigitsExc4 = SumOfOddDigitsExc4(inputNumber);
            Console.WriteLine($"Sum of the odd digits exceeding 4 is {sumOfDigitsExc4}.");
            Console.ReadKey();
        }
    }
}
