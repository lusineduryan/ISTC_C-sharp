using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\\Windows");
            Console.WriteLine($"Full Name of the directory is : {dirinfo.FullName}");
            Console.WriteLine($"The directory was last accesses on: { dirinfo.LastAccessTime}");
            Console.ReadKey();
            System.IO.File.AppendAllLines(@"C:\Users\USER_2\source\Text.txt", Enumerable.Range(0, 100).Select(x => x.ToString()));
            System.IO.FileInfo[] filesInDir = dirinfo.GetFiles();
            foreach (System.IO.FileInfo file in filesInDir)
            
            {
                Console.WriteLine($"File Name {file.FullName} Size: {file.Length} bytes");
            }
            Console.Read();
        }
    }
}
