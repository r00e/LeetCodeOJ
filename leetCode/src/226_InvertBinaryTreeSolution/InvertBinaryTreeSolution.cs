using leetCode.Common;

namespace leetCode._226_InvertBinaryTreeSolution
{
    public class InvertBinaryTreeSolution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if(root == null) return null;

            var tmp = root.left;
            root.left = root.right;
            root.right = tmp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}