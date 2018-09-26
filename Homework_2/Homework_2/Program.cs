using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x_byte = 5;
            byte y_byte = 7;

            Console.WriteLine("-----Arithmetic operations with byte type-----");
            Console.WriteLine(x_byte + y_byte);
            Console.WriteLine(x_byte - y_byte);
            Console.WriteLine(x_byte * y_byte);
            if(y_byte == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine(x_byte / y_byte);
            }

            sbyte x_sbyte = -5;
            sbyte y_sbyte = 7;

            Console.WriteLine("-----Arithmetic operations with sbyte type-----");
            Console.WriteLine(x_sbyte + y_sbyte);
            Console.WriteLine(x_sbyte - y_sbyte);
            Console.WriteLine(x_sbyte * y_sbyte);
            if (y_sbyte == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine(x_sbyte / y_sbyte);
            }

            short x_short = 10;
            short y_short = 8;

            Console.WriteLine("-----Arithmetic operations with short type-----");
            Console.WriteLine(x_short + y_short);
            Console.WriteLine(x_short - y_short);
            Console.WriteLine(x_short * y_short);
            if (y_short == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine(x_short / y_short);
            }

            int x_int = 20;
            int y_int = 80;

            Console.WriteLine("-----Arithmetic operations with int type-----");
            Console.WriteLine(x_int + y_int);
            Console.WriteLine(x_int - y_int);
            Console.WriteLine(x_int * y_int);
            if (y_int == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine(x_int / y_int);
            }


            long x_long = 200;
            long y_long = 800;

            Console.WriteLine("-----Arithmetic operations with long type-----");
            Console.WriteLine(x_long + y_long);
            Console.WriteLine(x_long - y_long);
            Console.WriteLine(x_long * y_long);
            if (y_int == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine(x_long / y_long);
            }

            float x_float = 2.2f;
            float y_float = 8.8f;

            Console.WriteLine("-----Arithmetic operations with float type-----");
            Console.WriteLine(x_float + y_float);
            Console.WriteLine(x_float - y_float);
            Console.WriteLine(x_float * y_float);
            if (y_float == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine(x_float / y_float);
            }


            double x_double = 2.256;
            double y_double = 8.843;

            Console.WriteLine("-----Arithmetic operations with double type-----");
            Console.WriteLine(x_double + y_double);
            Console.WriteLine(x_double - y_double);
            Console.WriteLine(x_double * y_double);
            if (y_double == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine(x_double / y_double);
            }

            decimal x_decimal = 2.25675m;
            decimal y_decimal = 8.84356m;

            Console.WriteLine("-----Arithmetic operations with decimal type-----");
            Console.WriteLine(x_decimal + y_decimal);
            Console.WriteLine(x_decimal - y_decimal);
            Console.WriteLine(x_decimal * y_decimal);
            if (y_decimal == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine(x_decimal / y_decimal);
            }

            Console.ReadKey();
        }
    }
}
