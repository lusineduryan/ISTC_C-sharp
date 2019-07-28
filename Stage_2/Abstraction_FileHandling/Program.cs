using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_FileHandling
{
    class Program
    {
        public static void FileType(AbstractHandler file)
        {
            if (file != null) file.Type();
            else throw new NullReferenceException();
        }

        static void Main(string[] args)
        {
            DOCHandler DOC = new DOCHandler();
            XMLHandler XML = new XMLHandler();
            TXTHandler TXT = new TXTHandler();

            AbstractHandler file = null;
            string fileFormat = Console.ReadLine();
            switch (fileFormat)
            {
                case "DOC": file = DOC; break;
                case "XML": file = XML; break;
                case "TXT": file = TXT; break;
                default: Console.WriteLine("Please enter a valid file format!"); break;
            }

            try
            {
                FileType(file);
                file.Save();
                file.Change();
                file.Open();
                file.Create();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Should've been DOC, XML or TXT!");
            }
            
            Console.ReadKey();
        }
    }
}
