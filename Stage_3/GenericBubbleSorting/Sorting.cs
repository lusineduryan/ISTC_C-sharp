using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBubbleSorting
{
    public class Sorting<T> where T: struct
    {
        private static void Swap(ref T arg1, ref T arg2)
        {
            arg1 = (dynamic)arg1 + (dynamic)arg2;
            arg2 = (dynamic)arg1 - (dynamic)arg2;
            arg1 = (dynamic)arg1 - (dynamic)arg2;
        }

        public static void BubbleSort(ref T[] arg)
        {
            for (int i = 0; i < arg.Length - 1; i++)
            {
                for (int j = 0; j < arg.Length - 1; j++)
                {
                    if ((dynamic)arg[j] > (dynamic)arg[j + 1])
                    {
                        Swap(ref arg[j], ref arg[j + 1]);
                    }
                }
            }
        }
    }
}
