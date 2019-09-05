using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBubbleSorting
{
    public struct Operators
    {
        public static Operators operator +(Operators arg1, Operators arg2)
        {
            try
            {
                return arg1 + arg2;
            }
            catch (Exception)
            {
                Console.WriteLine("Input type is not supported!");
                return new Operators();
            }
        }

        public static Operators operator -(Operators arg1, Operators arg2)
        {
            try
            {
                return arg1 - arg2;
            }
            catch (Exception)
            {
                Console.WriteLine("Input type is not supported!");
                return new Operators();
            }
        }

        public static bool operator <(Operators arg1, Operators arg2)
        {
            try
            {
                if (arg1 < arg2) return true;
                else return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Input type is not supported!");
                return false;
            }
        }

        public static bool operator >(Operators arg1, Operators arg2)
        {
            try
            {
                if (arg1 > arg2) return true;
                else return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Input type is not supported!");
                return false;
            }
        }
    }
}
