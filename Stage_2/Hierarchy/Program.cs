using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peter");
            Rabbit Peter = new Rabbit("Peter", 2, "white");
            Peter.GetMeal();
            Peter.Say();
            Peter.IsEating();

            Console.WriteLine("Simba");
            Lion Simba = new Lion("Simba", 5, 5.6);
            Simba.GetMeal();
            Simba.Say();
            Simba.IsEating();

            Console.WriteLine("Ed");
            Hyena Ed = new Hyena("Ed", 3, 99.9);
            Ed.GetMeal();
            Ed.Say();
            Ed.IsEating();

            Console.WriteLine("Lilit");
            Man Lilit = new Man("Lilit", 36, false);
            Lilit.GetMeal();
            Lilit.Say();
            Lilit.IsEating();
            Lilit.ReallyHasConscious();

            Console.WriteLine("Pet");
            Animal Pet = Peter as Animal;
            Pet.Say();
            Pet.IsEating();

            Console.WriteLine("Eddy");
            Animal Eddy = Ed as Animal;
            Console.WriteLine(Ed.courage);
            Eddy.Say();
            Eddy.IsEating();

            Console.ReadKey();
        }
    }
}