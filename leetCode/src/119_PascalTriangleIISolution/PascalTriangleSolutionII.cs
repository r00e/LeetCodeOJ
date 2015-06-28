using System.Collections.Generic;

namespace leetCode._119_PascalTriangleIISolution
{
    public class PascalTriangleSolutionII
    {
        public IList<int> GetRow(int rowIndex)
        {
            var length = rowIndex + 1;
            var result = new int[length];

            for (var i = 0; i < length; i++)
            {
                result[i] = 1;

                for (var j = i - 1; j >= 1; j--)
                {
                    result[j] = result[j - 1] + result[j];
                }
            }

            return result;
        }
    }
}