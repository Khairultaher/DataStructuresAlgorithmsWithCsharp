using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class ValidParentheses
    {
        public static string s = "()[]{}";

        public static bool Check()
        {
            if (s == null)
                return true;

            Stack<char> temp = new Stack<char>();
            bool index = true;
            for (int i = 0; i < s.Length && index == true; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    temp.Push(s[i]);
                }                 
                else if (temp.Count != 0)
                {
                    switch (s[i])
                    {
                        case ')':
                            if (temp.Peek() == '(')
                                temp.Pop();
                            else index = false;
                            break;
                        case '}':
                            if (temp.Peek() == '{')
                                temp.Pop();
                            else index = false;
                            break;
                        case ']':
                            if (temp.Peek() == '[')
                                temp.Pop();
                            else index = false;
                            break;
                    }
                }
                else index = false;
            }
            return temp.Count == 0 ? index : false;
        }
    }
}
