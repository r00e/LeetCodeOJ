using System;
using leetCode.Common;

namespace leetCode._110_BalancedBinaryTreeSolution
{
    public class BalancedBinaryTreeSolution
    {
        public bool IsBalanced(TreeNode root)
        {
            if(root == null) return true;

            var leftLen = GetLength(root.left);
            var rightLen = GetLength(root.right);

            if(Math.Abs(leftLen - rightLen) > 1) return false;

            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        private int GetLength(TreeNode tree)
        {
            if (tree == null) return 0;

            return 1 + Math.Max(GetLength(tree.left), GetLength(tree.right));
        }
    }
}