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
            Human newHuman = new Human("male");
            Human newHuman1 = new Human(80, "male");
            Human newHuman2 = new Human(33, 80, "male");
            Console.WriteLine(newHuman1.Age);
            Console.WriteLine(newHuman2.Weight);
            Console.ReadKey();
           
        }
    }
}
