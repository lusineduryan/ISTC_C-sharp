using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_MathOperations
{
    class Program
    {
        #region

        public static int Sum (int number1, int number2)
        {
            Console.WriteLine($"Sum is {number1 + number2}");
            return number1 + number2;
        }
        public static int Subtraction (int number1, int number2)
        {
            Console.WriteLine($"Subtraction is {number1 - number2}");
            return number1 - number2;
        }
        public static int Product (int number1, int number2)
        {
            Console.WriteLine($"Product is {number1*number2}");
            return number1 * number2;
        }
        public static int Division (int number1, int number2)
        {
            Console.WriteLine($"Division is {number1 / number2}");
            if (number2 != 0) return number1 / number2; else return 0;
        }
        
        #endregion

        static void Main(string[] args)
        {
            EventClass eventclass = new EventClass();
            eventclass.OperationsEvent += Sum;
            eventclass.OperationsEvent += Subtraction;
            eventclass.OperationsEvent += Product;
            eventclass.OperationsEvent += Division;

            eventclass.Invoker();
            Console.ReadKey();
        }
    }
}
