using leetCode._070_ClimbingStairsSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ClimbingStairsFacts
    {
        private readonly ClimbingStairsSolution solution = new ClimbingStairsSolution();

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 5)]
        public void should_return_count_of_distinct_ways_to_climb_to_the_top(int n, int ways)
        {
            solution.ClimbingStairs(n).ShouldBe(ways);
        }
    }
}
