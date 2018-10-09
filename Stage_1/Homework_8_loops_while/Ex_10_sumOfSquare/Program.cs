using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_sumOfSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = Convert.ToUInt32(Console.ReadLine());
            double sum = 0;
            int i = 0;
            while (i <= N)
            {
                sum += Math.Pow((N + i), 2);
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}
