using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31_sequence
{
    class Program
    {
        static void Sequence (int number)
        {
            int length = 1;
            int numberDub = number;
            while (numberDub!=1)
            {
                numberDub = numberDub % 2 == 0 ? numberDub / 2 : 3 * numberDub + 1;
                length++;
            }
            int[] array = new int[length];
            array[0] = number;
            for (int i = 1; i < length && array[i-1] != 1; i++)
            {
                if (array[i - 1] % 2 == 0)
                {
                    array[i] = array[i - 1] / 2;
                }
                else
                {
                    array[i] = 3 * array[i - 1] + 1;
                }
                Console.Write(array[i] + ",");
            }
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Sequence(inputNumber);
            Console.ReadKey();
        }
    }
}
