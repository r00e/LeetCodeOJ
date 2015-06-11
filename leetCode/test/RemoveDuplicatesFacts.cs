using leetCode._025_RemoveDuplicatsFromSortedArray;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class RemoveDuplicatesFacts
    {
        private readonly RemoveDuplicatesSolution solution = new RemoveDuplicatesSolution();

        [Theory]
        [InlineData(new []{1}, 1)]
        [InlineData(new []{1, 2}, 2)]
        [InlineData(new []{1, 1, 2}, 2)]
        [InlineData(new []{1, 2, 2, 3, 4, 4}, 4)]
        public void should_return_counts_of_non_duplicated_elements(int[] nums, int expectValue)
        {
            solution.RemoveDuplicates(nums).ShouldBe(expectValue);
        }
    }
}