using leetCode._073_SetMatrixZeroesSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SetMatrixZeroesFacts
    {
        private readonly SetMatrixZeroesSolution solution = new SetMatrixZeroesSolution();

        [Fact]
        public void should_do_nothing_to_empty_matrix()
        {
            var matrix = new int[0, 0];
            solution.SetZeroes(matrix);
            matrix.ShouldBe(new int[0,0]);
        }

        [Fact]
        public void should_update_1x1_matrix_1_to_1()
        {
            var matrix = new int[1, 1]{{1}};
            solution.SetZeroes(matrix);
            matrix.ShouldBe(new int[1,1]{{1}});
        }

        [Fact]
        public void should_update_1x1_matrix_0_to_0()
        {
            var matrix = new int[1, 1]{{0}};
            solution.SetZeroes(matrix);
            matrix.ShouldBe(new int[1,1]{{0}});
        }

        [Fact]
        public void should_update_1x2_matrix_10_to_00()
        {
            var matrix = new int[1, 2] {{1, 0}};
            solution.SetZeroes(matrix);
            matrix.ShouldBe(new int[1, 2] {{0, 0}});
        }

        [Fact]
        public void should_update_2x1_matrix_10_to_00()
        {
            var matrix = new int[2, 1] {{1}, {0}};
            solution.SetZeroes(matrix);
            matrix.ShouldBe(new int[2, 1] {{0}, {0}});
        }

        [Fact]
        public void should_update_2x2_matrix_1101_to_0100()
        {
            var matrix = new int[2, 2]
            {
                {1,1}, 
                {0,1}
            };
            solution.SetZeroes(matrix);
            matrix.ShouldBe(new int[2, 2]
            {
                {0, 1}, 
                {0, 0}
            });
        }

        [Fact]
        public void should_update_3x3_matrix_111101111_to_101000101()
        {
            var matrix = new int[3, 3]
            {
                {1,1,1}, 
                {1,0,1},
                {1,1,1},
            };
            solution.SetZeroes(matrix);
            matrix.ShouldBe(new int[3, 3]
            {
                {1, 0, 1},
                {0, 0, 0},
                {1, 0, 1}
            });
        }
    }
}