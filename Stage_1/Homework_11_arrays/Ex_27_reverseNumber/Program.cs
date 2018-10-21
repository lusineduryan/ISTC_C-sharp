using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_27_reverseNumber
{
    class Program
    {
        static void ReverseNumber (int number)
        {
            string[] reverse = new string[2 * Convert.ToString(number).Length];
            for (int i = 0; i < Convert.ToString(number).Length; i++)
            {
                reverse[i] = $"{(int)(number / Math.Pow(10, i) % 10)}0";
                Console.Write(reverse[i]);
            }
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            ReverseNumber(inputNumber);
            Console.ReadKey();
        }
    }
}
