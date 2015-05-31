using System.Runtime.InteropServices;
using leetCode._06_ZigZagConversion;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ZigZagConversionFacts
    {
        private ZigZagConversionSolution solution = new ZigZagConversionSolution();

        [Theory]
        [InlineData("P", 1, "P")]
        public void should_return_in_zigzag_pattern(string text, int nRows, string expected)
        {
            solution.Convert(text, nRows).ShouldBe(expected);
        }
    }
}
