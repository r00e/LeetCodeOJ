using System.Collections.Generic;
using System.Linq;

namespace leetCode._039_CombinationSumSolution
{
    public class CombinationSumSolution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();

            for (var i = candidates.Length - 1; i >= 0; i--)
            {
                if(i < candidates.Length - 1 && candidates[i] == candidates[i+1]) continue;
                if(candidates[i] > target) continue;
                if(candidates[i] == target) result.Add(new List<int> {candidates[i]});
                if(candidates[i] < target)
                {
                    var solution = CombinationSum(candidates.Where(c => c <= candidates[i]).ToArray(), target - candidates[i]).ToList();
                    solution.ForEach(s => s.Add(candidates[i]));
                    solution.ForEach(result.Add);
                }
            }

            return result;
        }
    }
}