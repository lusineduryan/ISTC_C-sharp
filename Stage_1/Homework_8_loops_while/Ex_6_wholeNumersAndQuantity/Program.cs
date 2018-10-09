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
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i = A;
            while (i <= B)
            {
                count++;
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}
