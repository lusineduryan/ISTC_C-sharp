using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintingAllFiles
{
    public class AllFilesInDirectory
    {
        public static void PrintAllFilesInDirectory(string directoryName)
        {
            string[] files = Directory.GetFiles(directoryName);
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
    }
}
