using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_sumOfDigits
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter the input number");
            
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            bool flag = true;
            if (inputNumber % 10000 ==0)
            {

                int firstAdd = inputNumber / 1000;
                int secondAdd = (inputNumber % 1000) / 100;
                int thirdAdd = ((inputNumber % 1000) % 100) / 10;
                int forthAdd = ((inputNumber % 1000) % 100) % 10;
                sum = firstAdd + secondAdd + thirdAdd + forthAdd;
            }
            else
            {
                flag = false;
            }
            

            Console.WriteLine(flag?$"Sum of digits is\n{sum}":"Please enter a number with 4 digits");
            Console.ReadKey();

        }
    }
}
