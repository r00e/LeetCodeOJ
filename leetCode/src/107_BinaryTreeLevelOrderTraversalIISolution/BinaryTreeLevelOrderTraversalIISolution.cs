using System.Collections.Generic;
using System.Linq;
using leetCode.Common;

namespace leetCode._107_BinaryTreeLevelOrderTraversalIISolution
{
    public class BinaryTreeLevelOrderTraversalIISolution
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();

            var result = new List<IList<int>>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var count = queue.Count;
                for (var i = 0; i < count; i++)
                {
                    if (queue.Peek().left != null) queue.Enqueue(queue.Peek().left);
                    if (queue.Peek().right != null) queue.Enqueue(queue.Peek().right);

                    if (i == 0) result.Add(new List<int>() { queue.Dequeue().val });
                    else result.Last().Add(queue.Dequeue().val);
                }
            }

            result.Reverse();
            return result;
        }
    }
}