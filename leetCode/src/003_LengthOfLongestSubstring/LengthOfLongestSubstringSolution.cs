using System;
using System.Collections.Generic;

namespace leetCode._003_LengthOfLongestSubstring
{
    class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var dict = new Dictionary<char, int>();
            var max = 0;
            var begin = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], i);
                }
                else if(dict[s[i]] < begin)
                {
                    dict[s[i]] = i;
                }
                else
                {
                    max = Math.Max(i-begin, max);
                    begin = dict[s[i]] + 1;
                    dict[s[i]] = i;
                }
            }

            max = Math.Max(s.Length - begin, max);

            return max;
        }
    }
}
