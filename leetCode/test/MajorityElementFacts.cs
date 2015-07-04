using leetCode._169_MajorityElementSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class MajorityElementFacts
    {
        private readonly MajorityElementSolution solution = new MajorityElementSolution();

        [Theory]
        [InlineData(new int[]{0}, 0)]
        [InlineData(new int[]{1}, 1)]
        [InlineData(new int[]{1, 1, 2}, 1)]
        [InlineData(new int[]{0, 1, 1}, 1)]
        [InlineData(new int[]{0, 2, 2, 2, 1}, 2)]
        public void should_return_majority_element_for_array(int[] nums, int majority)
        {
            solution.MajorityElement(nums).ShouldBe(majority);
        }
    }
}