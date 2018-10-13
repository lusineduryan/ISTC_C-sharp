using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3_typeAllDigitsNotExceedingn
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = Convert.ToByte(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        
    }
}
