using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
--  
    class Program
    {
        static void Main(string[] args)
        {

        }
-   }
    class Animal
    {
        public string Name { get; set; }
-       public Animal(string name)
        {
            Name = name;
        }
--  }
    class Herbivore : Animal
    {
        public string MealP { get; set; }
        public void EatsPlants()
        {
            Console.WriteLine("I eat only plants");
        }
        public Herbivore(string name, string meal) : base(name)
        {
            MealP = meal;
        }
    }
    class Carnivore : Animal
    {
        public string MealM { get; set; }
        public void Eatsmeat()
        {
            Console.WriteLine("I eat only meat");
        }
        public Carnivore(string name, string meal) : base(name)
        {
            MealM = meal;
        }
    }
    class Omnivore : Animal
    {
        public string MealA { get; set; }
        public void Eatsmeat()
        {
            Console.WriteLine("I eat both plants and meat");
        }
        public Omnivore(string name, string meal) : base(name)
        {
            MealA = meal;
        }
    }
    class Rabbit : Herbivore
    {
        public string FurColor { get; set; }
        public void Say()
        {
            Console.WriteLine("I run very fast!");
        }
        public Rabbit(string name, string meal, string fur) : base(name, meal)
        {
            FurColor = fur;
        }

    }
    class Lion : Carnivore
    {
        public double RoarAmplitude { get; set; }
        public void Say()
        {
            Console.WriteLine("I am the king of all animals");
        }
        public Lion(string name, string meal, double roar):base(name, meal)
        {
            RoarAmplitude = roar;
        }
-   }
    class Hyena : Carnivore
    {
        public double LaughAmplitude { get; set; }
        public void Say()
        {
            Console.WriteLine("I am very dangerous");
        }
        public Hyena(string name, string meal, double laugh) : base(name, meal)
        {
            LaughAmplitude = laugh;
        }
-   }
    class Man : Omnivore
    {
        public bool HasConscious { get; set; } = true;
        public void Say()
        {
            Console.WriteLine("I am homo spaiens");
-       }
        public Man(string name, string meal, bool conscious) :base(name, meal)
        {
            HasConscious = conscious;
-       }
-   }
-}