namespace leetCode._063_UniquePathsIISolution
{
    public class UniquePathsIISolution
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int rows = obstacleGrid.GetLength(0), columns = obstacleGrid.GetLength(1);

            if (rows == 0 || columns == 0) return 0;

            var possibilities = new int[rows, columns];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    if (obstacleGrid[i, j] == 0)
                    {
                        if (i == 0)
                        {
                            possibilities[i, j] = j == 0
                                ? 1
                                : possibilities[i, j - 1] == 0 ? 0 : obstacleGrid[i, j] == 0 ? 1 : 0;
                        }
                        else if (j == 0)
                        {
                            possibilities[i, j] = i == 0
                                ? 1
                                : possibilities[i - 1, j] == 0 ? 0 : obstacleGrid[i, j] == 0 ? 1 : 0;
                        }
                        else
                        {
                            possibilities[i, j] = possibilities[i - 1, j] + possibilities[i, j - 1];
                        }
                    }
                }                
            }

            return possibilities[rows - 1, columns - 1];
        }
    }
}