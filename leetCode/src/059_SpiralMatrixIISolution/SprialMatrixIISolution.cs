namespace leetCode._059_SpiralMatrixIISolution
{
    public class SprialMatrixIISolution
    {
        public int[,] GenerateMatrix(int n)
        {
            if (n < 1) return new int[,]{};

            var result = new int[n,n];

            int left = -1, top = 0, right = n - 1, bottom = n - 1, num = 1;

            while (num <= n*n)
            {
                // from left to right
                for (var i = ++left; i <= right; i++) result[top, i] = num++;
                if(num > n*n) break;
                // from top to bottom
                for (var i = ++top; i <= bottom; i++) result[i, right] = num++;
                if (num > n*n) break;
                // from right to left
                for (var i = --right; i >= left; i--) result[bottom, i] = num++;
                // from bottom to top
                for (var i = --bottom; i >= top; i--) result[i, left] = num++;
            }

            return result;
        }
    }
}