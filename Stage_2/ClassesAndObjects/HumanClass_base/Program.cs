using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanClass_base
{
    class Human
    {
        private string name;
        private string surname;
        private int age;
        private double weight;
        private string sex;

        public Human(string name, string surname, int age, double weight, string sex)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.weight = weight;
            this.sex = sex;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetWeight(double weight)
        {
            this.weight = weight;
        }
        public void SetSex(string sex)
        {
            this.sex = sex;
        }

        public void GetName()
        {
            Console.WriteLine(name);
        }
        public void GetSurname()
        {
            Console.WriteLine(surname);
        }
        public void GetAge()
        {
            Console.WriteLine(age);
        }
        public void GetWeight()
        {
            Console.WriteLine(weight);
        }
        public void GetSex()
        {
            Console.WriteLine(sex);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Human newHuman = new Human(Convert.ToString(Console.ReadKey()), Convert.ToString(Console.ReadKey()), Convert.ToInt32(Console.ReadKey()), Convert.ToDouble(Console.ReadKey()), Convert.ToString(Console.ReadKey()));
            newHuman.GetName();
            newHuman.SetName("Cris");
            newHuman.GetAge();
            newHuman.SetAge(33);
        }
    }
}