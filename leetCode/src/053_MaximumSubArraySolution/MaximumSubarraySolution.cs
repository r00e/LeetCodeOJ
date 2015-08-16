using System;

namespace leetCode._053_MaximumSubArraySolution
{
    public class MaximumSubarraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            if(nums.Length == 0) return 0;
            
            var maxEndingHere = nums[0];
            var max = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                maxEndingHere = Math.Max(maxEndingHere + nums[i], nums[i]);
                max = Math.Max(maxEndingHere, max);
            }
            return max;
        }
    }
}