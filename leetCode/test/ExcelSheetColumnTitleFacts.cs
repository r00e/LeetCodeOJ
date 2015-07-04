using System.Linq;
using leetCode._168_ExcelSheetColumnTitleSolution;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ExcelSheetColumnTitleFacts
    {
        private readonly ExcelSheetColumnTitleSolution solution = new ExcelSheetColumnTitleSolution();

        [Theory]
        [InlineData(1, "A")]
        [InlineData(26, "Z")]
        [InlineData(27, "AA")]
        [InlineData(52, "AZ")]
        [InlineData(53, "BA")]
        [InlineData(676, "YZ")]
        [InlineData(677, "ZA")]
        [InlineData(702, "ZZ")]
        [InlineData(703, "AAA")]
        [InlineData(1048, "ANH")]
        public void should_return_column_title_for_column(int columnNumber, string expectedColumnTitle)
        {
            solution.ConvertToTitle(columnNumber).ShouldBe(expectedColumnTitle);
        }
    }
}