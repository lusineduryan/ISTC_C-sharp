using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    class RobotClass : Interface1, Interface3
    {
        void Interface1.Move()
        {
            Console.WriteLine("Mechanical feet");
        }
        void Interface1.Voice()
        {
            Console.WriteLine("Mechanical voice");
        }
        void Interface3.Think()
        {
            Console.WriteLine("Artificial Intelligence");
        }
    }
}
