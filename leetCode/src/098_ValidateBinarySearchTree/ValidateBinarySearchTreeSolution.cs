using System.Collections.Generic;
using leetCode.Common;

namespace leetCode._098_ValidateBinarySearchTree
{
    public class ValidateBinarySearchTreeSolution
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;

            var inOrderTraversalTreeResult = new List<int>();
            InOrderTraversalTree(root, inOrderTraversalTreeResult);

            for (var i = 0; i < inOrderTraversalTreeResult.Count - 1; i++)
            {
                if (inOrderTraversalTreeResult[i] >= inOrderTraversalTreeResult[i + 1]) return false;
            }

            return true;
        }

        private void InOrderTraversalTree(TreeNode treeNode, List<int> result)
        {
            if (treeNode == null) return;

            InOrderTraversalTree(treeNode.left, result);
            result.Add(treeNode.val);
            InOrderTraversalTree(treeNode.right, result);
        }
    }
}