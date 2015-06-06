using leetCode._07_ReverseIntegerSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ReverseIntegerFacts
    {
        private readonly ReverseIntegerSolution solution = new ReverseIntegerSolution();

        [Theory]
        [InlineData(1, 1)]
        [InlineData(12, 21)]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(1534236469, 0)]
        [InlineData(-2147483412, -2143847412)]
        public void should_return_reversed_integer(int integer, int expectedValue)
        {
            solution.Reverse(integer).ShouldBe(expectedValue);
        }
    }
}
