using System.Collections.Generic;

namespace leetCode._089_GrayCodeSolution
{
    public class GrayCodeSolution
    {
        public IList<int> GrayCode(int n)
        {
            var result = new List<int>(){0};
            var count = n;

            while (--count >= 0)
            {
                var length = result.Count;
                for (var i = length - 1; i >= 0; i--)
                {
                    result.Add(result[i] + (1 << (n - count - 1)));
                }
            }

            return result;
        }
    }
}