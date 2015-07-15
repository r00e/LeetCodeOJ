using System.Collections.Generic;

namespace leetCode._219_ContainsDuplicateIISolution
{
    public class ContainsDuplicateIISolution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if(nums == null) return false;

            var duplicateNumAndIndicesMapping = new Dictionary<int, IList<int>>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (duplicateNumAndIndicesMapping.ContainsKey(nums[i]))
                {
                    duplicateNumAndIndicesMapping[nums[i]].Add(i);
                }
                else
                {
                    duplicateNumAndIndicesMapping.Add(nums[i], new List<int>() {i});
                }
            }

            foreach (var mapping in duplicateNumAndIndicesMapping)
            {
                if (mapping.Value.Count < 2) continue;
                else
                {
                    for (var i = 1; i < mapping.Value.Count; i++)
                    {
                        if (mapping.Value[i] - mapping.Value[i - 1] <= k) return true;
                    }
                }
            }

            return false;
        }
    }
}