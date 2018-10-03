using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_days_of_weeks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the corresponding number: ");
            byte inputNumber = Convert.ToByte(Console.ReadLine());
            string result = "";
            bool flag = true;

            switch(inputNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    result = "Monday";
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    result = "Tuesday";
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    result = "Wednesday";
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    result = "Thursday";
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    result = "Friday";
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    result = "Saturday";
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    result = "Sunday";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    flag = false;
                    break;
            }

           
            Console.WriteLine(flag?$"Corresponding day of week is {result}" : "Invalid number entered");

            Console.ReadKey();

        }
    }
}
