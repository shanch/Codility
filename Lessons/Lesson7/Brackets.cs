using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson7
{
    class Brackets
    {
        public int Solution(string S)
        {
            Stack<char> stk = new Stack<char>();

            foreach(char c in S)
            {
                if(c=='(' || c=='[' || c=='{')
                {
                    stk.Push(c);

                    continue;
                }

                if (stk.Count == 0) return 0;

                char lastC = stk.Pop();

                if(c == ')' && lastC == '(')
                {
                    continue;
                }
                if (c == ']' && lastC == '[')
                {
                    continue;
                }
                if (c == '}' && lastC == '{')
                {
                    continue;
                }
                return 0;
            }

            if (stk.Count == 0) return 1;

            return 0;
        }
    }
}
