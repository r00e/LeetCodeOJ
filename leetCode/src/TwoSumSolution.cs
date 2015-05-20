using System.Collections.Generic;

namespace leetCode
{
    public class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];

            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (dictionary.ContainsKey(diff))
                {
                    result[0] = dictionary[diff] + 1;
                    result[1] = i + 1;

                    break;
                }

                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], i);
                }
            }

            return result;
        }
    }
}
