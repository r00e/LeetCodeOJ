using leetCode.Common;

namespace leetCode._075_SortColorsSolution
{
    public class SortColorsSolution
    {
        public void SortColors(int[] nums)
        {
            const int red = 0, blue = 2;
            int head = 0, tail = nums.Length - 1;

            for (var i = 0; i < nums.Length; i++)
            {
                while(nums[i] == blue && i < tail) CommonMethod.Swap(ref nums[i], ref nums[tail--]);
                while(nums[i] == red && head < i) CommonMethod.Swap(ref nums[i], ref nums[head++]);
            }
        }
    }
}