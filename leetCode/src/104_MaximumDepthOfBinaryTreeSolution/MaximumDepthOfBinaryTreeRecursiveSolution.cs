using System;
using System.Collections.Generic;
using leetCode.Common;

namespace leetCode._104_MaximumDepthOfBinaryTreeSolution
{
    public class MaximumDepthOfBinaryTreeRecursiveSolution
    {
        public int MaxDepth(TreeNode root)
        {
            if(root == null) return 0;

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
}