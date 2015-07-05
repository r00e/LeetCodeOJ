using leetCode._189_RotateArraySolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class RotateArrayFacts
    {
        private readonly RotateArraySolution solution = new RotateArraySolution();

        [Fact]
        public void should_return_1_when_rotate_array_1_by_0()
        {
            var nums = new int[] {1};
            solution.Rotate(nums, 0);
            nums.ShouldBe(new int[]{1});
        }

        [Fact]
        public void should_return_1_when_rotate_array_1_by_1()
        {
            var nums = new int[] {1};
            solution.Rotate(nums, 1);
            nums.ShouldBe(new int[]{1});
        }

        [Fact]
        public void should_return_1_when_rotate_array_1_by_2()
        {
            var nums = new int[] {1};
            solution.Rotate(nums, 2);
            nums.ShouldBe(new int[]{1});
        }

        [Fact]
        public void should_return_21_when_rotate_array_12_by_1()
        {
            var nums = new int[] {1, 2};
            solution.Rotate(nums, 1);
            nums.ShouldBe(new int[]{2, 1});
        }

        [Fact]
        public void should_return_12_when_rotate_array_12_by_2()
        {
            var nums = new int[] {1, 2};
            solution.Rotate(nums, 2);
            nums.ShouldBe(new int[] {1, 2});
        }

        [Fact]
        public void should_return_312_when_rotate_array_123_by_1()
        {
            var nums = new int[] {1, 2, 3};
            solution.Rotate(nums, 1);
            nums.ShouldBe(new int[] {3, 1, 2});
        }

        [Fact]
        public void should_return_231_when_rotate_array_123_by_2()
        {
            var nums = new int[] {1, 2, 3};
            solution.Rotate(nums, 2);
            nums.ShouldBe(new int[] {2, 3, 1});
        }
    }
}