using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7_sumOfWholeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 6;
            int B = 9;
            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
