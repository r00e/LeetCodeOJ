using System.Collections.Generic;
using System.Linq;
using leetCode._015_3SumSolution;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ThreeSumFacts
    {
        private readonly ThreeSumSolution solution = new ThreeSumSolution();

        [Fact]
        public void should_return_empty_when_input_is_null()
        {
            solution.ThreeSum(null).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_empty_when_input_length_is_less_than_3()
        {
            solution.ThreeSum(new int[] { 0 }).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_empty_when_input_have_no_triplets_which_sum_is_0()
        {
            var nums = new int[] {1, 2, 3};
            solution.ThreeSum(nums).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_1_triplet_which_sum_is_0_when_input_is_0_0_0()
        {
            var nums = new int[] {0, 0, 0};
            var result = solution.ThreeSum(nums);
            result.Count.ShouldBe(1);
        }

        [Fact]
        public void should_return_1_triplet_which_sum_is_0_when_input_is_minus3_1_2()
        {
            var nums = new int[] {-3, 1, 2};
            var result = solution.ThreeSum(nums);
            result.Count.ShouldBe(1);
        }

        [Fact]
        public void should_return_2_triplets_which_sum_is_0_when_input_is_minus2_minus1_0_1_2()
        {
            var nums = new int[] {-2, -1, 0, 1, 2};
            var result = solution.ThreeSum(nums);
            result.Count.ShouldBe(2);
        }

        [Fact]
        public void should_return_triplets_which_is_in_ascending_order()
        {
            var nums = new int[] {1, 0, -1};
            var triplet = solution.ThreeSum(nums).First();
            triplet[0].ShouldBeLessThanOrEqualTo(triplet[1]);
            triplet[1].ShouldBeLessThanOrEqualTo(triplet[2]);
        }

        [Fact]
        public void should_return_distinct_triplets()
        {
            solution.ThreeSum(new int[] {1, 0, -1, -1}).Count.ShouldBe(1);
            solution.ThreeSum(new int[] {1, 0, 0, 1, -1, -1}).Count.ShouldBe(1);
        }
    }
}
