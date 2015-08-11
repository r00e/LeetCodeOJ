using System.Collections.Generic;
using leetCode._046_PermutationSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class PermutationsFacts
    {
        private readonly PermutationsSolution solution = new PermutationsSolution();

        [Fact]
        public void should_return_1_for_1()
        {
            solution.Permute(new int[] {1}).ShouldBe(new List<IList<int>> {new List<int> {1}});
        }

        [Fact]
        public void should_return_12_and_21_for_12()
        {
            solution.Permute(new int[] {1, 2})
                .ShouldBe(new List<IList<int>> {new List<int> {1, 2}, new List<int> {2, 1}});
        }

        [Fact]
        public void should_return_123_132_213_231_312_and_321_for_123()
        {
            solution.Permute(new int[] {1, 2, 3})
                .ShouldBe(new List<IList<int>>
                {
                    new List<int> {1, 2, 3},
                    new List<int> {1, 3, 2},
                    new List<int> {2, 1, 3},
                    new List<int> {2, 3, 1},
                    new List<int> {3, 1, 2},
                    new List<int> {3, 2, 1}
                });
        }
    }
}