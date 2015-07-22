using System.Collections.Generic;
using leetCode._005_LongestPalindromicSubstringSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class LongestPalindromicSubstringFacts
    {
        private readonly LongestPalindromicSubstringSolution solution = new LongestPalindromicSubstringSolution();
            
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("aba", "aba")]
        [InlineData("aab", "aa")]
        public void should_return_longest_palindrome(string s, string longestPalindromicSubstring)
        {
            solution.LongestPalindrome(s).ShouldBe(longestPalindromicSubstring);
        }
    }
}