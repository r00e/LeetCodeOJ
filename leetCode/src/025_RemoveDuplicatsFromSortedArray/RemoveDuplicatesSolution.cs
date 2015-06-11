namespace leetCode._025_RemoveDuplicatsFromSortedArray
{
    public class RemoveDuplicatesSolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var tmp = 0;
            var index = 1;

            while (index < nums.Length)
            {
                if(nums[tmp] != nums[index])
                {
                    nums[++tmp] = nums[index];
                }

                index++;
            }

            return tmp + 1;
        }
    }
}