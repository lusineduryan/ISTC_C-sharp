using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3_typeAllDigitsNotExceedingn
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i < n)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
