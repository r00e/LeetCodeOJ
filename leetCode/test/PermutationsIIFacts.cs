using System.Collections.Generic;
using leetCode._047_PermutationsIISolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class PermutationsIIFacts
    {
        private readonly PermutationsIISolution solution = new PermutationsIISolution();

        [Fact]
        public void should_return_permutation_for_empty()
        {
            solution.PermuteUnique(new int[] {}).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_permutation_for_0()
        {
            solution.PermuteUnique(new[] { 0 }).ShouldBe(new List<IList<int>>
            {
                new List<int> {0}
            });            
        }

        [Fact]
        public void should_return_permutation_for_01()
        {
            solution.PermuteUnique(new[] { 0, 1 }).ShouldBe(new List<IList<int>>
            {
                new List<int> {0, 1},
                new List<int> {1, 0}
            });            
        }

        [Fact]
        public void should_return_permutation_for_012()
        {
            solution.PermuteUnique(new[] {0, 1, 2}).ShouldBe(new List<IList<int>>
            {
                new List<int> {0, 1, 2},
                new List<int> {0, 2, 1},
                new List<int> {1, 0, 2},
                new List<int> {1, 2, 0},
                new List<int> {2, 1, 0},
                new List<int> {2, 0, 1},
            });
        }

        [Fact]
        public void should_return_permutation_for_00()
        {
            solution.PermuteUnique(new[] { 0, 0 }).ShouldBe(new List<IList<int>>
            {
                new List<int> {0, 0}
            });            
        }

        [Fact]
        public void should_return_permutation_for_001()
        {
            solution.PermuteUnique(new[] {0, 0, 1}).ShouldBe(new List<IList<int>>
            {
                new List<int> {0, 0, 1},
                new List<int> {0, 1, 0},
                new List<int> {1, 0, 0}
            });
        }
    }
}