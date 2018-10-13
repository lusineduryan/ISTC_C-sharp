using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_24_powerOf3
{
    class Program
    {
        /// <summary>
        /// identifies if a given number is a power of 3 or not
        /// </summary>
        /// <param name="number"></param>
        static void IfPowerOf3(int number)
        {
            int powerOf3 = 0;
            for (int i = 0; Math.Pow(3,i) <= number; i++)
            {
                powerOf3 = i;
            }
            if (Math.Pow(3, powerOf3) == number)
            {
                Console.WriteLine("power of 3");
            }
            else
            {
                Console.WriteLine("not a power of 3");
            }

        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            IfPowerOf3(inputNumber);
            Console.ReadKey();
        }
    }
}
