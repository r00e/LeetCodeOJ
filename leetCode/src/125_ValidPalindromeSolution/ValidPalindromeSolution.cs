namespace leetCode._125_ValidPalindromeSolution
{
    public class ValidPalindromeSolution
    {
        public bool IsPalindrome(string s)
        {
            if(string.IsNullOrEmpty(s)) return true;

            var endCharIndex = s.Length - 1;
            while (!IsValidChar(s[endCharIndex]))
            {
                endCharIndex--;
                if (endCharIndex < 0) return true;
            }

            for (var i = 0; i < endCharIndex; i++)
            {
                while (!IsValidChar(s[i]))
                {
                    i++;
                }

                if (char.ToLower(s[i]) != char.ToLower(s[endCharIndex]))
                {
                    return false;
                }
                else if(i != endCharIndex)
                {
                    endCharIndex--;
                    while (!IsValidChar(s[endCharIndex]))
                    {
                        endCharIndex--;
                    }
                }
            }
            return true;
        }

        private static bool IsValidChar(char c)
        {
            c = char.ToLower(c);
            return (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
        }
    }
}