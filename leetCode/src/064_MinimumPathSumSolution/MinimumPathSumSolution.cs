using System;

namespace leetCode._064_MinimumPathSumSolution
{
    public class MinimumPathSumSolution
    {
        public int MinPathSum(int[,] grid)
        {
            if (grid.Length == 0) return 0;

            int rows = grid.GetLength(0), columns = grid.GetLength(1);
            var sums = new int[rows, columns];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    if (i == 0 && j == 0) sums[i, j] = grid[i, j];
                    else if (i == 0) sums[i, j] = grid[i, j] + sums[i, j - 1];
                    else if (j == 0) sums[i, j] = grid[i, j] + sums[i - 1, j];
                    else
                    {
                        sums[i, j] = grid[i, j] + Math.Min(sums[i - 1, j], sums[i, j - 1]);
                    }
                }
            }

            return sums[rows - 1, columns - 1];
        }
    }
}