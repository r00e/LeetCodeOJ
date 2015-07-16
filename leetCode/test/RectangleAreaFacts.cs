using leetCode._223_RectangleAreaSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class RectangleAreaFacts
    {
        private readonly RectangleAreaSolution solution = new RectangleAreaSolution();

        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0, 0, 0, 0)]
        [InlineData(0, 0, 1, 1, 1, 1, 2, 2, 2)]
        [InlineData(0, 0, 4, 1, 1, 2, 3, 3, 6)]
        [InlineData(0, 0, 4, 1, 1, 2, 3, 3, 6)]
        [InlineData(0, 0, 2, 2, 1, 1, 3, 3, 7)]
        [InlineData(0, 0, 2, 2, -1, -1, 1, 1, 7)]
        [InlineData(0, 0, 2, 2, -1, 1, 1, 3, 7)]
        [InlineData(0, 0, 2, 2, 1, -1, 3, 1, 7)]
        public void should_area_of_two_rectangle(int A, int B, int C, int D, int E, int F, int G, int H, int area)
        {
            solution.ComputeArea(A, B, C, D, E, F, G, H).ShouldBe(area);
        }
    }
}