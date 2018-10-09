using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4_1to9powerOfn
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 9)
            {
                Console.WriteLine(Math.Pow(n,i));
                i++;
            }
            Console.ReadKey();

        }
    }
}
