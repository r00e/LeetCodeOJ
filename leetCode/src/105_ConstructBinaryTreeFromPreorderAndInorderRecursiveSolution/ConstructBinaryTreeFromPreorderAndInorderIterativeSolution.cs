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
                int i = 1, j = 0;

                while (j < inorder.Length)
                {
                    if (stack.Count > 0 && stack.Peek().val == inorder[j])
                    {
                        node = stack.Pop();
                        j++;
                    }
                    else if (node != null)
                    {
                        var newNode = new TreeNode(preorder[i]);
                        node.right = newNode;
                        stack.Push(newNode);
                        i++;
                        node = null;
                    }
                    else
                    {
                        var newNode = new TreeNode(preorder[i]);
                        stack.Peek().left = newNode;
                        stack.Push(newNode);
                        i++;
                    }
                }

                return root;
            }

            return null;
        }
    }
}