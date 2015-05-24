namespace leetCode._03_LengthOfLongestSubstring
{
    class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            return s.Length;
        }
    }
}
