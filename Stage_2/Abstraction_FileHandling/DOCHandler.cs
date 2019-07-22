using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_FileHandling
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOC edited.");
        }

        public override void Create()
        {
            Console.WriteLine("DOC created.");
        }

        public override void Open()
        {
            Console.WriteLine("DOC opened.");
        }

        public override void Save()
        {
            Console.WriteLine("DOC saved.");
        }

        public override void Type()
        {
            Console.WriteLine("This is DOC file!");
        }
    }
}
