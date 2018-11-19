using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    class CatClass : Interface1, Interface2
    {
        void Interface1.Move()
        {
            Console.WriteLine("Paw");
        }
        void Interface1.Voice()
        {
            Console.WriteLine("Meow");
        }
        void Interface2.Breathe()
        {
            Console.WriteLine("Lung");
        }
    }
}
