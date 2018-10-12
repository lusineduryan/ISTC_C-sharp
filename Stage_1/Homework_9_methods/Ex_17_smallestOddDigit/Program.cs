using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17_smallestOddDigit
{
    class Program
    {
        /// <summary>
        /// calculates the smallest odd digit of a given natural number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int SmallestOddDigit(int number)
        {
            int minOddDigit = 9;
            int count = 0;
            for (int i = 0; (int) (number / Math.Pow(10, i)) != 0; i++)
            {
                int digit = (int) (number / Math.Pow(10, i) % 10);
                if (digit % 2 != 0 && digit < minOddDigit)
                {
                    minOddDigit = digit;
                    count++;
                }
            }
            return (count== 0)? 0 : minOddDigit;
        } 
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int smallestOddDigit = SmallestOddDigit(inputNumber);
            Console.WriteLine(smallestOddDigit == 0 ?$"No odd digit found.": $"The smallest odd digit is {smallestOddDigit}.");
            Console.ReadKey();
        }
    }
}
