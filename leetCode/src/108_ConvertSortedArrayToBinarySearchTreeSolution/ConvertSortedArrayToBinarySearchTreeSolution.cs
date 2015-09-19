using leetCode.Common;

namespace leetCode._108_ConvertSortedArrayToBinarySearchTreeSolution
{
    public class ConvertSortedArrayToBinarySearchTreeSolution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if(nums.Length == 0) return null;

            return Helper(nums, 0, nums.Length - 1);
        }

        private TreeNode Helper(int[] nums, int startIndex, int endIndex)
        {
            if (startIndex > endIndex) return null;

            var midIndex = (startIndex + endIndex)/2;
            var root = new TreeNode(nums[midIndex])
            {
                left = Helper(nums, startIndex, midIndex - 1),
                right = Helper(nums, midIndex + 1, endIndex)
            };

            return root;
        }
    }
}