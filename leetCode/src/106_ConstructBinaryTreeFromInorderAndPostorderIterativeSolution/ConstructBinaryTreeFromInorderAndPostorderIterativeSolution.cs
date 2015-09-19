using System.Collections.Generic;
using leetCode.Common;

namespace leetCode._106_ConstructBinaryTreeFromInorderAndPostorderIterativeSolution
{
    public class ConstructBinaryTreeFromInorderAndPostorderIterativeSolution
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if(inorder.Length == 0 && postorder.Length == 0) return null;
            if (inorder.Length == postorder.Length)
            {
                var root = new TreeNode(postorder[postorder.Length - 1]);
                var stack = new Stack<TreeNode>();
                stack.Push(root);

                int postorderIndex = postorder.Length - 2, inorderIndex = inorder.Length - 1;
                TreeNode node = null;

                while (inorderIndex >= 0)
                {
                    if (stack.Count > 0 && stack.Peek().val == inorder[inorderIndex])
                    {
                        node = stack.Pop();
                        inorderIndex--;
                    }
                    else if (node != null)
                    {
                        var newNode = new TreeNode(postorder[postorderIndex]);
                        node.left = newNode;
                        stack.Push(newNode);
                        postorderIndex--;
                        node = null;
                    }
                    else
                    {
                        var newNode = new TreeNode(postorder[postorderIndex]);
                        stack.Peek().right = newNode;
                        stack.Push(newNode);
                        postorderIndex--;
                    }
                }

                return root;
            }

            return null;
        }
    }
}