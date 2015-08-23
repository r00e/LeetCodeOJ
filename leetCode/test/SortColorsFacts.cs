using leetCode._075_SortColorsSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SortColorsFacts
    {
        private readonly SortColorsSolution solution = new SortColorsSolution();

        [Fact]
        public void should_do_nothing_for_empty()
        {
            var nums = new int[]{};
            solution.SortColors(nums);
            nums.ShouldBe(new int[]{});
        }

        [Fact]
        public void should_sort_color_for_102()
        {
            var nums = new int[] {1, 0, 2};
            solution.SortColors(nums);
            nums.ShouldBe(new int[] {0, 1, 2});
        }

        [Fact]
        public void should_sort_color_for_012()
        {
            var nums = new int[] {0, 1, 2};
            solution.SortColors(nums);
            nums.ShouldBe(new int[] {0, 1, 2});
        }

        [Fact]
        public void should_sort_color_for_0120()
        {
            var nums = new int[] {0, 1, 2, 0};
            solution.SortColors(nums);
            nums.ShouldBe(new int[] {0, 0, 1, 2});
        }
    }
}