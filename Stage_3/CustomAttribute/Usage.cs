using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    [ExceptionHandling]
    public static class Usage
    {
        public static void GetConversion(Type t)
        {
            ExceptionHandlingAttribute exceptionAttribute = (ExceptionHandlingAttribute) Attribute.GetCustomAttribute(t, typeof(ExceptionHandlingAttribute));
            string inputString = Console.ReadLine();
            if (exceptionAttribute == null)
            {
                Console.WriteLine("Attribute not found!");
            }
            else
            {
                Console.WriteLine(exceptionAttribute.Conversion(inputString));
            }
        }

        public static int GetDivision(Type t, string arg1, string arg2)
        {
            ExceptionHandlingAttribute exceptionAttribute = (ExceptionHandlingAttribute)Attribute.GetCustomAttribute(t, typeof(ExceptionHandlingAttribute));
            int param1 = exceptionAttribute.Conversion(arg1);
            int param2 = exceptionAttribute.Conversion(arg2);
            return exceptionAttribute.Division(param1, param2);
        }
    }
}
