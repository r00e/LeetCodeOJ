using System.Collections.Generic;
using System.Linq;

namespace leetCode._078_SubsetsSolution
{
    public class SubsetsIterativeSolution
    {
        public IList<IList<int>> Combine(int[] nums)
        {
            if(nums.Length == 0)return new List<IList<int>>();

            var combineResults = new List<IList<int>> {new List<int>()};

            foreach (int num in nums)
            {
                var count = combineResults.Count;
                for (var j = 0; j < count; j++)
                {
                    var tmp = new List<int>();
                    combineResults[j].ToList().ForEach(tmp.Add);
                    tmp.Add(num);
                    combineResults.Add(tmp.OrderBy(n => n).ToList());
                }
            }

            return combineResults;
        }
    }
}