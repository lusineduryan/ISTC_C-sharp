using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Animal
    {
        protected string name;
        private int age;
        protected string meal;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    public class Herbivore : Animal
    {
        public void IsEating()
        {
            Console.WriteLine("I eat only plants!");
        }
        public Herbivore(string name, int age) : base(name, age)
        {
            meal = "plants";
        }
    }
    public class Carnivore : Animal
    {
        public void IsEating()
        {
           Console.WriteLine("I eat only meat!");
        }
        public Carnivore(string name, int age) : base(name, age)
        {
            meal = "meat";
        }
    }
    public class Omnivore : Animal
    {
        public void IsEating()
        {
            Console.WriteLine("I eat both plants and meat!");
        }
        public Omnivore(string name, int age) : base(name, age)
        {
            meal = "plants & meat";
        }
    }
    public class Rabbit : Herbivore
    {
        private string furColor;
        public void Say()
        {
            Console.WriteLine("I run very fast!");
        }
        public Rabbit(string name, int age, string furColor) : base(name, age)
        {
            this.furColor = furColor;
        }
        public string GetMeal()
        {
            return meal;
        }
    }
    public class Lion : Carnivore
    {
        private double roarAmplitude;
        public void Say()
        {
            Console.WriteLine("I am the king of all animals!");
        }
        public Lion(string name, int age, double roarAmplitude) : base(name, age)
        {
            this.roarAmplitude = roarAmplitude;
        }
        public string GetMeal()
        {
            return meal;
        }
    }
    public class Hyena : Carnivore
    {
        private double laughAmplitude;
        public void Say()
        {
            Console.WriteLine("I am very dangerous!");
        }
        public Hyena(string name, int age, double laughAmplitude) : base(name, age)
        {
            this.laughAmplitude = laughAmplitude;
        }
        public string GetMeal()
        {
            return meal;
        }
    }
    public class Man : Omnivore
    {
        private bool hasConscious = true;
        public void Say()
        {
            Console.WriteLine("I am homo spaiens!");
        }
        public Man(string name, int age, bool hasConscious) : base(name, age)
        {
            this.hasConscious = hasConscious;
        }
        public string GetMeal()
        {
            return meal;
        }
        public bool ReallyHasConscious()
        {
            return hasConscious;
        }
    }
}
