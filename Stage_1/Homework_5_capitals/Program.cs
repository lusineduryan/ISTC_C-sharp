using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_capitals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the letter:");
            char letter = Convert.ToChar(Console.ReadLine());


            Console.WriteLine(char.ToUpper(letter));
            Console.ReadKey();
        }
    }
}