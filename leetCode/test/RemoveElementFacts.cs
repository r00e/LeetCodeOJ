using leetCode._027_RemoveElementSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class RemoveElementFacts
    {
        private readonly RemoveElementSolution solution = new RemoveElementSolution();

        [Theory]
        [InlineData(new []{1}, 1, 0)]
        [InlineData(new []{1, 1}, 1, 0)]
        [InlineData(new []{1, 2}, 1, 1)]
        [InlineData(new []{1, 2}, 3, 2)]
        [InlineData(new []{4, 5}, 4, 1)]
        public void should_return_count_after_removing_element(int[] nums, int val, int expectValue)
        {
            solution.RemoveElement(nums, val).ShouldBe(expectValue);
        }
    }
}