using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanClass_adjusted
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Sex { get; set; }

        public Human(string name, string surname, int age, double weight, string sex) : this(surname, age, weight, sex)
        {
           this.Name = name;
        }
        public Human(string surname, int age, double weight, string sex) : this (age,weight,sex)
        {
            this.Surname = surname;
        }
        public Human(int age, double weight, string sex) : this(weight,sex)
        {
            this.Age = age;
        }
        public Human(double weight, string sex) : this(sex)
        {
            this.Weight = weight;
        }
        public Human(string sex)
        {
            this.Sex = sex;
        }
        public Human()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human newHuman = null;
            try
            {
                newHuman = new Human(Convert.ToString(Console.ReadKey()));
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Human newHuman1 = null;
            try
            {
                newHuman1 = new Human(Convert.ToInt32(Console.ReadKey()), Convert.ToString(Console.ReadKey()));
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Human newHuman2 = null;
            try
            {
                newHuman2 = new Human(Convert.ToInt32(Console.ReadKey()), Convert.ToDouble(Console.ReadKey()), Convert.ToString(Console.ReadKey()));
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(newHuman1.Age);
            Console.WriteLine(newHuman2.Weight);
            Console.ReadKey();
           
        }
    }
}
