using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanClass
{
    class Human
    {
        private string name;
        private string surname;
        private int age;
        private double weight;
        private string sex;

        public Human(string name1, string surname1, int age1, double weight1, string sex1)
        {
            name = name1;
            surname = surname1;
            age = age1;
            weight = weight1;
            sex = sex1;
-       }

        public void SetName(string name1)
        {
            name = name1;
        }
        public void SetSurname(string surname1)
        {
            surname = surname1;
        }
        public void SetAge(int age1)
        {
            age = age1;
        }
        public void SetWeight(double weight1)
        {
            weight = weight1;
        }
        public void SetSex(string sex1)
        {
            sex = sex1;
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
-
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human newHuman = new Human("Cristiano", "Ronaldo", 33, 80, "male");
            newHuman.GetName();
            newHuman.SetName("Cris");
            newHuman.GetName();
           
        }
    }
}
