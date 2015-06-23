namespace leetCode._101_SymmetricTreeSolution
{
    // Recursive method
    public class SymmetricTreeSolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return root == null || CompareChildren(root.left, root.right);
        }

        public bool CompareChildren(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            if (left.val != right.val) return false;
                
            return CompareChildren(left.left, right.right) && CompareChildren(left.right, right.left);
        }
    }
}