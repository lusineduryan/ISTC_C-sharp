using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_product
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = Convert.ToUInt32(Console.ReadLine());
            double product = 1;
            int i = 1;
            while (i <= N)
            {
                product *= 1 + (double)i / 10;
                i++;
            }
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}
