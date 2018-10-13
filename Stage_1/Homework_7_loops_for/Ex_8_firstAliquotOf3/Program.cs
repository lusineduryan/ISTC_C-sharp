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
            int A = 10;
            int B = 20;
            bool flag = true;
            int firstMultipleOf3 = 0;
            for (int i = A; i <= B; i++)
            {
                firstMultipleOf3 = i;
                if (i % 3 ==0)
                {
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            Console.WriteLine(flag?$"{firstMultipleOf3}":$"no multiple of 3 found in the given sector");
            Console.ReadKey();
        }
    }
}
