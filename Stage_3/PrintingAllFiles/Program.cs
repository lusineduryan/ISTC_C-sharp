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
        public static void PrintAllFiles (string directoryName)
        {
            string[] directories = Directory.GetDirectories(directoryName);
            string[] files = Directory.GetFiles(directoryName);

            try
            {
                foreach (string directory in directories)
                {
                    Console.WriteLine(directory);
                    PrintAllFiles(directory);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void Main(string[] args)
        {
            string[] drives = Directory.GetLogicalDrives();

            foreach (string drive in drives)
            {
                Console.WriteLine(drive);
            }

            string generalDrive = Console.ReadLine().ToUpper();
            generalDrive += ":\\";

            if (drives.Contains(generalDrive))
            {
                PrintAllFiles(generalDrive);
            }
            else
            {
                Console.WriteLine("Please enter a valid directory name!");
            }
            Console.ReadKey();

        }
    }
}
