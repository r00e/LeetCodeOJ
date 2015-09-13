using System.Collections.Generic;
using System.Linq;
using leetCode.Common;

namespace leetCode._094_BinaryTreeInorderTraversalSolution
{
    public class BinaryTreeInorderTraversalRecursiveSolution
    {
        private List<int> result = new List<int>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            var inOrderResult = new List<int>();
            if (root == null) return inOrderResult;

            InorderTraversal(root.left).ToList().ForEach(inOrderResult.Add);
            inOrderResult.Add(root.val);
            InorderTraversal(root.right).ToList().ForEach(inOrderResult.Add);

            result = inOrderResult;
            return result;
        }
    }
}