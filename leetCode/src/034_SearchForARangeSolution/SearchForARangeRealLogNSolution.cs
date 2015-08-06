using System;

namespace leetCode._034_SearchForARangeSolution
{
    public class SearchForARangeRealLogNSolution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var result = new int[]{-1, -1};
            if (nums.Length < 1) return result;

            var low = 0;
            var high = nums.Length - 1;

            while (low < high)
            {
                var middle = (low + high) / 2;

                if (target > nums[middle]) low = middle + 1;
                else high = middle;
            }
            if (nums[low] != target) return result;
            result[0] = low;

            high = nums.Length - 1;
            while (low < high)
            {
                var middle = (low + high)/2 + 1;

                if (target < nums[middle]) high = middle - 1;
                else low = middle;
            }
            result[1] = high;

            return result;
        }
    }
}