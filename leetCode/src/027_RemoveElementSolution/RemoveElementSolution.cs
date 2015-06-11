namespace leetCode._027_RemoveElementSolution
{
    public class RemoveElementSolution
    {
//        public int RemoveElement(int[] nums, int val)
//        {
//            return nums.Where(num => num != val).ToArray().Length;
//        }
        public int RemoveElement(int[] nums, int val)
        {
            var len = nums.Length;

            for (var i = 0; i < nums.Length; i++)
            {
                while (nums[i] == val && i < len)
                {
                    nums[i] = nums[len - 1];
                    len--;
                }
            }

            return len;
        }
    }
}