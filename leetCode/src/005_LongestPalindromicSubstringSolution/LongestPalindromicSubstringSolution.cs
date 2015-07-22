namespace leetCode._005_LongestPalindromicSubstringSolution
{
    public class LongestPalindromicSubstringSolution
    {
        public string LongestPalindrome(string s)
        {
            if(s.Length <= 1) return s;

            int startIndex = 0, maxLength = 0;
            
            for (var i = 0; i < s.Length;)
            {
                if (s.Length - i <= maxLength/2) break;
                
                var findEndIndex = i;
                var findStartIndex = i;

                while ( findEndIndex < s.Length - 1 && 
                        s[findEndIndex] == s[findEndIndex + 1]) 
                    findEndIndex++;
                
                i = findEndIndex + 1;
                
                while ( findEndIndex < s.Length - 1 && 
                        findStartIndex > 0 && 
                        s[findStartIndex - 1] == s[findEndIndex + 1])
                {
                    findStartIndex--;
                    findEndIndex++;
                }

                var newPalinDromicSubstringLenght = findEndIndex - findStartIndex + 1;
                if (newPalinDromicSubstringLenght > maxLength)
                {
                    maxLength = newPalinDromicSubstringLenght;
                    startIndex = findStartIndex;
                }
            }

            return s.Substring(startIndex, maxLength);
        }
    }
}