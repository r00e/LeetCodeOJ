using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace leetCode._090_SubsetsIISolution
{
    public class SubsetsIISolution
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var sortedNums = nums.OrderBy(num => num).ToList();
            var result = new List<IList<int>>{new List<int>()};
            var visited = new Collection<int>();

            for (var i = 0; i < sortedNums.Count; i++)
            {
                if (!visited.Contains(sortedNums[i]))
                {
                    visited.Add(sortedNums[i]);

                    var subset = new List<int> { sortedNums[i] };
                    GenerateSubsets(result, sortedNums, subset, i + 1);                    
                }
            }

            return result;
        }

        private void GenerateSubsets(List<IList<int>> result, List<int> nums, List<int> subset, int start)
        {
            var visited = new Collection<int>();
            result.Add(subset);

            for (var i = start; i < nums.Count; i++)
            {
                if (!visited.Contains(nums[i]))
                {
                    visited.Add(nums[i]);

                    var tmpSubset = new List<int>();
                    subset.ForEach(tmpSubset.Add);
                    tmpSubset.Add(nums[i]);
                    GenerateSubsets(result, nums, tmpSubset, i + 1);                    
                }
            }
        }
    }
}