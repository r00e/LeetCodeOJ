using leetCode._063_UniquePathsIISolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class UniquePathsIIFacts
    {
        private readonly UniquePathsIISolution solution = new UniquePathsIISolution();

        [Fact]
        public void should_return_0_for_empty()
        {
            var obstacleGrid = new int[,] { };
            solution.UniquePathsWithObstacles(obstacleGrid).ShouldBe(0);
        }

        [Fact]
        public void should_return_0_for_any_grid_with_0_dimension()
        {
            var obstacleGrid = new int[0,1];
            solution.UniquePathsWithObstacles(obstacleGrid).ShouldBe(0);

            obstacleGrid = new int[1,0];
            solution.UniquePathsWithObstacles(obstacleGrid).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_for_1_dimension_grid()
        {
            var obstacleGrid = new int[1,2];
            solution.UniquePathsWithObstacles(obstacleGrid).ShouldBe(1);

            obstacleGrid = new int[2,1];
            solution.UniquePathsWithObstacles(obstacleGrid).ShouldBe(1);
        }

        [Fact]
        public void should_return_0_for_given_1x3_grid_010()
        {
            var obstacleGrid = new int[1,3]
            {
                {0, 1, 0}
            };
            solution.UniquePathsWithObstacles(obstacleGrid).ShouldBe(0);
        }

        [Fact]
        public void should_return_0_for_given_3x1_grid_010()
        {
            var obstacleGrid = new int[3, 1]
            {
                {0},
                {1},
                {0}
            };
            
            solution.UniquePathsWithObstacles(obstacleGrid).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_for_given_2x2_grid_0100()
        {
            var obstacleGrid = new int[2, 2]
            {
                {0, 1},
                {0, 0}
            };

            solution.UniquePathsWithObstacles(obstacleGrid).ShouldBe(1);
        }

        [Fact]
        public void should_return_2_for_given_3x3_grid_000010000()
        {
            var obstacleGrid = new int[3, 3]
            {
                {0, 0, 0},
                {0, 1, 0},
                {0, 0, 0},
            };

            solution.UniquePathsWithObstacles(obstacleGrid).ShouldBe(2);
        }
    }
}