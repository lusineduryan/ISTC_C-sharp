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
        private string meal;
        public Animal(string name, int age, string meal)
        {
            this.name = name;
            this.age = age;
            this.meal = meal;
        }
    }
    public class Herbivore : Animal
    {
        public void IsEating()
        {
            Console.WriteLine("I eat only plants");
        }
        public Herbivore(string name, int age, string meal) : base(name, age, "plants")
        {
        }
    }
    public class Carnivore : Animal
    {
        public void IsEating()
        {
            Console.WriteLine("I eat only meat");
        }
        public Carnivore(string name, int age, string meal) : base(name, age, "meat")
        {
        }
    }
    public class Omnivore : Animal
    {
        public void IsEating()
        {
            Console.WriteLine("I eat both plants and meat");
        }
        public Omnivore(string name, int age, string meal) : base(name, age, "plants & meat")
        {
        }
    }
    public class Rabbit : Herbivore
    {
        private string furColor;
        public void Say()
        {
            Console.WriteLine("I run very fast!");
        }
        public Rabbit(string name, int age, string meal, string furColor) : base(name, age, meal)
        {
            this.furColor = furColor;
        }
    }
    public class Lion : Carnivore
    {
        private double roarAmplitude;
        public void Say()
        {
            Console.WriteLine("I am the king of all animals!");
        }
        public Lion(string name, int age, string meal, double roarAmplitude) : base(name, age, meal)
        {
            this.roarAmplitude = roarAmplitude;
        }
    }
    public class Hyena : Carnivore
    {
        private double laughAmplitude;
        public void Say()
        {
            Console.WriteLine("I am very dangerous!");
        }
        public Hyena(string name, int age, string meal, double laughAmplitude) : base(name, age, meal)
        {
            this.laughAmplitude = laughAmplitude;
        }
    }
    public class Man : Omnivore
    {
        private bool hasConscious = true;
        public void Say()
        {
            Console.WriteLine("I am homo spaiens!");
        }
        public Man(string name, int age, string meal, bool hasConscious) : base(name, age, meal)
        {
            this.hasConscious = hasConscious;
        }
    }
}
