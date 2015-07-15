using leetCode._217_ContainsDuplicateSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ContainsDuplicateFacts
    {
        private readonly ContainsDuplicateSolution solution = new ContainsDuplicateSolution();
        private readonly ContainsDuplicateSolution1 solution1 = new ContainsDuplicateSolution1();

        [Theory]
        [InlineData(null, false)]
        [InlineData(new int[] { }, false)]
        [InlineData(new int[] {1}, false)]
        [InlineData(new int[] {1, 1}, true)]
        [InlineData(new int[] {1, 2, 3}, false)]
        [InlineData(new int[] {1, 2, 2, 3}, true)]
        public void should_judge_whether_int_array_has_duplicated_element(int[] nums, bool expectedValue)
        {
            solution.ContainsDuplicate(nums).ShouldBe(expectedValue);
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData(new int[] { }, false)]
        [InlineData(new int[] {1}, false)]
        [InlineData(new int[] {1, 1}, true)]
        [InlineData(new int[] {1, 2, 3}, false)]
        [InlineData(new int[] {1, 2, 2, 3}, true)]
        public void should_judge_whether_int_array_has_duplicated_element_solution1(int[] nums, bool expectedValue)
        {
            solution1.ContainsDuplicate(nums).ShouldBe(expectedValue);
        }
    }
}