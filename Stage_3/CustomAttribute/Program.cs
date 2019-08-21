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
            //Usage.GetConversion(type);
            Console.ReadKey();
        }
    }
}
