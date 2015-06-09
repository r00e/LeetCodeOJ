using leetCode._020_ValidParenthesesSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ValidParenthesesFacts
    {
        private readonly ValidParenthesesSolution solution = new ValidParenthesesSolution();

        [Theory]
        [InlineData("]", false)]
        [InlineData("()", true)]
        [InlineData("(]", false)]
        [InlineData("([])", true)]
        [InlineData("([{])", false)]
        public void should_valid_parentheses(string input, bool expectedValue)
        {
            solution.IsValid(input).ShouldBe(expectedValue);
        }
    }
}
