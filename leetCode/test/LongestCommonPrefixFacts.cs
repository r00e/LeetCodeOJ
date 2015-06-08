using leetCode._014_LongestCommonPrefixSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class LongestCommonPrefixFacts
    {
        private readonly LongestCommonPrefixSolution solution = new LongestCommonPrefixSolution();
        private readonly LongestCommonPrefixSolution2 solution2 = new LongestCommonPrefixSolution2();

        [Theory]
        [InlineData(null, "")]
        [InlineData(new string[]{}, "")]
        [InlineData(new string[]{"a"}, "a")]
        [InlineData(new string[]{"a", "b"}, "")]
        [InlineData(new string[]{"aaa", "aa", "aaa"}, "aa")]
        [InlineData(new string[]{"a", "ab"}, "a")]
        [InlineData(new string[]{"ab", "abc"}, "ab")]
        [InlineData(new string[]{"abd", "abc", "abe"}, "ab")]
        [InlineData(new string[]{"abab", "aba", ""}, "")]
        public void should_return_longest_common_prefix(string[] input, string expectedValue)
        {
            solution.LongestCommonPrefix(input).ShouldBe(expectedValue);
            solution2.LongestCommonPrefix(input).ShouldBe(expectedValue);
        }
    }
}
