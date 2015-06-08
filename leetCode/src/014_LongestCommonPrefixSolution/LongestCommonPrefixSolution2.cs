using System;

namespace leetCode._014_LongestCommonPrefixSolution
{
    public class LongestCommonPrefixSolution2
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            var result = strs[0];

            for (var i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(result) != 0) 
                    result = result.Substring(0, result.Length - 1);
            }

            return result;
        }
    }
}