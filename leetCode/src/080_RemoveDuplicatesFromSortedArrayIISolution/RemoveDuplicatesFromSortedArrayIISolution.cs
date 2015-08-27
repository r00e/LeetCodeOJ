namespace leetCode._080_RemoveDuplicatesFromSortedArrayIISolution
{
    public class RemoveDuplicatesFromSortedArrayIISolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 3) return nums.Length;

            int length = 2, latter = 2;

            while (latter < nums.Length)
            {
                if(nums[length - 2] != nums[latter])
                {
                    nums[length++] = nums[latter];
                }
                latter++;
            }

            return length;
        }
    }
}