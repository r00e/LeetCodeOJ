using System;

namespace leetCode._003_LengthOfLongestSubstring
{
    class LengthOfLongestSubstringSolution2
    {
        private const int NO_REPEART = -1;

        public int LengthOfLongestSubstring(string s)
        {
            var right = 0;
            var left = 0;
            var max = 0;

            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            while (right < s.Length && left <= right)
            {
                var repeateAt = RepeateAt(s, left, right);
                if (repeateAt == NO_REPEART)
                {
                    right = right + 1;
                }
                else
                {
                    max = Math.Max(max, right - left);
                    left = repeateAt + 1;
                    right = right + 1;
                }
            }

            max = Math.Max(max, right - left);

            return max;
        }

        private static int RepeateAt(string s, int left, int right)
        {
            if (left == right)
            {
                return NO_REPEART;
            }
            while (left < right)
            {
                if (s[left] == s[right])
                {
                    return left;
                }

                left = left + 1;
            }

            return NO_REPEART;
        }
    }
}
