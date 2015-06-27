using leetCode.Common;

namespace leetCode._112_PathSumSolution
{
    public class PathSumSolution
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if(root == null) return false;

            if (root.left == null && root.right == null) return root.val == sum;
            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
    }
}