using System.Collections.Generic;

namespace leetCode._118_PascalTriangleSolution
{
    public class PascalTriangleSolution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();

            for (var i = 0; i < numRows; i++)
            {
                result.Add(new int[i + 1]);
                result[i][0] = 1;
                result[i][i] = 1;
                for (var j = 1; j < i; j++)
                {
                    result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
                }
            }

            return result;
        }
    }
}