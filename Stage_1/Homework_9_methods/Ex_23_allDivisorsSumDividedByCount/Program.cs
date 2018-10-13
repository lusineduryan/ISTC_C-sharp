using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_23_allDivisorsSumDividedByCount
{
    class Program
    {
        /// <summary>
        /// calculates the ratio of sum of all divisors and the quantity of all divisors for a given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static double GetAllDivisorsSumDividedByCount(int number)
        {
            int sum = 0;
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    count++;
                }
            }
            return (double)sum / count;
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            double divisionResult = GetAllDivisorsSumDividedByCount(inputNumber);
            Console.WriteLine($"Sum of all divisors divided by count of all divisors is {divisionResult}.");
            Console.ReadKey();
        }
    }
}
