using leetCode._031_NextPermutationSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class NextPermutationFacts
    {
        private readonly NextPermutationSolution solution = new NextPermutationSolution();

        [Fact]
        public void should_get_empty_for_empty()
        {
            var nums = new int[] {};

            solution.NextPermutation(nums);
            nums.ShouldBe(nums);
        }

        [Fact]
        public void should_get_1_for_1()
        {
            var nums = new int[] {1};

            solution.NextPermutation(nums);
            nums.ShouldBe(new int[]{1});
        }

        [Fact]
        public void should_get_12_for_12()
        {
            var nums = new int[] {1, 2};

            solution.NextPermutation(nums);
            nums.ShouldBe(new int[]{2, 1});
        }

        [Fact]
        public void should_get_132_for_123()
        {
            var nums = new int[] {1, 2, 3};

            solution.NextPermutation(nums);
            nums.ShouldBe(new int[]{1, 3, 2});
        }

        [Fact]
        public void should_get_213_for_132()
        {
            var nums = new int[] {1, 3, 2};

            solution.NextPermutation(nums);
            nums.ShouldBe(new int[]{2, 1, 3});
        }

        [Fact]
        public void should_get_231_for_213()
        {
            var nums = new int[] {2, 1, 3};

            solution.NextPermutation(nums);
            nums.ShouldBe(new int[]{2, 3, 1});
        }

        [Fact]
        public void should_get_123_for_321()
        {
            var nums = new int[] {3, 2, 1};

            solution.NextPermutation(nums);
            nums.ShouldBe(new int[]{1, 2, 3});
        }

        [Fact]
        public void should_get_552347_for_547532()
        {
            var nums = new int[] {5, 4, 7, 5, 3, 2};

            solution.NextPermutation(nums);
            nums.ShouldBe(new int[]{5, 5, 2, 3, 4, 7});
        }
    }
}