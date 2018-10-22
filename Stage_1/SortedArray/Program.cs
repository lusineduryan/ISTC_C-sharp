using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateRandomIntArray(10, 0, 100);

            Console.WriteLine("Original array");
            PrintArray(array);

            int[] sorted = SortArray(array, false);

            Console.WriteLine("Sorted array");
            PrintArray(sorted);

            Console.ReadKey();
        }
        static void Swap(int[] array, int index1, int index2)
        {
            if (index1 != index2)
            {
                int temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
            }
        }
        static int[] CreateRandomIntArray(int length, int rangeStart, int rangeEnd)
        {
            int[] array = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(rangeStart, rangeEnd);
            }
            return array;
        }
        static void PrintArray (int[] originalArray)
        {
            for (int i = 0; i < originalArray.Length; i++)
            {
                Console.WriteLine(originalArray[i]+",");
            }
        }
        public static int[] SortArray(int[] oiginalArray, bool isAscending)
        {
            int[] array = new int[oiginalArray.Length];
            for (int i = 0; i < oiginalArray.Length; i++)
            {
                array[i] = oiginalArray[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(array, j - 1, j);
                    }
                }
            }
            if (isAscending)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp = array[i];
                    array[i] = array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = temp;
                }
            }

            return array;
        }
    }
}
