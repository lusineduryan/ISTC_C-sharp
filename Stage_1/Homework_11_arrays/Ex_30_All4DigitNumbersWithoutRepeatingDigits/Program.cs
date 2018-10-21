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
                for (int j = 0; j < 4; j++)
                {
                    if (flag == false)
	                {
                        break;
	                }
                    Digits[j] = (int)(i / Math.Pow(10, j) % 10);
                    sum += Digits[j];
                    for (int k = j + 1; k < 4; k++)
			        {
                        Digits[k] = (int)(i / Math.Pow(10, k) % 10);
                        if (Digits[j] == Digits[k])
	                    {
                            flag = false;
                            break;
	                    }
                        else
	                    {
                            flag = true;
	                    }
			        }
                }
                if (flag == true && sum == i / 100 - i % 100)
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
