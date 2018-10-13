using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_15_findAll3DigitNumbersWithCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 999; i++)
            {
                if (i % 100 * 7 == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
