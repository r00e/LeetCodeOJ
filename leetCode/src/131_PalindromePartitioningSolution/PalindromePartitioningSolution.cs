using System.Collections.Generic;
using System.Linq;

namespace leetCode._131_PalindromePartitioningSolution
{
    public class PalindromePartitioningSolution
    {
        private List<IList<string>> result;
        private List<string> resultItem;

        public IList<IList<string>> Partition(string s)
        {
            result = new List<IList<string>>();
            resultItem = new List<string>();
            GeneratePartition(s, 0);

            return result;
        }

        private void GeneratePartition(string str, int startIndex)
        {
            if (resultItem.Count > 0 && startIndex >= str.Length)
            {
                var resultItemCopy = new string[resultItem.Count];
                resultItem.CopyTo(resultItemCopy);
                result.Add(resultItemCopy.ToList());
            }
            for (var i = startIndex; i < str.Length; i++)
            {
                var substring = str.Substring(startIndex, i - startIndex + 1);
                if (IsPalindrome(substring))
                {
                    resultItem.Add(substring);
                    GeneratePartition(str, i + 1);
                    resultItem.RemoveAt(resultItem.Count - 1);                    
                }
            }
        }

        private bool IsPalindrome(string s)
        {
            for (var i = 0; i < s.Length/2; i++)
            {
                if (s[i] != s[s.Length - 1 - i]) return false;
            }

            return true;
        }
    }
}