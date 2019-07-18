using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    class Program
    {
        static bool IsValid(string input)
        {
            Stack<char> S = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{') S.Push('}');
                else if (input[i] == '(') S.Push(')');
                else if (input[i] == '[') S.Push(']');
                else if (input[i] == '<') S.Push('>');
                else
                {
                    if (S.Count == 0
                        && (input[i] == ')' || input[i] == '}' || input[i] == ']' || input[i] == '>'))
                        return false;
                    else if (S.Count == 0
                        && (input[i] != ')' || input[i] != '}' || input[i] != ']' || input[i] != '>'))
                        continue;
                    else if (input[i] == S.Peek()) S.Pop();
                    else if (input[i] != S.Peek() 
                        && (input[i] == ')' || input[i] == '}' || input[i] == ']' || input[i] == '>'))
                        return false;
                }
            }

            return S.Count == 0 ? true : false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsValid(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
