using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_19_productOfEvenDigitsSubceeding7
{
    class Program
    {
        static int productOfEvenNumbersSub7(int number)
        {
            int product = 1;
            for (int i = 0; (int)(number / Math.Pow(10, i)) != 0; i++)
            {
                int digit = (int)(number / Math.Pow(10, i) % 10);
                if (digit % 2 == 0 && digit < 7)
                {
                    product *= digit;
                }
            }
            return product;
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int productOfEvenDigitsSub7 = productOfEvenNumbersSub7(inputNumber);
            Console.WriteLine($"The product of even digits subceeding 7 is {productOfEvenDigitsSub7}.");
            Console.ReadKey();
        }
    }
}
