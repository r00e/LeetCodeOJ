using System.Linq;
using leetCode._055_JumpGameSolution;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class JumpGameFacts
    {
        private readonly JumpGameSolution solution = new JumpGameSolution();

        [Theory]
        [InlineData(new int[] { }, false)]
        [InlineData(new int[] {0}, true)]
        [InlineData(new int[] {1}, true)]
        [InlineData(new int[] {1, 0}, true)]
        [InlineData(new int[] {0, 0}, false)]
        [InlineData(new int[] {1, 0, 0}, false)]
        [InlineData(new int[] {1, 1, 0}, true)]
        [InlineData(new int[] {2, 2, 0, 0}, true)]
        [InlineData(new int[] {3, 2, 1, 0, 4}, false)]
        public void should_return_expectedValue_for_givenArray(int[] givenArray, bool expectedValue)
        {
            solution.CanJump(givenArray).ShouldBe(expectedValue);
        }
    }
}