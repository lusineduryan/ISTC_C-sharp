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
            for (int i = 1; i <= N; i++)
            {
                sum += 1 / (double) i; 
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
