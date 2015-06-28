using System;
using System.Linq;
using leetCode._119_PascalTriangleIISolution;
using leetCode._125_ValidPalindromeSolution;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ValidPalindromeFacts
    {
        private readonly ValidPalindromeSolution solution = new ValidPalindromeSolution();

        [Theory]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData("a", true)]
        [InlineData("ab", false)]
        [InlineData("aba", true)]
        [InlineData("a.", true)]
        [InlineData(".a", true)]
        [InlineData("a a.", true)]
        [InlineData("a A.", true)]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("1a, 1", true)]
        [InlineData("1a, 2", false)]
        public void should_return_result_for_string(string input, bool expectedValue)
        {
            solution.IsPalindrome(input).ShouldBe(expectedValue);
        }
    }
}