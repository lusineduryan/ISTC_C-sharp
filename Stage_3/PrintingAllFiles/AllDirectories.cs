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
        public static void PrintFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            var paths = Directory.GetDirectories(path).Where(d => !d.EndsWith("Settings") && !d.EndsWith("Bin") &&
                                                                  !d.EndsWith("Cache") && !d.EndsWith("Information"));
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            foreach (string dir in paths)
            {
                Console.WriteLine("Directory:");
                Console.WriteLine(dir);
                Console.WriteLine("Files of the directory:");
                PrintFiles(dir);
            }
        }
    }
}
