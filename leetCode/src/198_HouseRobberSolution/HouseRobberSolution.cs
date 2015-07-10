using System;

namespace leetCode._198_HouseRobberSolution
{
    public class HouseRobberSolution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var result = new int[nums.Length, 2];

            result[0, 0] = 0;
            result[0, 1] = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                result[i, 0] = Math.Max(result[i - 1, 1], result[i - 1, 0]);
                result[i, 1] = result[i - 1, 0] + nums[i];
            }

            return Math.Max(result[nums.Length - 1, 0], result[nums.Length - 1, 1]);
        }
    }
}