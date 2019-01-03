using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        public static bool IsCorrect(string inputString)
        {
            var brackets = new List<char>(); 
            foreach (char item in inputString)
            {
                switch (item)
                {
                    case '(':
                        brackets.Add('(');
                        break;
                    case '[':
                        brackets.Add('[');
                        break;
                    case '{':
                        brackets.Add('{');
                        break;
                    case '<':
                        brackets.Add('<');
                        break;
                    case ')':
                        if (brackets.Count != 0 && brackets[brackets.Count-1] == '(')
                        {
                            brackets.RemoveAt(brackets.Count-1);
                        }
                        else return false;
                        break;
                    case ']':
                        if (brackets.Count != 0 && brackets[brackets.Count - 1] == '[')
                        {
                            brackets.RemoveAt(brackets.Count - 1);
                        }
                        else return false;
                        break;
                    case '}':
                        if (brackets.Count != 0 && brackets[brackets.Count - 1] == '{')
                        {
                            brackets.RemoveAt(brackets.Count - 1);
                        }
                        else return false;
                        break;
                    case '>':
                        if (brackets.Count != 0 && brackets[brackets.Count - 1] == '<')
                        {
                            brackets.RemoveAt(brackets.Count - 1);
                        }
                        else return false;
                        break;
                    default:
                        break;
                }
            }
            return brackets.Count == 0;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool answer = IsCorrect(input);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
