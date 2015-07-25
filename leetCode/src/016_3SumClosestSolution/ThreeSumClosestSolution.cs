using System;
using System.Linq;

namespace leetCode._016_3SumClosestSolution
{
    public class ThreeSumClosestSolution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var sortedNums = nums.OrderBy(num => num).ToList();
            var closestSum = sortedNums.Take(3).Sum();

            for (var i = 0; i < sortedNums.Count - 2; i++)
            {
                var start = i + 1;
                var end = sortedNums.Count - 1;
                while (start < end)
                {
                    var newSum = sortedNums[i] + sortedNums[start] + sortedNums[end];
                    if (newSum > target) end--;
                    else start++;
                    if (Math.Abs(newSum - target) < Math.Abs(closestSum - target)) closestSum = newSum;
                }
            }

            return closestSum;
        }
    }
}