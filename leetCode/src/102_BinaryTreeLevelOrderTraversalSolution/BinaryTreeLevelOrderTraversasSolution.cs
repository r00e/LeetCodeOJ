using System.Collections.Generic;
using System.Linq;
using Xunit.Should;

namespace leetCode._102_BinaryTreeLevelOrderTraversalSolution
{
    public class BinaryTreeLevelOrderTraversasSolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null) return result;

            var tmpResult = new List<TreeNode> {root};

            while (tmpResult.Count != 0)
            {
                var tmpResultCount = tmpResult.Count;
                for (var i = 0; i < tmpResultCount; i++)
                {
                    if (i == 0) result.Add(new List<int>(){tmpResult[i].val});
                    else result.Last().Add(tmpResult[i].val);

                    if(tmpResult[i].left != null) tmpResult.Add(tmpResult[i].left);
                    if(tmpResult[i].right != null) tmpResult.Add(tmpResult[i].right);
                }
                while (tmpResultCount > 0)
                {
                    tmpResult.RemoveAt(0);
                    tmpResultCount--;
                }
            }

            return result;
        }
    }
}