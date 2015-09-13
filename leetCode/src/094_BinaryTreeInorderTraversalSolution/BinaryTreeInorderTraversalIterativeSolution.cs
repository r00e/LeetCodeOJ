using System.Collections.Generic;
using System.Linq;
using leetCode.Common;

namespace leetCode._094_BinaryTreeInorderTraversalSolution
{
    public class BinaryTreeInorderTraversalIterativeSolution
    {
        private List<int> result = new List<int>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;

            var stack = new Stack<TreeNode>();

            while (root != null || stack.Count != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();
                result.Add(root.val);
                root = root.right;
            }

            return result;
        }
    }
}