using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            double weight;
            int year;
            bool sex;
           
            Console.Write("Please enter your first name - ");
            name = Console.ReadLine();
            Console.Write("Please enter your last name - ");
            surname = Console.ReadLine();
            Console.Write("Please enter your weight - ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your birth year - ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your sex (true if female, false if male) - ");
            sex = Convert.ToBoolean(Console.ReadLine());

            int age = 2018 - year;
            string category;
            if (weight <= 99.9)
            {
                category = "thin";
            }
            else
            {
                category = "fat";
            }

            string _sex;
            if (sex = true)
            {
                _sex = "woman";
            }
            else
            {
                _sex = "man";
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Dear {0} {1} you are {2} year old {3} {4}", name, surname, age, category, _sex);

            Console.ReadKey();
        }
    }
}
