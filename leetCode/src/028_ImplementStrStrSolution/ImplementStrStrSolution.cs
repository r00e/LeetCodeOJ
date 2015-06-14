using System.Collections.Generic;

namespace leetCode._028_ImplementStrStrSolution
{
    public class ImplementStrStrSolution
    {
        // KMP
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length < needle.Length) return -1;
            if (haystack.Length == 0 && needle.Length == 0) return 0;
            if (needle.Length == 0) return 0;

            var kmpHelper = KmpHelper(needle);
            var matchedIndex = -1;
            for (var i = 0; i < haystack.Length; i++)
            {
                while (matchedIndex > -1 && haystack[i] != needle[matchedIndex + 1])
                {
                    matchedIndex = kmpHelper[matchedIndex];
                }

                if(needle[matchedIndex + 1] == haystack[i]) matchedIndex++;
                if (matchedIndex == needle.Length - 1) return i - needle.Length + 1;
            }

            return -1;
        }

        private Dictionary<int, int> KmpHelper(string str)
        {
            var dict = new Dictionary<int, int> {{0, -1}};
            var kmpIndex = -1;

            for (var i = 1; i < str.Length; i++)
            {
                while (kmpIndex > -1 && str[i] != str[kmpIndex+1])
                {
                    kmpIndex = dict[kmpIndex];
                }

                if (str[i] == str[kmpIndex+1])
                {
                    kmpIndex = kmpIndex + 1;
                }

                dict.Add(i, kmpIndex);
            }

            return dict;
        }
    }
}