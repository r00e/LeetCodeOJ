using System.Linq;
using leetCode.Common;
using leetCode._060_PermutationSequenceSolution;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class PermutationSequenceFacts
    {
        private readonly PermutationSequenceSolution solution = new PermutationSequenceSolution();

        [Theory]
        [InlineData(0, 0, "")]
        [InlineData(1, 0, "")]
        [InlineData(1, 1, "1")]
        [InlineData(2, 0, "")]
        [InlineData(2, 1, "12")]
        [InlineData(2, 2, "21")]
        [InlineData(3, 1, "123")]
        [InlineData(3, 2, "132")]
        [InlineData(3, 5, "312")]
        public void should_return_permutation_for_input(int n, int k, string expectedString)
        {
            solution.GetPermutation(n, k).ShouldBe(expectedString);
        }
    }
}