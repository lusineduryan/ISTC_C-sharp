using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_16_sumOfDigits
{
    class Program
    {
        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int SumOfDigits(int number)
        {
            int sumOfDigits = 0;
            for (int i = 0; (int) (number / Math.Pow(10,i)) != 0; i++)
            {
                sumOfDigits += (int) (number / Math.Pow(10, i) % 10);
            }
            return sumOfDigits;
        }
        /// <summary>
        /// Count
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int CountOfDigits(int number)
        {
            int countOfDigits = 0;
            for (int i = 0; (int) (number / Math.Pow(10, i)) != 0; i++)
            {
                countOfDigits++;
            }
            return countOfDigits;
        }
        /// <summary>
        /// Product
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int ProductOfDigits(int number)
        {
            int productOfDigits = 1;
            for (int i = 0; (int) (number / Math.Pow(10, i)) != 0; i++)
            {
                productOfDigits *= (int)(number / Math.Pow(10, i) % 10);
            }
            return productOfDigits;
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int sum = SumOfDigits(inputNumber);
            int count = CountOfDigits(inputNumber);
            int product = ProductOfDigits(inputNumber);
            Console.WriteLine($"sum: {sum}\ncount: {count}\nproduct: {product}");
            Console.ReadKey();
        }
    }
}
