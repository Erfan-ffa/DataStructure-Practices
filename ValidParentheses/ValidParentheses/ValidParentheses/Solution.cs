using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {

            Stack<char> characters = new Stack<char>();

            if (s.Length % 2 != 0)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {

                var c = s[i];
                if (s[i] != ']' && s[i] != ')' && s[i] != '}')
                {
                    characters.Push(s[i]);
                }
                else if (characters.Count != 0)
                {
                    var peek = characters.Peek();
                    if (s[i] == ')' && peek == '(')
                    {
                        characters.Pop();
                    }
                    else if (s[i] == ']' && peek == '[')
                    {
                        characters.Pop();
                    }
                    else if (s[i] == '}' && peek == '{')
                    {
                        characters.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (s[i] == ']' || s[i] == ')' || s[i] == '}')
                {
                    return false;
                }
            }

            if (characters.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
