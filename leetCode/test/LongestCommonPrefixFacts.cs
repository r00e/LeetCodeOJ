using System;
using leetCode._013_RomanToInteger;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class LongestCommonPrefixFacts
    {
        private readonly LongestCommonPrefixSolution solution = new LongestCommonPrefixSolution();

        [Theory]
        [InlineData(null, "")]
        [InlineData(new string[]{}, "")]
        public void should_return_longest_common_prefix(string[] input, string expectedValue)
        {
            solution.LongestCommonPrefix(input).ShouldBe(expectedValue);
        }
    }

    internal class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] input)
        {
            return "";
        }
    }
}
