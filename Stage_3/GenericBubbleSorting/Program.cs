using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBubbleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5,3,1,4,2 };
            Sorting<int>.BubbleSort(ref numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
