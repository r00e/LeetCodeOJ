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

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (toBeZeroRows.Contains(i) || toBeZeroColumns.Contains(j)) matrix[i, j] = 0;
                }
            }
        }
    }
}