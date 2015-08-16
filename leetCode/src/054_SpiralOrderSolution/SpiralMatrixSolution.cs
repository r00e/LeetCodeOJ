using System.Collections.Generic;

namespace leetCode._054_SpiralOrderSolution
{
    public class SpiralMatrixSolution
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            if(matrix.Length == 0) return new List<int>();
            
            var result = new List<int>();

            int top = 0, left = -1, bottom = matrix.GetLength(0) - 1, right = matrix.GetLength(1) - 1;
            while (result.Count < matrix.Length)
            {
                // from left to right
                for(var index = ++left; index <= right; index++) result.Add(matrix[top, index]);
                if(result.Count == matrix.Length) break;
                // from top to bottom
                for(var index = ++top; index <= bottom; index++) result.Add(matrix[index, right]);
                if (result.Count == matrix.Length) break;
                // from right to left
                for(var index = --right; index >= left; index--) result.Add(matrix[bottom, index]);
                // from bottom to top
                for (var index = --bottom; index >= top; index--) result.Add(matrix[index, left]);
            }

            return result;
        }
    }
}