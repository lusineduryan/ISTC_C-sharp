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
    public static class ClassInfo
    {
        public static void GetAllClasses(Assembly assembly)
        {
            foreach (Type member in assembly.GetTypes())
            {
                Console.WriteLine(member.FullName);
            }
        }

        public static void GetAllFieldsInfo(Type type)
        {
            FieldInfo[] fieldsInfo = type.GetFields();
            foreach (FieldInfo field in fieldsInfo)
            {
                Console.WriteLine(field.Name);
            }
        }

        public static void GetAllProperties(Type type)
        {
            PropertyInfo[] propertiesInfo = type.GetProperties();
            foreach (PropertyInfo property in propertiesInfo)
            {
                Console.WriteLine(property.Name);
            }
        }

        public static void GetAllMethods(Type type)
        {
            MethodInfo[] methodsInfo = type.GetMethods();
            foreach (MethodInfo method in methodsInfo)
            {
                Console.WriteLine(method.Name);
            }
        }

        public static void Invoker(Type type)
        {
            object instance = Instantiation(type);
            MethodInfo[] methodsInfo = type.GetMethods();
            methodsInfo[0].Invoke(instance, new object[] { });
            methodsInfo[1].Invoke(instance, new object[] { });
        }

        public static void GetAllConstructors(Type type)
        {
            ConstructorInfo[] constructorsInfo = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructorsInfo)
            {
                Console.WriteLine(constructor.Name);
            }
        }

        public static Type GetClassState(string name, Assembly assembly)
        {
            return assembly.GetType(name);
        }
        public static object Instantiation(Type classType)
        {
            return Activator.CreateInstance(classType);
        }

        public static void AllCalls()
        {
            string assemblyPath = ConfigurationManager.AppSettings["assemblyPath"];
            Assembly currentAssembly = Assembly.LoadFile(assemblyPath);
            GetAllClasses(currentAssembly);
            Type classType = ClassInfo.GetClassState("Hierarchy.Animal", currentAssembly);
            object classInstance = ClassInfo.Instantiation(classType);

            GetAllFieldsInfo(classType);
            GetAllProperties(classType);
            GetAllConstructors(classType);
            GetAllMethods(classType);
            Invoker(classType);
        }
    }
}
