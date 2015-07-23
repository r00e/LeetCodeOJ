using leetCode._011_ContainerWithMostWaterSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ContainerWithMostWaterFacts
    {
        private readonly ContainerWithMostWaterSolution solution = new ContainerWithMostWaterSolution();

        [Theory]
        [InlineData(new int[]{}, 0)]
        [InlineData(new int[]{1}, 0)]
        [InlineData(new int[]{1, 1}, 1)]
        [InlineData(new int[]{1, 2}, 1)]
        [InlineData(new int[]{3, 2, 3}, 6)]
        public void should_return_max_area(int[] height, int maxArea)
        {
            solution.MaxArea(height).ShouldBe(maxArea);
        }
    }
}