using System.Collections;
using leetCode._012_RomanToIntSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class IntegerToRomanFacts
    {
//        private readonly IntegerToRomanSolution solution = new IntegerToRomanSolution();
        private readonly IntegerToRomanSolutionShorter solution = new IntegerToRomanSolutionShorter();

        [Theory]
        [InlineData(0, null)]
        [InlineData(4000, null)]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(19, "XIX")]
        [InlineData(3999, "MMMCMXCIX")]
        public void should_return_Roman(int input, string expectedValue)
        {
            solution.IntToRoman(input).ShouldBe(expectedValue);
        }
    }
}
