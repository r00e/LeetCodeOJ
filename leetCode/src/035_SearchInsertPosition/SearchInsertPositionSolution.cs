using System.Linq;

namespace leetCode._035_SearchInsertPosition
{
    public class SearchInsertPositionSolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if(nums.Length < 1) return 0;

            if (target <= nums.First()) return 0;

            if(target > nums.Last()) return nums.Length;

            var low = 0;
            var high = nums.Length - 1;
            while (low < high)
            {
                var middle = (low + high)/2;
                if (nums[middle] < target) low = middle + 1;
                else high = middle;
            }
            
            return low;
        }
    }
}