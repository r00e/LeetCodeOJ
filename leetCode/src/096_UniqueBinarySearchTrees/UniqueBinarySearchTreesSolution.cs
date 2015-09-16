namespace leetCode._096_UniqueBinarySearchTrees
{
    public class UniqueBinarySearchTreesSolution
    {
        public int NumTrees(int n)
        {
            if (n < 1) return 0;

            var result = new int[n+1];
            result[0] = 1;

            for (var len = 1; len <= n; len++)
            {
                for (var i = 0; i < len; i++)
                {
                    var leftCount = result[i];
                    var rightCount = result[len - 1 - i];

                    result[len] += leftCount*rightCount;
                }
            }

            return result[n];
        }
    }
}