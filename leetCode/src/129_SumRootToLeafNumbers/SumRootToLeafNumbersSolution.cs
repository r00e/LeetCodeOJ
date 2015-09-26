using System.Collections.Generic;
using leetCode.Common;

namespace leetCode._129_SumRootToLeafNumbers
{
    public class SumRootToLeafNumbersSolution
    {
        public int SumNumbers(TreeNode root)
        {
            if (root == null) return 0;
            var allLeavesSum = 0;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                var node = stack.Pop();

                if (node.left != null)
                {
                    node.left.val += node.val*10;
                    stack.Push(node.left);
                }
                if (node.right != null)
                {
                    node.right.val += node.val*10;
                    stack.Push(node.right);
                }

                allLeavesSum += IsLeafNode(node) ? node.val : 0;
            }

            return allLeavesSum;
        }

        private static bool IsLeafNode(TreeNode node)
        {
            return node.left == null && node.right == null;
        }
    }
}