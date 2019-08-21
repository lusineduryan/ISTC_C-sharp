using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.All)]
    public class ExceptionHandlingAttribute : Attribute
    {
        public int Division(int arg1, int arg2)
        {
            try 
	        {	        
		        return arg1 / arg2;
	        }
	        catch (DivideByZeroException e)
	        {
                Console.WriteLine("Cannot divide by zero or non-numeric!");
                return 0;
	        }
        }

        public int Conversion(string arg)
        {
            try
            {
                return Convert.ToInt32(arg);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Cannot convert to integer!");
                return 0;
            }
        }

        public int GetArrayMember(int[] arg1, int arg2)
        {
            try
            {
                return arg1[arg2];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Your index is exceeding your array size");
                return 0;
            }
        }


    }
}
