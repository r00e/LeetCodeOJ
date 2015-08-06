namespace leetCode._034_SearchForARangeSolution
{
    public class SearchForARangeSolution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var result = new int[]{-1, -1};
            if (nums.Length < 1) return result;

            var middle = nums.Length/2;
            var low = 0;
            var high = nums.Length - 1;

            while (middle >= low && middle <= high && nums[middle] != target)
            {
                if (target > nums[middle])
                {
                    low = middle + 1;
                    middle = (middle + 1 + high) / 2;
                }
                if (target < nums[middle])
                {
                    high = middle - 1;
                    middle = (low + middle - 1) / 2;
                }
                if(low == middle && middle == high) break;
            }

            if (nums[middle] == target)
            {
                var rangeStart = middle;
                var rangeEnd = middle;
                while (rangeEnd + 1 <= nums.Length - 1 && nums[rangeEnd + 1] == target) rangeEnd++;
                while (rangeStart - 1 >= 0 && nums[rangeStart - 1] == target) rangeStart--;
                result[0] = rangeStart;
                result[1] = rangeEnd;
            }

            return result;
        }
    }
}