using System.Collections.Generic;
using System.Linq;

namespace leetCode._073_SetMatrixZeroesSolution
{
    public class SetMatrixZeroesSolution
    {
        public void SetZeroes(int[,] matrix)
        {
            var toBeZeroRows = new HashSet<int>();
            var toBeZeroColumns = new HashSet<int>();

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        toBeZeroRows.Add(i);
                        toBeZeroColumns.Add(j);
                    }
                }
            }

            toBeZeroRows.ToList().ForEach(row =>
            {
                for (var i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[row, i] = 0;
                }
            });

            toBeZeroColumns.ToList().ForEach(column =>
            {
                for (var i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, column] = 0;
                }
            });
        }
    }
}