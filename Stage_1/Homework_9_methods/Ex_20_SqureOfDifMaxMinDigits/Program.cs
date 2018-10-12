using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_20_SqureOfDifMaxMinDigits
{
    class Program
    {
        /// <summary>
        /// calculates the difference of the biggest and smallest digits squared
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int SquareOfDifOfMaxMinDigits (int number)
        {
            int difference = 0;
            int minDigit = number / 10 % 10;
            int maxDigit = number / 10 % 10;
            for (int i = 0; (int)(number / Math.Pow(10, i)) != 0; i++)
            {
                int digit = (int)(number / Math.Pow(10, i) % 10);
                
                if (digit >= maxDigit)
                {
                    maxDigit = digit;
                }
                if (digit <= minDigit)
                {
                    minDigit = digit;
                }
                difference = maxDigit - minDigit;
            }
            return (int) Math.Pow(difference, 2);
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int squareDifMaxMinDigits = SquareOfDifOfMaxMinDigits(inputNumber);
            Console.WriteLine($"The Square of the difference of max & min digits is {squareDifMaxMinDigits}.");
            Console.ReadKey();
        }
    }
}
