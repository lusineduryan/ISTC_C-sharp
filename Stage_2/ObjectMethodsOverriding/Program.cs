using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethodsOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangular rect1 = new Rectangular(4, 6.5);
            Rectangular rect2 = new Rectangular(4, 6);
            Rectangular rect3 = new Rectangular(3, 8);

            Console.WriteLine(rect2.Equals(rect3));
            Console.WriteLine(rect1.ToString());
            Console.WriteLine(rect1.GetHashCode());

            Console.ReadKey();
        }
    }
}
