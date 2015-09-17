using System.Collections.Generic;
using leetCode.Common;

namespace leetCode._103_BinaryTreeZigzagLevelOrderTraversalSolution
{
    public class BinaryTreeZigzagLevelOrderTraversalSolution
    {
        private enum Sequence
        {
            LeftToRight,
            RightToLeft
        };

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null) return result;

            var sequence = Sequence.RightToLeft;
            var leftToRightLayer = new Stack<TreeNode>();
            leftToRightLayer.Push(root);
            var rightToLeftLayer = new Stack<TreeNode>();
        
            while (leftToRightLayer.Count != 0 || rightToLeftLayer.Count != 0)
            {
                if (sequence == Sequence.RightToLeft)
                {
                    var list = new List<int>();
                    while (leftToRightLayer.Count != 0)
                    {
                        var node = leftToRightLayer.Pop();
                        if (node != null)
                        {
                            list.Add(node.val);
                            rightToLeftLayer.Push(node.left);
                            rightToLeftLayer.Push(node.right);    
                        }
                    }
                    if (list.Count != 0) result.Add(list);
                    sequence = Sequence.LeftToRight;
                }
                if (sequence == Sequence.LeftToRight)
                {
                    var list = new List<int>();
                    while (rightToLeftLayer.Count != 0)
                    {
                        var node = rightToLeftLayer.Pop();
                        if (node != null)
                        {
                            list.Add(node.val);
                            leftToRightLayer.Push(node.right);
                            leftToRightLayer.Push(node.left);
                        }
                    }
                    if (list.Count != 0) result.Add(list);
                    sequence = Sequence.RightToLeft;
                }
            }
        
            return result;
        }
    }
}