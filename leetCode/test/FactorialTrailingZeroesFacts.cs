using leetCode._172_FactorialTrailingZeroesSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class FactorialTrailingZeroesFacts
    {
        private readonly FactorialTrailingZeroesSolution solution = new FactorialTrailingZeroesSolution();

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(5, 1)]
        [InlineData(10, 2)]
        public void should_return_trailing_count_for_factorial(int num, int expectedValue)
        {
            solution.TrailingZeroes(num).ShouldBe(expectedValue);
        }
    }
}