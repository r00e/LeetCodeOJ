using leetCode._091_DecodeWaySolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class DecodeWaysFacts
    {
        readonly DecodeWaysSolution solution = new DecodeWaysSolution();

        [Theory]
        [InlineData("", 0)]
        [InlineData("0", 0)]
        [InlineData("01", 0)]
        [InlineData("1", 1)]
        [InlineData("9", 1)]
        [InlineData("10", 1)]
        [InlineData("30", 0)]
        [InlineData("130", 0)]
        [InlineData("1234", 3)]
        [InlineData("1224", 5)]
        public void should_return_decode_ways_for_input_string(string input, int decodeWays)
        {
            solution.NumDecodings(input).ShouldBe(decodeWays);
        }
    }
}