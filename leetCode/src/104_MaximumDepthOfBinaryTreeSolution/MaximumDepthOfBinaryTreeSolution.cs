using System.Collections;
using System.Collections.Generic;
using System.Linq;
using leetCode.Common;

namespace leetCode._104_MaximumDepthOfBinaryTreeSolution
{
    public class MaximumDepthOfBinaryTreeSolution
    {
        public int MaxDepth(TreeNode root)
        {
            if(root == null) return 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var allNodesByLevel = new List<IList<int>>();

            while (queue.Count != 0)
            {
                var count = queue.Count;
                for (var i = 0; i < count; i++)
                {
                    if(queue.Peek().left != null) queue.Enqueue(queue.Peek().left);
                    if(queue.Peek().right != null) queue.Enqueue(queue.Peek().right);

                    if(i == 0) allNodesByLevel.Add(new List<int>(){queue.Dequeue().val});
                    else allNodesByLevel.Last().Add(queue.Dequeue().val);
                }
            }

            return allNodesByLevel.Count;
        }
    }
}