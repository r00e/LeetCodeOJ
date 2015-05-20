using System.Collections.Generic;

namespace leetCode
{
    public class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            int[] result = new int[2];

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
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
