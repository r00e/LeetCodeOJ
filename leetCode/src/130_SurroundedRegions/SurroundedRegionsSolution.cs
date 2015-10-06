namespace leetCode._130_SurroundedRegions
{
    public class SurroundedRegionsSolution
    {
        private char[,] myBoard = { };

        public void Solve(char[,] board)
        {
            myBoard = board;

            for (var column = 0; column < myBoard.GetLength(1); column++)
            {
                if (myBoard[0, column] == 'O')
                {
                    MarkAdjacentNode(0, column);
                }
                if (myBoard[myBoard.GetLength(0) - 1, column] == 'O')
                {
                    MarkAdjacentNode(myBoard.GetLength(0) - 1, column);
                }
            }

            for (var row = 0; row < myBoard.GetLength(0); row++)
            {
                if (myBoard[row, 0] == 'O')
                {
                    MarkAdjacentNode(row, 0);
                }
                if (myBoard[row, myBoard.GetLength(1) - 1] == 'O')
                {
                    MarkAdjacentNode(row, myBoard.GetLength(1) - 1);
                }
            }

            for (var i = 0; i < myBoard.GetLength(0); i++)
            {
                for (var j = 0; j < myBoard.GetLength(1); j++)
                {
                    if (myBoard[i, j] == 'O')
                    {
                        myBoard[i, j] = 'X';
                    }

                    if (myBoard[i, j] == 'C')
                    {
                        myBoard[i, j] = 'O';
                    }
                }
            }
        }

        private void MarkAdjacentNode(int row, int column)
        {
            myBoard[row, column] = 'C';

            if (!IsNodeOutOfBoard(row - 1, column) && !IsNodeOnEdge(row - 1, column) && myBoard[row - 1, column] == 'O')
            {
                MarkAdjacentNode(row - 1, column);
            }
            if (!IsNodeOutOfBoard(row + 1, column) && !IsNodeOnEdge(row + 1, column) && myBoard[row + 1, column] == 'O')
            {
                MarkAdjacentNode(row + 1, column);
            }
            if (!IsNodeOutOfBoard(row, column - 1) && !IsNodeOnEdge(row, column - 1) && myBoard[row, column - 1] == 'O')
            {
                MarkAdjacentNode(row, column - 1);
            }
            if (!IsNodeOutOfBoard(row, column + 1) && !IsNodeOnEdge(row, column + 1) && myBoard[row, column + 1] == 'O')
            {
                MarkAdjacentNode(row, column + 1);
            }
        }

        private bool IsNodeOutOfBoard(int i, int j)
        {
            return i < 0 || i >= myBoard.GetLength(0) || j < 0 || j >= myBoard.GetLength(1);
        }

        private bool IsNodeOnEdge(int i, int j)
        {
            return i == 0 || i == myBoard.GetLength(0) - 1 || j == 0 || j == myBoard.GetLength(1) - 1;
        }
    }
}