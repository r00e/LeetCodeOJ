using leetCode._09_PalindromeNumber;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class PalindromeNumberFacts
    {
        private readonly PalindromeNumberSolution solution = new PalindromeNumberSolution();
        private readonly PalindromeNumberSolution2 solution2 = new PalindromeNumberSolution2();

        [Theory]
        [InlineData(1, true)]
        [InlineData(10, false)]
        [InlineData(101, true)]
        [InlineData(12345, false)]
        [InlineData(12321, true)]
        [InlineData(-12321, false)]
        public void should_return_(int input, bool value)
        {
            solution.IsPanlidrome(input).ShouldBe(value);
            solution2.IsPanlidrome(input).ShouldBe(value);
        }
    }
}
