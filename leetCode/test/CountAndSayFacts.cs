using System.Collections.Generic;
using leetCode._036_ValidSudokuSolution;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class CountAndSayFacts
    {
        private readonly CountAndSaySolution solution = new CountAndSaySolution();

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void should_return_integer(int num, string expectedValue)
        {
            solution.CountAndSay(num).ShouldBe(expectedValue);
        }
    }

    internal class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            var dict = new Dictionary<int, string>
            {
                {1, "1"}, {2, "2"}, {3, "3"}, {4, "4"}, {5, "5"},
                {6, "6"}, {7, "7"}, {8, "8"}, {9, "9"}, {0, "0"}
            };
            return dict[n];
        }
    }
}
