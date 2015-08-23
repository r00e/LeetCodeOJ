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

    internal class SqrtXSolution
    {
        // Actually this is NOT a well structed Square Root question.
        // Because the return value is an integer number, we can just return the approximation for given number
        // For example:
        // 1 for 1
        // 1 for 2
        // 1 for 3
        // 2 for 4
        // 2 for 5

        public int MySqrt(int x)
        {
            if (x <= 0) return 0;

            var left = 1;
            var right = x;
            var mid = (left + right)/2;

            while (left != mid && right != mid)
            {
                if (mid * mid > x)
                {
                    right = mid;
                    mid = (left + right) / 2;
                }
                else
                {
                    left = mid;
                    mid = (left + right) / 2;
                }                
            }

            return mid;
        }
    }
}