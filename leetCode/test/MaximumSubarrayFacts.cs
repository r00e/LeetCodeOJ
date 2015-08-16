using leetCode._053_MaximumSubArraySolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class MaximumSubarrayFacts
    {
        private readonly MaximumSubarraySolution solution = new MaximumSubarraySolution();

        [Fact]
        public void should_return_0_for_empty()
        {
            solution.MaxSubArray(new int[]{}).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_for_1()
        {
            solution.MaxSubArray(new int[]{1}).ShouldBe(1);
        }

        [Fact]
        public void should_return_3_for_12()
        {
            solution.MaxSubArray(new int[] {1, 2}).ShouldBe(3);
        }

        [Fact]
        public void should_return_5_for_m123()
        {
            solution.MaxSubArray(new int[] {-1, 2, 3}).ShouldBe(5);
        }
    }
}