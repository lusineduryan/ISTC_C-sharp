using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinArmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string input = Console.ReadLine();
            Console.WriteLine(input.LatinToArm());
            Console.ReadKey();
        }
    }
}
