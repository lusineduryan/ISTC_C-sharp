using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_25_maxPowerOf2SubceedingN
{
    class Program
    {
        /// <summary>
        /// gets the biggest power of 2 the subceeds the given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int GetBiggestPowerOf2SubNumber (uint number)
        {
            int biggestPowerOf2 = 0;
            for (int i = 1; Math.Pow(2,i) <= number; i++)
            {
                biggestPowerOf2 = i;
            }
            return biggestPowerOf2;
        }
        static void Main(string[] args)
        {
            uint inputNumber = Convert.ToUInt32(Console.ReadLine());
            int maxPowerOf2SubInputNumber = GetBiggestPowerOf2SubNumber(inputNumber);
            Console.WriteLine($"The biggest power of 2 subceeding {inputNumber} is {maxPowerOf2SubInputNumber}.");
            Console.ReadKey();
        }
    }
}
