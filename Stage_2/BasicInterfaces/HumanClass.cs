using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    class HumanClass : Interface1, Interface2, Interface3
    {
        void Interface1.Move()
        {
            Console.WriteLine("Foot");
        }
        void Interface1.Voice()
        {
            Console.WriteLine("Speak");
        }
        void Interface2.Breathe()
        {
            Console.WriteLine("Lung");
        }
        void Interface3.Think()
        {
            Console.WriteLine("Idea");
        }

    }
}
