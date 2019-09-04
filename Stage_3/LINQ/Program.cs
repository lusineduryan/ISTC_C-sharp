using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anna", "Ani", "Lilit", "Gohar", "Artyom", "Arpi", "Levon" };
            var ANames = names.Where(s => s.StartsWith("A")).Select(s => s);
            foreach (var item in ANames)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            var LName = names.FirstOrDefault(s => s.StartsWith("L"));
            Console.WriteLine(LName);
            Console.ReadKey();
        }
    }
}
