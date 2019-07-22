using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_FileHandling
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XML edited.");
        }

        public override void Create()
        {
            Console.WriteLine("XML created.");
        }

        public override void Open()
        {
            Console.WriteLine("XML opened.");
        }

        public override void Save()
        {
            Console.WriteLine("XML saved.");
        }

        public override void Type()
        {
            Console.WriteLine("This is XML file!");
        }
    }
}
