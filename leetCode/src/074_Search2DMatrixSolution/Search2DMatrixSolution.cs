namespace leetCode._074_Search2DMatrixSolution
{
    public class Search2DMatrixSolution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if(matrix.Length < 1) return false;

            int m = matrix.GetLength(0), n = matrix.GetLength(1);
            int topLeft = 0, bottomRight = matrix.Length - 1;

            while (topLeft <= bottomRight)
            {
                var mid = (topLeft + bottomRight) / 2;
                var x = mid/n;
                var y = mid%n;

                if (target == matrix[x, y]) return true;
                if (target < matrix[x, y]) bottomRight = mid - 1;
                else topLeft = mid + 1;
            }

            return false;
        }
    }
}