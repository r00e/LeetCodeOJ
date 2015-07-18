using leetCode._231_PowerOfTwoSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class PowerOfTwoFacts
    {
        private readonly PowerOfTwoSolution solution = new PowerOfTwoSolution();
            
        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(127, false)]
        [InlineData(128, true)]
        public void should_judge_whether_input_is_power_of_two(int n, bool expectedValue)
        {
            solution.IsPowerOfTwo(n).ShouldBe(expectedValue);
        }
    }
}