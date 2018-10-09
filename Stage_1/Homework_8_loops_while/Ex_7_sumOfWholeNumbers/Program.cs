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
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = A;
            while (i <= B)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();


        }
    }
}
