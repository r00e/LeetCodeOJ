using leetCode._013_RomanToInteger;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class RomanToIntegerFacts
    {
        private readonly RomanToIntegerSolution solution = new RomanToIntegerSolution();

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("MMMCMXCIX", 3999)]
        public void should_return_(string input, int expectedValue)
        {
            solution.RomanToInt(input).ShouldBe(expectedValue);
        }
    }
}
