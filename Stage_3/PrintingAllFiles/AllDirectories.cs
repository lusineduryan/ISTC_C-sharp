using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintingAllFiles
{
    public class AllDirectories
    {
        public static void PrintDirectories (string directoryName)
        {
            string[] directories = Directory.GetDirectories(directoryName);
            try
            {
                foreach (string directory in directories)
                {
                    Console.Write("Direcory: ");
                    Console.WriteLine(directory);
                    Console.WriteLine($"All files in directory {directory}: ");
                    AllFilesInDirectory.PrintAllFilesInDirectory(directory);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
