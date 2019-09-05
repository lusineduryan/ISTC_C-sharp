using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBubbleSorting
{
    public class Sorting
    {
        public static Sorting operator +(arg1, arg2)
        {
            try
            {
                return arg1 + arg2;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void Swap<T>(ref T arg1, ref T arg2)
        {
            arg1 = arg1 + arg2;

        }
    }
}
