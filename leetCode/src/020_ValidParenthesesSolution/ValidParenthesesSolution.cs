using System.Collections.Generic;

namespace leetCode._020_ValidParenthesesSolution
{
    public class ValidParenthesesSolution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var parenthesesDict = new Dictionary<char, char>
            {
                {')', '('}, 
                {']', '['}, 
                {'}', '{'}
            };

            foreach (var c in s)
            {
                if (parenthesesDict.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if(stack.Count != 0 && stack.Pop() == parenthesesDict[c]) continue;
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}