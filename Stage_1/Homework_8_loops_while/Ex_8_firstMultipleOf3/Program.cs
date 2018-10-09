using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8_firstMultipleOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            int i = A;
            while (i <= B)
            {
                if (i % 3 == 0)
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
                i++;

            }
            Console.WriteLine(flag ? $"{i}" : $"no multiple of 3 found in the given sector");
            Console.ReadKey();

        }
    }
}
