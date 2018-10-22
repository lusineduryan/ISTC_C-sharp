using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_34_SumOfSeq2
{
    class Program
    {
        static double ReverseFactorial(int number)
        {
            if (number == 1) return 1;
            return ReverseFactorial(number - 1) * (1.0 / number);
        }
        static double SumOfSeq(double number, int value)
        {
            double sum = 0;
            int sign = 1;
            for (int i = 1; i <= number; i+=2)
            {
                sum += sign  * (ReverseFactorial(i) * Math.Pow(value, i));
                sign *= -1;
            }
            Console.WriteLine(sum);
            return sum;
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int inputValue = Convert.ToInt32(Console.ReadLine());
            double sumOfSeq = SumOfSeq(inputNumber, inputValue);
            Console.ReadKey();
        }
    }
}
