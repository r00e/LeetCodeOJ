using leetCode.Common;

namespace leetCode._235_LowestBinaryCommonAncestorOfBinarySearchTreeSolution
{
    public class LowestCommonAncestorOfBinarySearchTreeSolution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val < root.val && q.val < root.val) return LowestCommonAncestor(root.left, p, q);
            if (p.val > root.val && q.val > root.val) return LowestCommonAncestor(root.right, p, q);
            if (p.val == root.val) return p;
            if (q.val == root.val) return q;
            return root;
        }
    }
}