using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = number.SumOfDigits();
            Console.WriteLine(sum);
            string str = Console.ReadLine();
            int count = str.NumberOfAs();
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
