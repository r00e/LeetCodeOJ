using System.Collections;
using System.Collections.Generic;
using leetCode._078_SubsetsSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SubsetsFacts
    {
//        private readonly SubsetsRecursiveSolution solution = new SubsetsRecursiveSolution();
//        private readonly SubsetsIterativeSolution solution = new SubsetsIterativeSolution();
        private readonly SubsetsBitManipulationSolution solution = new SubsetsBitManipulationSolution();

        [Fact]
        public void should_return_empty_for_empty()
        {
            solution.Combine(new int[]{}).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_subsuts_for_0()
        {
            solution.Combine(new int[] { 0 }).ShouldBe(new List<IList<int>> { new List<int>(), new List<int> { 0 } });
        }

        [Fact]
        public void should_return_subsuts_for_123()
        {
            var nums = new int[] {1, 2, 3};
            var expectedResult = new List<IList<int>>
            {
                new List<int>(),
                new List<int> {1},
                new List<int> {2},
                new List<int> {3},
                new List<int> {1, 2},
                new List<int> {1, 3},
                new List<int> {2, 3},
                new List<int> {1, 2, 3},
            };
            
            var result = solution.Combine(nums);
            result.Count.ShouldBe(8);
            expectedResult.ForEach(result.ShouldContain);
        }
    }
}