using leetCode._062_UniquePathSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class UniquePathsFacts
    {
        private readonly UniquePathsSolution solution = new UniquePathsSolution();

        [Theory]
        [InlineData(0,0,0)]
        [InlineData(0,1,0)]
        [InlineData(0,0,1)]
        [InlineData(1,1,1)]
        [InlineData(1,2,1)]
        [InlineData(1,1,2)]
        [InlineData(2,2,2)]
        [InlineData(3,2,3)]
        [InlineData(3,3,2)]
        public void should_return_all_unique_paths(int possibilties, int m, int n)
        {
            solution.UniquePaths(m, n).ShouldBe(possibilties);
        }
    }
}