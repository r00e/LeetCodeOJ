namespace leetCode._036_ValidSudokuSolution
{
    public class ValidSudokuSolution
    {
        public bool IsValidSudoku(char[,] board)
        {
            for (var i = 0; i <= board.GetUpperBound(0); i++)
            {
                for (var j = 0; j <= board.GetUpperBound(1); j++)
                {
                    if(board[i, j] == '.') continue;

                    if(!ValidateNum(board[i, j], i, j, board)) return false;
                }
            }

            return true;
        }

        private bool ValidateNum(char c, int x, int y, char[,] board)
        {
            // validate the column
            for (var i = 0; i <= board.GetUpperBound(0); i++)
            {
                if(board[i, y] == c && i != x) return false;
            }

            // validate the row
            for (var j = 0; j <= board.GetUpperBound(1); j++)
            {
                if(board[x, j] == c && j != y) return false;
            }

            // validate the block
            for (var xIndex = x/3*3; xIndex < x/3*3 + 3; xIndex++)
            {
                for (var yIndex = y/3*3; yIndex < y/3*3 + 3; yIndex++)
                {
                    if (board[xIndex, yIndex] == c && (xIndex != x || yIndex != y)) return false;
                }
            }

            return true;
        }
    }
}