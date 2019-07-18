using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    class Program
    {
        static bool IsValid(char[] chars)
        {
            Stack<char> S = new Stack<char>();
            foreach (char c in chars)
            {
                if (c == '{') S.Push('}');
                else if (c == '(') S.Push(')');
                else if (c == '[') S.Push(']');
                else if (c == '<') S.Push('>');
                else
                {
                    if (S.Count == 0 || c != S.Peek()) return false;
                    S.Pop();
                }
            }
            return S.Count == 0 ? true : false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid(Console.ReadLine().ToCharArray()));
            Console.ReadKey();
        }
    }
}
