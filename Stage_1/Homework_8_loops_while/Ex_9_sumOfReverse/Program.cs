using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9_sumOfReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = Convert.ToUInt32(Console.ReadLine());
            double sum = 0;
            int i = 1;
            while (i <= N)
            {
                sum += 1 / (double) i;
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
