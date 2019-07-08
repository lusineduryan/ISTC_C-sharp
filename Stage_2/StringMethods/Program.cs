using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Lusine,16";
            object clone = str.Clone();
            Console.WriteLine(clone);
            Console.WriteLine(str.CompareTo("Lusine16"));
            Console.WriteLine(str.Contains("L"));
            Console.WriteLine(str.EndsWith("6"));
            Console.WriteLine("**************");
            Console.WriteLine(str.Equals("Lusine61"));
            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str.GetType());
            Console.WriteLine(str.GetTypeCode());
            Console.WriteLine(str.IndexOf("u"));
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Insert(3, "t"));
            Console.WriteLine(str.IsNormalized());
            Console.WriteLine(str.LastIndexOf("l"));
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Remove(3,2));
            Console.WriteLine(str.Replace("u", "y"));
            string[] separatedString = str.Split(',');
            foreach (string i in separatedString) Console.WriteLine(i);
            Console.WriteLine(str.StartsWith("L"));
            Console.WriteLine(str.Substring(3,5));
            Console.WriteLine(str.ToCharArray());
            Console.WriteLine(str.Trim());
            
            
        
            Console.ReadKey();

        }
    }
}
