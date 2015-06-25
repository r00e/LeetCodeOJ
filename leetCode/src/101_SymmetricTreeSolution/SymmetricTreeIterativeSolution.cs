using System.Collections.Generic;
using leetCode.Common;

namespace leetCode._101_SymmetricTreeSolution
{
    // Iterative method
    public class SymmetricTreeIterativeSolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if(root == null) return true;

            if(root.left == null && root.right == null) return true;
            if(root.left == null || root.right == null) return false;

            var stack = new Stack<TreeNode>();
            stack.Push(root.left);
            stack.Push(root.right);
            while (stack.Count != 0)
            {
                var right = stack.Pop();
                var left = stack.Pop();

                if (left.val != right.val) return false;
                
                if (left.left != null && right.right != null)
                {
                    stack.Push(left.left);
                    stack.Push(right.right);
                }
                else if((left.left == null && right.right != null) || 
                    (left.left != null && right.right == null))
                {
                     return false;
                }

                if (left.right != null && right.left != null)
                {
                    stack.Push(left.right);
                    stack.Push(right.left);
                }
                else if((left.right == null && right.left != null) || 
                    (left.right != null && right.left == null))
                {
                    return false;
                }
            }

            return true;
        }
    }
}