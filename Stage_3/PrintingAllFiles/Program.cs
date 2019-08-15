using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintingAllFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] drives = Directory.GetLogicalDrives();

             foreach (string drive in drives)
             {
                 Console.WriteLine(drive);
             }

             string generalDrive = Console.ReadLine().ToUpper() + ":\\";

             if (drives.Contains(generalDrive))
             {
                 AllDirectories.PrintDirectories(generalDrive);
             }
             else
             {
                 Console.WriteLine("Please enter a valid directory name!");
             }
             Console.ReadKey(); */

            string[] allDirectories = Directory.GetDirectories(@"C:\Users");
            foreach (string directory in allDirectories)
            {
                Console.WriteLine(directory);
                AllFilesInDirectory.PrintAllFilesInDirectory(directory);
            }
            Console.ReadKey();
        }
    }
}
