using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6_wholeNumersAndQuantity
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 11;
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                count++;
                Console.WriteLine(i);
            }
            Console.WriteLine($"\n{count}");
            Console.ReadKey();
        }
    }
}
