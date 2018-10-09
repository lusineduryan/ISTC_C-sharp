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
            double sum = 0;
            int i = 1;
            while (i <= N)
            {
                sum +=  Math.Pow(-1, i-1) * (1 + 0.1 * i);
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
