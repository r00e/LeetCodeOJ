using System.Collections.Generic;

namespace leetCode._077_CombinationsSolution
{
    public class CombinationsSolution
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            if (k == 0 || k > n) return new List<IList<int>>();

            var combineResults = new List<IList<int>>();
            var combineResult = new List<int>();

            Combine(combineResults, combineResult, n, k, 1, 0);

            return combineResults;
        }

        private void Combine(List<IList<int>> combineResults, List<int> combineResult, int totalNum, int wantGet, int start, int count)
        {
            if (count == wantGet)
            {
                var tmp = new List<int>();
                combineResult.ForEach(tmp.Add);
                combineResults.Add(tmp);
                return;
            }
            for (var i = start; i <= totalNum; i++)
            {
                combineResult.Add(i);
                Combine(combineResults, combineResult, totalNum, wantGet, i + 1, count + 1);
                combineResult.Remove(i);
            }
        }
    }
}