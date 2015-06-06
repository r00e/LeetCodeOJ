using leetCode._08_StringToInteger;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class StringToIntegerFacts
    {
        private readonly StringToIntegerSolution solution = new StringToIntegerSolution();

        [Theory]
        [InlineData("1", 1)]
        [InlineData("     ", 0)]
        [InlineData("12", 12)]
        [InlineData("+12", 12)]
        [InlineData("-12", -12)]
        [InlineData("    -12bhgt", -12)]
        [InlineData("    -12bh98gt", -12)]
        [InlineData("98574637581", int.MaxValue)]
        [InlineData("-2147483649", int.MinValue)]
        [InlineData("9223372036854775809", int.MaxValue)]
        public void should_return_reversed_integer(string str, int expectedValue)
        {
            solution.MyAtoi(str).ShouldBe(expectedValue);
        }
    }
}
