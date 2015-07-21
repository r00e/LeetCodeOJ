﻿using leetCode.Common;

namespace leetCode._235_LowestBinaryCommonAncestorOfBinarySearchTreeSolution
{
    public class LowestCommonAncestorOfBinarySearchTreeIterativeSolution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while ((root.val - p.val)*(root.val - q.val) > 0)
            {
                root = root.val > p.val ? root.left : root.right;
            }
            return root;
        }
    }
}