using leetCode._074_Search2DMatrixSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class Search2DMatrixFacts
    {
        private readonly Search2DMatrixSolution solution = new Search2DMatrixSolution();

        [Fact]
        public void should_false_for_empty_matrix()
        {
            solution.SearchMatrix(new int[0, 0], 0).ShouldBeFalse();
        }

        [Fact]
        public void should_false_when_search_0_in_1x1_matrix_1()
        {
            solution.SearchMatrix(new int[,]{{1}}, 0).ShouldBeFalse();
        }

        [Fact]
        public void should_true_when_search_1_in_1x1_matrix_1()
        {
            solution.SearchMatrix(new int[,]{{1}}, 1).ShouldBeTrue();
        }

        [Fact]
        public void should_true_when_search_2_in_1x2_matrix_12()
        {
            solution.SearchMatrix(new int[,] {{1, 2}}, 2).ShouldBeTrue();
        }

        [Fact]
        public void should_true_when_search_4_in_3x3_matrix_123456()
        {
            solution.SearchMatrix(new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            }, 4).ShouldBeTrue();
        }
    }
}