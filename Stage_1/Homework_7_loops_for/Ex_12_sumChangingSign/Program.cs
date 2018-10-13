using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_sumChangingSign
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = Convert.ToUInt32(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1, j = 2; i <= N; i+=2, j+=2)
            {
                sum += (1 + (decimal) i / 10) - (j <= N?(1 + (decimal) j / 10):0);
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
