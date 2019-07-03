using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    class Animal
    {
        public static string Type { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public float Weight { get; set; }

        static Animal()
        {
            Type = "Animal";
        }

        public Animal(int age)
        {
            Age = age;
        }

        public Animal(string color, int age): this(age)
        {
            Color = color;
        }

        public Animal(float weight, string color, int age): this(color, age)
        {
            Weight = weight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Animal.Type);
            Animal.Type = "animal";
            Console.WriteLine(Animal.Type);
            Animal Dog = new Animal(20.5f, "white", 3);
            Console.WriteLine(Dog.Age);
            Console.ReadKey();
        }
    }
}
