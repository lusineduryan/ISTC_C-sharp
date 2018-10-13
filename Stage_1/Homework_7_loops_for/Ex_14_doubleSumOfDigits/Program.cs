using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_14_twiceSumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; (int)(n / Math.Pow(10, i)) != 0; i++)
            {
                sum += (int)(n / Math.Pow(10, i) % 10);
            }
            Console.WriteLine(n == 2 * sum ?"yes" : "no");
            Console.ReadKey();
        }
    }
}
