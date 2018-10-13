using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_22_sumOfAllDivisors
{
    class Program
    {
        /// <summary>
        /// calculates the sum of all the divisors for a given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int GetSumOfAllDivisors(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int sumOfAllDivisors = GetSumOfAllDivisors(inputNumber);
            Console.WriteLine($"The sum of all divisors is {sumOfAllDivisors}.");
            Console.ReadKey();
        }
    }
}
