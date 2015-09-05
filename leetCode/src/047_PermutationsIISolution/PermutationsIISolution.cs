using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace leetCode._047_PermutationsIISolution
{
    public class PermutationsIISolution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var permutations = new List<IList<int>>();
            if (nums.Length == 0) return permutations;
            GeneratePermutations(nums, 0, permutations);

            return permutations;
        }

        private static void GeneratePermutations(int[] nums, int startIndex, List<IList<int>> permutations)
        {
            if (startIndex == nums.Length)
            {
                permutations.Add(nums.ToList());
                return;
            }

            var visited = new Collection<int>();
            for (var i = startIndex; i < nums.Length; i++)
            {
                if (!visited.Contains(nums[i]))
                {
                    Swap(ref nums[startIndex], ref nums[i]);
                    GeneratePermutations(nums, startIndex + 1, permutations);
                    Swap(ref nums[startIndex], ref nums[i]);
                    visited.Add(nums[i]);
                }
            }
        }
        
        private static void Swap(ref int left, ref int right)
        {
            var tmp = left;
            left = right;
            right = tmp;
        }
    }
}