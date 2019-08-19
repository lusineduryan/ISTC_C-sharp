using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;


namespace ConfigTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = ConfigurationSettings.AppSettings["name"];
            string myAge = ConfigurationSettings.AppSettings.Get("age");
            var all = ConfigurationSettings.AppSettings;
            foreach (var item in all.AllKeys)
            {
                Console.WriteLine($"Key: {item}, Value: {all.Get(item)} \n");
            }

            Console.WriteLine(myName);
            Console.WriteLine(myAge);
            Console.ReadKey();
        }
    }
}
