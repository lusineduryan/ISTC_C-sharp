using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    class FishClass : Interface2
    {
        void Interface2.Breathe()
        {
            Console.WriteLine("Grills");
        }
    }

}
