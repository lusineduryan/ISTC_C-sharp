using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2_typeNumberNTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (count < N)
            {
                Console.WriteLine(K);
                count++;
            }
            Console.ReadKey();

        }
    }
}
