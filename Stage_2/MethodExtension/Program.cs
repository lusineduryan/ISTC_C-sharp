using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Extension01
{
    public static class Extensions
    {
        public static int SumOfDigits(this int i)
        {
            int sum = 0;
            while (i != 0)
            {
                sum += i % 10;
                i /= 10;
            }
            return sum;
        }

        public static int NumberOfAs(this string str)
        {
            int count = 0;
            char[] str1 = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (str1[i] == 'a')
                {
                    count++;
                }
            }
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = 234;
            int sum = number.SumOfDigits();
            Console.WriteLine(sum);
            string str = "apple";
            int count = str.NumberOfAs();
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
