using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5_sumOfEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 2;
            while (i < n)
            {
                sum += i;
                i += 2;
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
