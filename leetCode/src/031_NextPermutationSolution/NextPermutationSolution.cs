namespace leetCode._031_NextPermutationSolution
{
    public class NextPermutationSolution
    {
        public void NextPermutation(int[] nums)
        {
            if (nums.Length < 2) return;

            var latter = nums.Length - 1;
            var former = nums.Length - 2;

            for (; former >= 0; latter--, former--)
            {
                if (nums[latter] > nums[former] && latter == nums.Length - 1 && former == nums.Length - 2)
                {
                    Swap(ref nums[latter], ref nums[former]);
                    break;
                }

                if (nums[latter] > nums[former])
                {
                    latter = nums.Length - 1;
                    break;
                }
            }

            if (former < 0)
            {
                Sort(nums, 0, nums.Length - 1);
            }

            while (former >=0 && nums[latter] <= nums[former] && latter > former)
            {
                latter--;
            }

            if (former >=0 && latter != former)
            {
                Swap(ref nums[latter], ref nums[former]);
                Sort(nums, former + 1, nums.Length - 1);
            }
        }

        private void Sort(int[] nums, int startIndex, int endIndex)
        {
            if (startIndex > endIndex) return;

            var index = SortPart(nums, startIndex, endIndex);
            Sort(nums, startIndex, index - 1);
            Sort(nums, index + 1, endIndex);
        }

        private int SortPart(int[] nums, int startIndex, int endIndex)
        {
            var key = nums[startIndex];
                
            while (startIndex < endIndex)
            {
                while (nums[endIndex] >= key && startIndex < endIndex) endIndex--;
                nums[startIndex] = nums[endIndex];
                while (nums[startIndex] <= key && startIndex < endIndex) startIndex++;
                nums[endIndex] = nums[startIndex];
            }

            nums[startIndex] = key;

            return startIndex;
        }

        private static void Swap(ref int latter, ref int former)
        {
            var tmp = latter;
            latter = former;
            former = tmp;
        }
    }
}