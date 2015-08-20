using leetCode._059_SpiralMatrixIISolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SpiralMatrixIIFacts
    {
        private readonly SprialMatrixIISolution solution = new SprialMatrixIISolution();

        [Fact]
        public void should_return_null_for_any_n_less_than_1()
        {
            solution.GenerateMatrix(0).ShouldBeNull();
        }

        [Fact]
        public void should_return_matrix_1_for_1()
        {
            solution.GenerateMatrix(1).ShouldBe(new int[,]{{1}});
        }

        [Fact]
        public void should_return_matrix_1243_for_2()
        {
            solution.GenerateMatrix(2).ShouldBe(new int[,]
            {
                {1, 2},
                {4, 3}
            });
        }

        [Fact]
        public void should_return_matrix_123_for_3()
        {
            solution.GenerateMatrix(3).ShouldBe(new int[,]
            {
                {1, 2, 3},
                {8, 9, 4},
                {7, 6, 5}
            });
        }
    }
}