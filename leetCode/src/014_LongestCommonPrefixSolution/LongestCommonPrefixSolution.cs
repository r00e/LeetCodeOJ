using System;

namespace leetCode._014_LongestCommonPrefixSolution
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            var result = strs[0];

            foreach (var str in strs)
            {
                var i = 0;
                for (; i < strs[0].Length && i < str.Length; i++)
                {
                    if (strs[0][i] != str[i])
                    {
                        var tmpResult = strs[0].Substring(0, i);
                        result = tmpResult.Length < result.Length ? tmpResult : result;
                    }
                    else if (i == strs[0].Length - 1 || i == str.Length - 1)
                    {
                        var tmpResult = strs[0].Substring(0, Math.Min(strs[0].Length, str.Length));
                        result = tmpResult.Length < result.Length ? tmpResult : result; 
                    }
                }
                if (i == 0) result = "";
            }

            return result;
        }
    }
}