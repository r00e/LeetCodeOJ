using leetCode._064_MinimumPathSumSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class MinimumPathSumFacts
    {
        private readonly MinimumPathSumSolution solution = new MinimumPathSumSolution();

        [Fact]
        public void should_return_0_for_empty()
        {
            solution.MinPathSum(new int[,] { }).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_for_1x1_grid_1()
        {
            solution.MinPathSum(new int[,] {{1}}).ShouldBe(1);
        }

        [Fact]
        public void should_return_3_for_1x2_grid_12()
        {
            solution.MinPathSum(new int[,] {{1, 2}}).ShouldBe(3);
        }

        [Fact]
        public void should_return_3_for_2x1_grid_12()
        {
            solution.MinPathSum(new int[,] {{1}, {2}}).ShouldBe(3);
        }

        [Fact]
        public void should_return_7_for_2x2_grid_1234()
        {
            solution.MinPathSum(new int[,]
            {
                {1, 2},
                {3, 4}
            }).ShouldBe(7);
        }

        [Fact]
        public void should_return_6_for_2x2_grid_1214()
        {
            solution.MinPathSum(new int[,]
            {
                {1, 2},
                {1, 4}
            }).ShouldBe(6);
        }

        [Fact]
        public void should_return_5_for_3x3_grid_123141111()
        {
            solution.MinPathSum(new int[,]
            {
                {1, 2, 3},
                {1, 4, 1},
                {1, 1, 1}
            }).ShouldBe(5);
        }
    }
}