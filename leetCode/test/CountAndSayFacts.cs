using leetCode._038_CountAndSaySolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class CountAndSayFacts
    {
        private readonly CountAndSaySolution solution = new CountAndSaySolution();

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "11")]
        [InlineData(3, "21")]
        [InlineData(4, "1211")]
        [InlineData(5, "111221")]
        public void should_return_integer(int num, string expectedValue)
        {
            solution.CountAndSay(num).ShouldBe(expectedValue);
        }
    }
}
