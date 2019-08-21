using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Usage);

            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            Usage.GetDivision(type, number1, number2);

            int[] numbers = new int[] {7, 5, 9};
            string index = Console.ReadLine();
            Usage.GetItem(type, numbers, index);
            Console.ReadKey();
        }
    }
}
