using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
    class Program
    {
        static void DrawRhombus(int side)
        {
            for (int i = 1; i <= side; i++)
            {
                for (int j = i; j < side; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = side - 1; i >= 1; i--)
            {
                for (int j = i; j < side; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int side = Convert.ToInt32(Console.ReadLine());
            DrawRhombus(side);
            Console.ReadKey();
        }
    }
}
