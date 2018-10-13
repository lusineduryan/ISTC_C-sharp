using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_squareFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = Convert.ToUInt32(Console.ReadLine());
            int square = 0;
            for (int i = 1; i <= 2 * N - 1; i += 2)
            {
                square += i;
                Console.WriteLine(square);
            }
            Console.ReadKey();
        }
    }
}
