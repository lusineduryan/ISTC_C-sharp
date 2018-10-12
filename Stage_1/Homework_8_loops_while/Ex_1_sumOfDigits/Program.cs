using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_sumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int sumOfDigits = 0;
            int i = 0;
            while ((int) (inputNum / Math.Pow(10, i)) != 0)
            {
                sumOfDigits += (int) (inputNum / Math.Pow(10,i) % 10);
                i++;
            }
            Console.WriteLine(sumOfDigits);
            Console.ReadKey();
        }
    }
}
