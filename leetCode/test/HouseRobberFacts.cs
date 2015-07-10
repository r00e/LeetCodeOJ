using leetCode._198_HouseRobberSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class HouseRobberFacts
    {
        private readonly HouseRobberSolution solution = new HouseRobberSolution();
        private readonly HouseRobberSolution2 solution2 = new HouseRobberSolution2();

        [Theory]
        [InlineData(new int[]{}, 0)]
        [InlineData(new int[]{1}, 1)]
        [InlineData(new int[]{2}, 2)]
        [InlineData(new int[]{1, 2}, 2)]
        [InlineData(new int[]{1, 2, 3}, 4)]
        public void should_return_max_amount_can_be_robbed_safely(int[] nums, int maxAmount)
        {
            solution.Rob(nums).ShouldBe(maxAmount);
            solution2.Rob(nums).ShouldBe(maxAmount);
        }
    }
}