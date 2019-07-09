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
            Rabbit Peter = new Rabbit("Peter", 2, "white");
            Peter.GetMeal();
            Peter.Say();
            Peter.IsEating();

            Lion Simba = new Lion("Simba", 5, 5.6);
            Simba.GetMeal();
            Simba.Say();
            Simba.IsEating();

            Hyena Ed = new Hyena("Ed", 3, 99.9);
            Ed.GetMeal();
            Ed.Say();
            Ed.IsEating();

            Man Lilit = new Man("Lilit", 36, false);
            Lilit.GetMeal();
            Lilit.Say();
            Lilit.IsEating();
            Lilit.ReallyHasConscious();
        }
    }
}