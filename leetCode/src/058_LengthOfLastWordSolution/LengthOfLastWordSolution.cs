namespace leetCode._058_LengthOfLastWordSolution
{
    public class LengthOfLastWordSolution
    {
        public int LengthOfLastWord(string s)
        {
            return s.Trim().Length - s.Trim().LastIndexOf(' ') - 1;
        }

        public int LengthOfLastWord2(string s)
        {
            s = s.Trim();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[s.Length - 1 - i] == ' ') return i;
                if (i == s.Length - 1) return i + 1;
            }

            return 0;
        }

        public int LengthOfLastWord3(string s)
        {
            if (s.Length == 0) return 0;
            var lastNonSpace = 0;
            var lastSeperateSpace = -1;
            var index = s.Length - 1;

            while (index >= 0 && s[index] == ' ') index--;
            lastNonSpace = index;
            while (index >= 0 && s[index] != ' ') index--;
            lastSeperateSpace = index;

            return lastNonSpace - lastSeperateSpace;
        }
    }
}