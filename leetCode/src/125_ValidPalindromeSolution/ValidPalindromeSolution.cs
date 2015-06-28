namespace leetCode._125_ValidPalindromeSolution
{
    public class ValidPalindromeSolution
    {
        public bool IsPalindrome(string s)
        {
            if(string.IsNullOrEmpty(s)) return true;

            for (int head = 0, tail = s.Length - 1; head < tail; head++, tail--)
            {
                while (head < tail && !char.IsLetterOrDigit(char.ToLower(s[head]))) head++;
                while (head < tail && !char.IsLetterOrDigit(char.ToLower(s[tail]))) tail--;
                if(char.ToLower(s[head]) != char.ToLower(s[tail])) return false;
            }

            return true;
        }
    }
}