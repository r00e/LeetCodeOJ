using leetCode.Common;

namespace leetCode._031_NextPermutationSolution
{
    public class NextPermutationSolution
    {
        public void NextPermutation(int[] nums)
        {
            if (nums.Length < 2) return;

            var latter = nums.Length - 1;
            var former = nums.Length - 2;
            for (; former >= 0; former--)
            {
                if (nums[former] < nums[former + 1]) break;
            }

            if (former >= 0)
            {
                while (nums[latter] <= nums[former]) latter--;
                CommonMethod.Swap(ref nums[latter], ref nums[former]);
            }

            CommonMethod.Reverse(nums, former + 1, nums.Length - 1);
        }
    }
}