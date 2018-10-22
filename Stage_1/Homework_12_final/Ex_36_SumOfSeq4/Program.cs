using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_36_SumOfSeq4
{
    class Program
    {
        static double SumOfSeq(double number, int value)
        {
            double sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += Math.Pow(-1,i+1) * Math.Pow(value, i) * (1.0 / i);
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
