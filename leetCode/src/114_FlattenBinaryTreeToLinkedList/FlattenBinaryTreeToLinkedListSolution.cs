using leetCode.Common;

namespace leetCode._114_FlattenBinaryTreeToLinkedList
{
    public class FlattenBinaryTreeToLinkedListSolution
    {
        public void Flatten(TreeNode root)
        {
            if (root == null) return;

            Flatten(root.left);
            Flatten(root.right);

            if (root.left == null) return;
            
            var tmpRight = root.right;
            root.right = root.left;
            var probe = root;
            while (probe.right != null)
            {
                probe = probe.right;
            }
            probe.right = tmpRight;
            root.left = null;
        }
    }
}