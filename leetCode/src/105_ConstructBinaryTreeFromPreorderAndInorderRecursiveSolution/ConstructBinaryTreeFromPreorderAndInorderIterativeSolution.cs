using System.Collections.Generic;
using leetCode.Common;

namespace leetCode._105_ConstructBinaryTreeFromPreorderAndInorderRecursiveSolution
{
    public class ConstructBinaryTreeFromPreorderAndInorderIterativeSolution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 && inorder.Length == 0) return null;

            if (preorder.Length == inorder.Length)
            {
                var root = new TreeNode(preorder[0]);
                var stack = new Stack<TreeNode>();
                stack.Push(root);

                TreeNode node = null;
                int preorderIndex = 1, inorderIndex = 0;

                while (inorderIndex < inorder.Length)
                {
                    if (stack.Count > 0 && stack.Peek().val == inorder[inorderIndex])
                    {
                        node = stack.Pop();
                        inorderIndex++;
                    }
                    else if (node != null)
                    {
                        var newNode = new TreeNode(preorder[preorderIndex]);
                        node.right = newNode;
                        stack.Push(newNode);
                        preorderIndex++;
                        node = null;
                    }
                    else
                    {
                        var newNode = new TreeNode(preorder[preorderIndex]);
                        stack.Peek().left = newNode;
                        stack.Push(newNode);
                        preorderIndex++;
                    }
                }

                return root;
            }

            return null;
        }
    }
}