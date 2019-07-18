using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the isBalanced function below.
    static bool isBalanced(string input)
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
                if (S.Count == 0) return false;
                else if (input[i] == '}' && S.Peek() == input[i]) S.Pop();
                else if (input[i] == ')' && S.Peek() == input[i]) S.Pop();
                else if (input[i] == ']' && S.Peek() == input[i]) S.Pop();
                else if (input[i] == '>' && S.Peek() == input[i]) S.Pop();
                else continue;
                //if (S.Count == 0 || c != S.Peek()) return false;
            }
        }
        return S.Count == 0 ? true : false;


    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            bool result = isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
