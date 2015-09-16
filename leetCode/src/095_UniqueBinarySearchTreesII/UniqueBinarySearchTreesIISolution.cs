using System.Collections.Generic;
using leetCode.Common;

namespace leetCode._095_UniqueBinarySearchTreesII
{
    public class UniqueBinarySearchTreesIISolution
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            var result = new List<TreeNode>[n + 1];
            result[0] = new List<TreeNode> {null};

            for (var len = 1; len <= n; len++)
            {
                result[len] = new List<TreeNode>();
                for (var i = 0; i < len; i++)
                {
                    foreach (var left in result[i])
                    {
                        foreach (var right in result[len - 1 - i])
                        {
                            var tree = new TreeNode(i + 1)
                            {
                                left = GenerateChild(left, 0),
                                right = GenerateChild(right, i + 1)
                            };
                            result[len].Add(tree);
                        }
                    }
                }
            }

            return result[n];
        }

        private TreeNode GenerateChild(TreeNode tree, int i)
        {
            if (tree == null) return null;
            
            var node = new TreeNode(tree.val + i)
            {
                left = GenerateChild(tree.left, i),
                right = GenerateChild(tree.right, i)
            };

            return node;
        }
    }
}