using leetCode._066_PlusOneSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class PlusOneFacts
    {
        private readonly PlusOneSolution solution = new PlusOneSolution();

        [Theory]
        [InlineData(new int[] {0}, new int[] {1})]
        [InlineData(new int[] {9}, new int[] {1, 0})]
        [InlineData(new int[] {1, 0}, new int[] {1, 1})]
        [InlineData(new int[] {1, 9}, new int[] {2, 0})]
        [InlineData(new int[] {1, 8, 8}, new int[] {1, 8, 9})]
        [InlineData(new int[] {1, 8, 9}, new int[] {1, 9, 0})]
        [InlineData(new int[] {9, 9}, new int[] {1, 0, 0})]
        [InlineData(new int[] {9, 9, 9}, new int[] {1, 0, 0, 0})]
        public void should_return_plus_1_to_digits(int[] digits, int[] expectedValue)
        {
            solution.PlusOne(digits).ShouldBe(expectedValue);
        }
    }
}
