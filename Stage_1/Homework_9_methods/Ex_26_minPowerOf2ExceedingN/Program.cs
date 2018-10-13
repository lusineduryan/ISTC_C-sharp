using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_26_minPowerOf2ExceedingN
{
    class Program
    {
        /// <summary>
        /// gets the smallest power of 2 that exceeds the gived number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int GetSmallestPowerOf2ExcNumber(uint number)
        {
            int biggestPowerOf2 = 0;
            for (int i = 1; Math.Pow(2, i) <= number; i++)
            {
                biggestPowerOf2 = i;
            }
            return biggestPowerOf2 + 1;
        }
        static void Main(string[] args)
        {
            uint inputNumber = Convert.ToUInt32(Console.ReadLine());
            int minPowerOf2ExcInputNumber = GetSmallestPowerOf2ExcNumber(inputNumber);
            Console.WriteLine($"The smallest power of 2 exceeding {inputNumber} is {minPowerOf2ExcInputNumber}.");
            Console.ReadKey();
        }
    }
}
