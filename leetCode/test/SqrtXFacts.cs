using leetCode._069_SqrtXSolution;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class SqrtXFacts
    {
        private readonly SqrtXSolution solution = new SqrtXSolution();

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        [InlineData(4, 2)]
        [InlineData(6, 2)]
        [InlineData(8, 2)]
        [InlineData(9, 3)]
        [InlineData(10, 3)]
        [InlineData(100, 10)]
        public void should_return_square_root_for_given_number(int givenNumber, int squareRoot)
        {
            solution.MySqrt(givenNumber).ShouldBe(squareRoot);
        }
    }
}