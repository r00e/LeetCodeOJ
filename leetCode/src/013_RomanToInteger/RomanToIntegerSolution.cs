using System.Collections.Generic;

namespace leetCode._013_RomanToInteger
{
    public class RomanToIntegerSolution
    {
        public int RomanToInt(string s)
        {
            var dict = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            var result = 0;

            s = s.ToUpper();
            for (int i = 0; i < s.Length - 1; i++)
            {
                result += dict[s[i]];
                if (dict[s[i]] < dict[s[i + 1]])
                {
                    result -= 2*dict[s[i]];
                }
            }
            result += dict[s[s.Length - 1]];

            return result;
        }
    }
}