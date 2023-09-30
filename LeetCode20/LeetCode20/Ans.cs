using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode20
{
    public static class Ans
    {
        public static bool IsValid(string s)
        {
            
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                if(stack.Count > 0 &&(item == ')' && stack.Peek() == '('))
                {
                    stack.Pop();
                }
                else if(stack.Count > 0 && (item == ']' && stack.Peek() == '['))
                {
                    stack.Pop();
                }
                else if (stack.Count>0 && (item == '}' && stack.Peek() == '{'))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(item);
                }

            }

            return (stack.Count == 0);
        }
    }
}
