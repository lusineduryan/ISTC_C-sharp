using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace GithubAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProcessTest.CSharpReposCount(out List<string> groups));
            Console.WriteLine(ProcessTest.NewReposCount());
            var set = ProcessTest.MostStarredProfiles();
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
