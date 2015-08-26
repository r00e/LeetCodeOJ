using System.Collections.Generic;
using System.Linq;

namespace leetCode._078_SubsetsSolution
{
    public class SubsetsRecursiveSolution
    {
        public IList<IList<int>> Combine(int[] nums)
        {
            if(nums.Length == 0)return new List<IList<int>>();

            var combineResults = new List<IList<int>>();
            var combineResult = new List<int>();

            for (var wantGet = 0; wantGet <= nums.Length; wantGet++)
            {
                Combine(combineResults, combineResult, nums, wantGet, 0, 0);
            }

            return combineResults;
        }

        private void Combine(List<IList<int>> combineResults, List<int> combineResult, int[] nums,
            int wantGet, int start, int count)
        {
            if (wantGet == count)
            {
                var tmp = new List<int>();
                combineResult.ForEach(tmp.Add);
                combineResults.Add(tmp.OrderBy(n => n).ToList());
                return;
            }

            for (var i = start; i < nums.Length; i++)
            {
                combineResult.Add(nums[i]);
                Combine(combineResults, combineResult, nums, wantGet, i + 1, count + 1);
                combineResult.Remove(nums[i]);
            }
        }
    }
}