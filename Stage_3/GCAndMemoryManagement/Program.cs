using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace GCAndMemoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            long memory = 0;
            using (TextFiles textFile = new TextFiles())
            {
                StreamWriter file = textFile.CreateTextFileW(ConfigurationManager.AppSettings["path"], "Lucy.txt", out memory);
                Console.Write("Please write a text in the file: ");
                string inputText = Console.ReadLine();
                textFile.WriteInTextFile(inputText, file, out memory);
                //file.Dispose();
            }
            using (TextFiles textFile = new TextFiles())
            {
                StreamReader file = textFile.CreateTextFileR(ConfigurationManager.AppSettings["path"] + "\\Lucy.txt", out memory);
                string text = textFile.ReadFromTextFile(file, out memory);
                Console.WriteLine($"The following text retrieved from the file: {text}");
                Console.WriteLine($"Modified text is: {textFile.NewText(text)}");
            }
            Console.ReadKey();
        }
    }
}
