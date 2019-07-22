using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_FileHandling
{
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXT edited.");
        }

        public override void Create()
        {
            Console.WriteLine("TXT created.");
        }

        public override void Open()
        {
            Console.WriteLine("TXT opened.");
        }

        public override void Save()
        {
            Console.WriteLine("TXT saved.");
        }

        public override void Type()
        {
            Console.WriteLine("This is TXT file!");
        }
    }
}
