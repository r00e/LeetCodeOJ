using System.Runtime.InteropServices;
using leetCode._006_ZigZagConversion;
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
        [InlineData("PA", 1, "PA")]
        [InlineData("PA", 2, "PA")]
        [InlineData("PAY", 2, "PYA")]
        [InlineData("PAYP", 3, "PAPY")]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        public void should_return_in_zigzag_pattern(string text, int nRows, string expected)
        {
            solution.Convert(text, nRows).ShouldBe(expected);
        }
    }
}
