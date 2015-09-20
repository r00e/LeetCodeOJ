using System.Collections.Generic;
using leetCode._120_Triangle;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class TriangleFacts
    {
        private readonly TriangleSolution solution = new TriangleSolution();

        [Fact]
        public void should_return_0_for_triangle_0()
        {
            solution.MinimumTotal(new List<IList<int>> {new List<int> {0}}).ShouldBe(0);
        }

        [Fact]
        public void should_return_2_for_triangle_1_11()
        {
            solution.MinimumTotal(new List<IList<int>> {new List<int> {1}, new List<int> {1, 1}}).ShouldBe(2);
        }

        [Fact]
        public void should_return_1_for_triangle_1_10()
        {
            solution.MinimumTotal(new List<IList<int>> {new List<int> {1}, new List<int> {1, 0}}).ShouldBe(1);
        }

        [Fact]
        public void should_return_4_for_triangle_1_23_930()
        {
            solution.MinimumTotal(new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {2, 3},
                new List<int> {9, 3, 0}
            }).ShouldBe(4);
        }

        [Fact]
        public void should_return_14_for_triangle_2_34_659_4480()
        {
            solution.MinimumTotal(new List<IList<int>>
            {
                new List<int> {2},
                new List<int> {3, 4},
                new List<int> {6, 5, 9},
                new List<int> {4, 4, 8, 0}
            }).ShouldBe(14);
        }
    }
}