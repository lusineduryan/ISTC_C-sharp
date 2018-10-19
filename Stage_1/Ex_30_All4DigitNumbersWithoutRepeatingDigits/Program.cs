using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30_All4DigitNumbersWithoutRepeatingDigits
{
    class Program
    {
        static void GetAll4DigitNumbersWithoutRepeatingDigits()
        {
            int[] Digits = new int[4];
            for (int i = 1000; i < 10000; i++)
            {
                int sum = 0;
                bool flag = true;
                for (int j = 0, k = 1; j < 4 && k < 5; j++, k++)
                {
                    Digits[j] = (int)(i / Math.Pow(10, j) % 10);
                    int k1 = (int)(i / Math.Pow(10, k) % 10);
                    sum += Digits[j];
                    if (Digits[j] != k1 && sum == i / 1000 - i % 10)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            GetAll4DigitNumbersWithoutRepeatingDigits();
            Console.ReadKey();
        }
    }
}
