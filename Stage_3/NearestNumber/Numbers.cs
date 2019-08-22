using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestNumber
{
    class Numbers
    {
        public static double FindNearestNumber(double[] numbers, double input)
        {
            if (input >= numbers[numbers.Length - 1])
            {
                return numbers[numbers.Length - 1];
            }
            double res = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                double prevDif = Math.Abs(input - numbers[i - 1]);
                if (Math.Abs(input - numbers[i]) > prevDif)
                {
                    res =  numbers[i - 1];
                    break;
                }
            }
            return res;
        }
    }
}
