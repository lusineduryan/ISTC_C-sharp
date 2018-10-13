using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_21_allDivisors
{
    class Program
    {
        /// <summary>
        /// prints all thr divisors for a given number
        /// </summary>
        /// <param name="number"></param>
        static void GetAllDivisors(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            GetAllDivisors(inputNumber);
            Console.ReadKey();

        }
    }
}
