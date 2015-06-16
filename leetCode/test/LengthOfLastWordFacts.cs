using leetCode._058_LengthOfLastWordSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class LengthOfLastWordFacts
    {
        private readonly LengthOfLastWordSolution solution = new LengthOfLastWordSolution();

        [Theory]
        [InlineData("", 0)]
        [InlineData("a", 1)]
        [InlineData("a ", 1)]
        [InlineData("a bc", 2)]
        public void should_return_integer(string s, int expectedValue)
        {
            solution.LengthOfLastWord(s).ShouldBe(expectedValue);
            solution.LengthOfLastWord2(s).ShouldBe(expectedValue);
            solution.LengthOfLastWord3(s).ShouldBe(expectedValue);
        }
    }
}
