using leetCode._001_TwoSum;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class TwoSumFacts
    {
        [Fact]
        public void should_return_1_and_2_when_input_is_0_0_0()
        {
            TwoSumSolution.TwoSum(new int[] {0, 0}, 0).ShouldBe(new int[]{1, 2});
        }
    }
}
