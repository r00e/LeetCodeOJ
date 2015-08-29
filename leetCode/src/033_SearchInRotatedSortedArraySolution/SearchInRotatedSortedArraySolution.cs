namespace leetCode._033_SearchInRotatedSortedArraySolution
{
    public class SearchInRotatedSortedArraySolution
    {
        public int Search(int[] nums, int target)
        {
            int realStart = 0, end = nums.Length - 1, start = 0;

            while (realStart < end)
            {
                var mid = (realStart + end)/2;
                if (nums[mid] > nums[end]) realStart = mid + 1;
                else end = mid;
            }

            end = nums.Length - 1;

            while (start <= end)
            {
                var mid = (start + end)/2;
                var realMid = (realStart + mid)%nums.Length;
                if (target == nums[realMid]) return realMid;
                if (target > nums[realMid]) start = mid + 1;
                else end = mid - 1;
            }

            return -1;
        }
    }
}