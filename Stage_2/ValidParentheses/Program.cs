using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    class Program
    {
        static bool matchBrackets(char[] chars)
        {
            Stack<int> S = new Stack<int>();
            foreach (char c in chars)
            {
                if (c == '{') S.Push('}');
                else if (c == '(') S.Push(')');
                else if (c == '[') S.Push(']');
                else
                {
                    if (S.Count == 0 || c != (char)S.Peek())
                        return false;
                    S.Pop();
                }
            }
            return S.Count == 0 ? true : false;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
