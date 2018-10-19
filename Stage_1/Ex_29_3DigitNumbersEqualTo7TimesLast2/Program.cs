using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_29_3DigitNumbersEqualTo7TimesLast2
{
    class Program
    {
        static void NumbersWithACondition ()
        {
            for (int i = 100; i < 999; i++)
            {
                if (i % 100 * 7 == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            NumbersWithACondition();
            Console.ReadKey();
        }
    }
}
