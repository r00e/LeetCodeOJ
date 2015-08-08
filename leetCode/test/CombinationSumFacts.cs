using System.Collections.Generic;
using leetCode._039_CombinationSumSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class CombinationSumFacts
    {
        private readonly CombinationSumSolution solution = new CombinationSumSolution();

        [Fact]
        public void should_return_empty_when_target_is_0_and_candidates_are_empty()
        {
            solution.CombinationSum(new int[] {}, 0).ShouldBeEmpty();
        }

        [Fact]
        public void should_return_1_when_target_is_1_and_candidates_are_1()
        {
            var candidates = new int[] {1};
            const int target = 1;
            var expected = new List<IList<int>> {new List<int>() {1}};
            solution.CombinationSum(candidates, target).ShouldBe(expected);
        }

        [Fact]
        public void should_return_empty_when_target_is_0_and_candidates_are_1()
        {
            var candidates = new int[] {1};
            const int target = 0;
            var expected = new List<IList<int>>();
            solution.CombinationSum(candidates, target).ShouldBe(expected);
        }

        [Fact]
        public void should_return_12_when_target_is_3_and_candidates_are_12()
        {
            var candidates = new int[] {1, 2};
            const int target = 3;
            var expected = new List<IList<int>> {new List<int> {1, 2}, new List<int> {1, 1, 1}};
            solution.CombinationSum(candidates, target).ShouldBe(expected);
        }

        [Fact]
        public void should_return_2_11_when_target_is_2_and_candidates_are_12()
        {
            var candidates = new int[] {1, 2};
            const int target = 2;
            var expected = new List<IList<int>> {new List<int>() {2}, new List<int>() {1, 1}};
            solution.CombinationSum(candidates, target).ShouldBe(expected);
        }

        [Fact]
        public void should_return_empty_when_target_is_5_and_candidates_are_24()
        {
            var candidates = new int[] {2, 4};
            const int target = 5;
            var expected = new List<IList<int>>();
            solution.CombinationSum(candidates, target).ShouldBe(expected);
        }

        [Fact]
        public void should_return_5_when_target_is_5_and_candidates_are_2455()
        {
            var candidates = new int[] {2, 4, 5, 5};
            const int target = 5;
            var expected = new List<IList<int>>{new List<int>{5}};
            solution.CombinationSum(candidates, target).ShouldBe(expected);
        }

        [Fact]
        public void should_return_42_222_when_target_is_6_and_candidates_are_224()
        {
            var candidates = new int[] {2, 2, 4};
            const int target = 6;
            var expected = new List<IList<int>> {new List<int> {2, 4}, new List<int> {2, 2, 2}};
            solution.CombinationSum(candidates, target).ShouldBe(expected);
        }
    }
}