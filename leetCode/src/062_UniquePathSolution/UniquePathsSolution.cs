using System.Linq;

namespace leetCode._062_UniquePathSolution
{
    public class UniquePathsSolution
    {
        public int UniquePaths(int m, int n)
        {
            if (m == 0 || n == 0) return 0;
            if (m == 1 || n == 1) return 1;

            var possibilities = new int[n];
            for (var i = 0; i < n; i++) possibilities[i] = 1;

            for (var i = 1; i < m; i++)
                for (var j = 1; j < n; j++)
                    possibilities[j] += possibilities[j - 1];

            return possibilities.Last();
        }
    }
}