using leetCode._219_ContainsDuplicateIISolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ContainsDuplicateIIFacts
    {
        private readonly ContainsDuplicateIISolution solution = new ContainsDuplicateIISolution();

        [Theory]
        [InlineData(null, 0, false)]
        [InlineData(new int[]{}, 0, false)]
        [InlineData(new int[]{1}, 0, false)]
        [InlineData(new int[]{1, 1}, 0, false)]
        [InlineData(new int[]{1, 1}, 1, true)]
        [InlineData(new int[]{1, 2, 1}, 1, false)]
        [InlineData(new int[]{1, 2, 1}, 2, true)]
        [InlineData(new int[]{1, 2, 1}, 3, true)]
        public void should_judge_whether_int_array_has_duplicated_element(int[] nums, int k, bool expectedValue)
        {
            solution.ContainsNearbyDuplicate(nums, k).ShouldBe(expectedValue);
        }
    }
}