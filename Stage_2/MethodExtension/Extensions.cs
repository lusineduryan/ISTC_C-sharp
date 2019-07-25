using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtension
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
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
