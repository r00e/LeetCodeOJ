using System.Linq;
using leetCode.Common;

namespace leetCode._105_ConstructBinaryTreeFromPreorderAndInorderRecursiveSolution
{
    public class ConstructBinaryTreeFromPreorderAndInorderRecursiveSolution
    {
        // memory limit exceeded on leetcodeOJ...
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            var root = new TreeNode(0);

            if (preorder.Length == 0 && inorder.Length == 0) return null;
            if (preorder.Length == inorder.Length)
            {
                root.val = preorder[0];

                var index = inorder.ToList().IndexOf(preorder[0]);

                root.left = BuildTree(preorder.Skip(1).Take(index).ToArray(), inorder.Take(index).ToArray());
                root.right = BuildTree(preorder.Skip(1 + index).ToArray(), inorder.Skip(1 + index).ToArray());

                return root;
            }
            return null;
        }
    }
}