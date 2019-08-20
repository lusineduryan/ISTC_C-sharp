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
            string assemblyPath = ConfigurationManager.AppSettings["assemblyPath"];
            Assembly currentAssembly = Assembly.LoadFile(assemblyPath);
            ClassInfo.GetAllClasses(currentAssembly);
            Type classType = ClassInfo.GetClassState("Hierarchy.Animal", currentAssembly);
            object classInstance = ClassInfo.Instantiation(classType);

            ClassInfo.GetAllFieldsInfo(classType);
            ClassInfo.GetAllProperties(classType);
            ClassInfo.GetAllConstructors(classType);
            ClassInfo.GetAllMethods(classType);

            Console.ReadKey();
        }
    }
}
