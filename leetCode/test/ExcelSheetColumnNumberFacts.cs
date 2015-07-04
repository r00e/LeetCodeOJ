using leetCode._171_ExcelSheetColumnNumberSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ExcelSheetColumnNumberFacts
    {
        private readonly ExcelSheetColumnNumberSolution solution = new ExcelSheetColumnNumberSolution();

        [Theory]
        [InlineData("A", 1)]
        [InlineData("Z", 26)]
        [InlineData("AA", 27)]
        [InlineData("AZ", 52)]
        [InlineData("BA", 53)]
        [InlineData("YZ", 676)]
        [InlineData("ZA", 677)]
        [InlineData("ZZ", 702)]
        [InlineData("AAA", 703)]
        [InlineData("ANH", 1048)]
        public void should_return_column_number_for_column_title(string title, int number)
        {
            solution.TitleToNumber(title).ShouldBe(number);
        }
    }
}