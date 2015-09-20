using System.Collections.Generic;
using System.Linq;
using leetCode.Common;

namespace leetCode._113_PathSumII
{
    public class PathSumIISolution
    {
        readonly List<IList<int>> results = new List<IList<int>>();

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            if (root == null) return results;

            var result = new List<int>();
            Helper(root, result);

            return results.Where(r => r.Sum() == sum).ToList();
        }

        private void Helper(TreeNode root, List<int> result)
        {
            if (root == null) return;

            var resultCopy = new List<int>();
            result.ForEach(resultCopy.Add);

            if (root.left == null && root.right == null)
            {
                resultCopy.Add(root.val);
                results.Add(resultCopy);
            }
            else
            {
                resultCopy.Add(root.val);
                Helper(root.left, resultCopy);
                Helper(root.right, resultCopy);
            }
        }
    }
}