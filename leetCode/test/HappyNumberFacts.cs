using leetCode._202_HappyNumberSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class HappyNumberFacts
    {
        private readonly HappyNumberSolution solution = new HappyNumberSolution();
        private readonly HappyNumberSolution1 solution1 = new HappyNumberSolution1();

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(3, false)]
        [InlineData(4, false)]
        [InlineData(5, false)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        public void should_return_true_for_happy_number_and_fasle_for_unhappy(int num, bool expectedValue)
        {
            solution.IsHappy(num).ShouldBe(expectedValue);
            solution1.IsHappy(num).ShouldBe(expectedValue);
        }
    }
}