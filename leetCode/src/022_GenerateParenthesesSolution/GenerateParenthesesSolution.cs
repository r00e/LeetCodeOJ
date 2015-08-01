using System.Collections.Generic;

namespace leetCode._022_GenerateParenthesesSolution
{
    public class GenerateParenthesesSolution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();

            if (n < 1) return result;
            
            Helper("", n, 0, 0, result);

            return result;
        }

        private static IList<string> Helper(string s, int n, int left, int right, IList<string> result)
        {
            if (left + right == 2*n)
            {
                result.Add(s);
            }
            if (left < n)
            {
                Helper(s + "(", n, left+1, right, result);
            }
            if (right < left)
            {
                Helper(s + ")",n,left, right+1, result);
            }

            return result;
        }
    }
}