using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues.Brackets
{
    public static class Solution
    {
        public static int solution(string S)
        {
            // write your code in C# with .NET 2.0
            if (S.Length > 200000) throw new ArgumentOutOfRangeException();
            if (String.IsNullOrEmpty(S)) return 1;
            var stack = new Stack<char>(S.Length);
            foreach (var value in S)
            {
                switch (value)
                {
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(value);
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                            return 0;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return 0;
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return 0;
                        break;
                    default:
                        return 0;
                }
            }

            if (stack.Count != 0)
                return 0;

            return 1;
        }
    }
}
