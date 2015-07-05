namespace leetCode._189_RotateArraySolution
{
    public class RotateArraySolution
    {
        public void Rotate(int[] nums, int k)
        {
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, k%nums.Length, nums.Length - 1);
            Reverse(nums, 0, k%nums.Length - 1);
// O(n) space
//            var tmpArray = new int[nums.Length];
//            for (var i = 0; i < nums.Length; i++)
//            {
//                tmpArray[i] = nums[i];
//            }
//            for (int i = 0, step = k % nums.Length; step > 0; i++, step--)
//            {
//                nums[i] = tmpArray[nums.Length - step];
//            }
//            for (int i = 0, step = k % nums.Length; i < nums.Length - step; i++)
//            {
//                nums[i + step] = tmpArray[i];
//            }
        }

        private void Reverse(int[] nums, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                var tmp = nums[endIndex];
                nums[endIndex] = nums[startIndex];
                nums[startIndex] = tmp;
                startIndex++;
                endIndex--;
            }
        }
    }
}