using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_ConverterToString
{
    class GenericConverter<T>
    {
        private T input;
        public GenericConverter (T input)
        {
            this.input = input;
        }

        public string Converter<T>(T input)
        {
            string res = "";
            try
            {
                res = input.ToString();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericConverter<double> input1 = new GenericConverter<double>(10.5);
            Console.WriteLine(input1.Converter(10.5));
            GenericConverter<int> input2 = new GenericConverter<int>(20);
            Console.WriteLine(input2.Converter(20));
            Console.ReadKey();
        }
    }
}
