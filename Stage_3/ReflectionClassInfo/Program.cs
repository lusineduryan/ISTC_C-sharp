using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using System.IO;

namespace ReflectionClassInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassInfo.AllCalls();
            Console.ReadKey();
        }
    }
}
