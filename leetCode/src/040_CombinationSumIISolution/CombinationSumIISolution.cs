using System.Collections.Generic;
using System.Linq;

namespace leetCode._040_CombinationSumIISolution
{
    public class CombinationSumIISolution
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            candidates = candidates.OrderBy(num => num).ToArray();

            var result = new List<IList<int>>();

            for (var i = candidates.Length - 1; i >= 0; i--)
            {
                if (i < candidates.Length - 1 && candidates[i] == candidates[i + 1]) continue;
                if (candidates[i] > target) continue;
                if (candidates[i] == target) result.Add(new List<int> {candidates[i]});
                if (candidates[i] < target)
                {
                    var solution = CombinationSum2(candidates.Where((val, idx) => idx < i).ToArray(), target - candidates[i]).ToList();
                    solution.ForEach(s => s.Add(candidates[i]));
                    solution.ForEach(result.Add);
                }
            }

            return result;
        }
    }
}