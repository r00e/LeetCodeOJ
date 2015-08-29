namespace leetCode._081_SearchInRotatedSortedArrayIISolution
{
    public class SearchInRotatedSortedArrayIISolution
    {
        public bool Search(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1, realStart = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i - 1] > nums[i]) realStart = i;
            }

            end = nums.Length - 1;
            while(start <= end)
            {
                var mid = (start + end)/2;
                var realMid = (realStart + mid)%nums.Length;
                if (target == nums[realMid]) return true;
                if (target > nums[realMid]) start = mid + 1;
                else end = mid - 1;
            }
            
            return false;
        }
    }
}