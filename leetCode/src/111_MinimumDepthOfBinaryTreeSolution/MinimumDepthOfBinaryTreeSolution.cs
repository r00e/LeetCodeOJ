using System;
using leetCode.Common;

namespace leetCode._111_MinimumDepthOfBinaryTreeSolution
{
    public class MinimumDepthOfBinaryTreeSolution
    {
        public int MinDepth(TreeNode root)
        {
            if(root == null) return 0;

            var leftLen = MinDepth(root.left);
            var rightLen = MinDepth(root.right);

            if (leftLen == 0) return 1 + rightLen;
            if (rightLen == 0) return 1 + leftLen;
            return 1 + Math.Min(leftLen, rightLen);
        }
    }
}