using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerForList
{
    class Listt
    {
        private int[] array = new int[5];
        public int this[int index]
        {
            get
            {
                try
                {
                    return array[index];
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("out of the pre-defined range");
                    return 0;
                }

            }

            set
            {
                if (index <= array.Length)
                {
                    array[index] = value;
                }
                else
                {
                    array = new int[index];
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var ListPrototype = new Listt();
            ListPrototype[3] = 7;
            try
            {
                Console.WriteLine(ListPrototype[Convert.ToInt32(Console.ReadLine())]);
            }
            catch (FormatException e)
            {
                throw;
            }
           
            Console.ReadKey();
        }
    }
}
