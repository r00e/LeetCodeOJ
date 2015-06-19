using leetCode._067_AddBinarySolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class AddBinaryFacts
    {
        private readonly AddBinarySolution solution = new AddBinarySolution();
        private readonly AddBinarySolution solution2 = new AddBinarySolution();

        [Theory]
        [InlineData("0", "0", "0")]
        [InlineData("0", "1", "1")]
        [InlineData("1", "0", "1")]
        [InlineData("1", "1", "10")]
        [InlineData("10", "0", "10")]
        [InlineData("11", "1", "100")]
        public void should_return_sum_of_binary_strings(string a, string b, string sum)
        {
            solution.AddBinary(a, b).ShouldBe(sum);
            solution2.AddBinary(a, b).ShouldBe(sum);
        }
    }
}
