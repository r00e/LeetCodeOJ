using leetCode._036_ValidSudokuSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class ValidSudokuFacts
    {
        private readonly ValidSudokuSolution solution = new ValidSudokuSolution();

        [Fact]
        public void should_return_integer()
        {
            var testBoard = new char[9,9]
            {
                {'.', '.', '4', '.', '.', '.', '6', '3', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'5', '.', '.', '.', '.', '.', '.', '9', '.'},
                {'.', '.', '.', '5', '6', '.', '.', '.', '.'},
                {'4', '.', '3', '.', '.', '.', '.', '.', '1'},
                {'.', '.', '.', '7', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '5', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.', '.', '.'}
            };

            solution.IsValidSudoku(testBoard).ShouldBe(false);
        }
    }
}
