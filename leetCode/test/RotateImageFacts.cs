using leetCode._048_RotateImageSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class RotateImageFacts
    {
        private readonly RotateImageSolution solution = new RotateImageSolution();

        [Fact]
        public void should_return_result_for_1x1_matrix()
        {
            var matrix = new int[1,1]{{1}};
            solution.Rotate(matrix);
            matrix.ShouldBe(new int[1,1]{{1}});
        }

        [Fact]
        public void should_return_result_for_2x2_matrix()
        {
            var matrix = new int[2, 2]
            {
                {1, 2}, 
                {3, 4}
            };
            
            solution.Rotate(matrix);

            matrix.ShouldBe(new int[2, 2]
            {
                {3, 1},
                {4, 2}
            });
        }

        [Fact]
        public void should_return_result_for_3x3_matrix()
        {
            var matrix = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            
            solution.Rotate(matrix);

            matrix.ShouldBe(new int[3, 3]
            {
                {7, 4, 1},
                {8, 5, 2},
                {9, 6, 3}
            });
        }

        [Fact]
        public void should_return_result_for_4x4_matrix()
        {
            var matrix = new int[4, 4]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };
            
            solution.Rotate(matrix);

            matrix.ShouldBe(new int[4, 4]
            {
                {13, 9, 5, 1},
                {14, 10, 6, 2},
                {15, 11, 7, 3},
                {16, 12, 8, 4}
            });
        }

        [Fact]
        public void should_return_result_for_5x5_result()
        {
            var matrix = new int[5, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };
            
            solution.Rotate(matrix);

            matrix.ShouldBe(new int[5, 5]
            {
                {21, 16, 11, 6, 1},
                {22, 17, 12, 7, 2},
                {23, 18, 13, 8, 3},
                {24, 19, 14, 9, 4},
                {25, 20, 15, 10, 5},
            });
        }
    }
}