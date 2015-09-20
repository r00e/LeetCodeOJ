using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit.Should;

namespace leetCode.Common
{
    public class CommonMethod
    {
        public static void Swap(ref int latter, ref int former)
        {
            var tmp = latter;
            latter = former;
            former = tmp;
        }

        public static void Reverse(int[] nums, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                Swap(ref nums[startIndex], ref nums[endIndex]);
                startIndex++;
                endIndex--;
            }
        }

        public static void VerifyListNodeResult(ListNode head, string expectedResult)
        {
            var actualResultString = new StringBuilder();

            while (head != null)
            {
                actualResultString.Append(head.val);
                head = head.next;
            }

            actualResultString.ToString().ShouldBe(expectedResult);
        }

        public static void VerifyListStringResult(IList<string> actualResult, string expectedResult)
        {
            var result = new StringBuilder();
            result.Append("[]");
            actualResult.ToList().ForEach(str => result.Insert(result.Length - 1, string.Format(", '{0}'", str)));
            if(result.Length > 2) result.Remove(1, 2);

            result.ToString().ShouldBe(expectedResult);
        }

        public static void VerifyIntListResult(IList<int> actualResult, string expectedResult)
        {
            var result = new StringBuilder().Append("[]");

            actualResult.ToList().ForEach(r => result.Insert(result.Length - 1, r));

            result.ToString().ShouldBe(expectedResult);
        }

        public static void VerifyTreeNodeListResult(IList<TreeNode> actualResultTree, string expectedResult)
        {
            var actualResultTreeToString = new StringBuilder();
            actualResultTreeToString.Append("[]");
            if (actualResultTree.First() == null)
            {
                actualResultTreeToString.Insert(1, "[]");
                actualResultTreeToString.ToString().ShouldBe(expectedResult);
            }
            else
            {
                actualResultTree.ToList().ForEach(tree =>
                {
                    var treeToString = new StringBuilder();

                    treeToString.Append(TraversalTreeByLayer(tree));

                    actualResultTreeToString.Insert(actualResultTreeToString.Length - 1, 
                        string.Format("{0}, ", treeToString));
                });

                actualResultTreeToString.Remove(actualResultTreeToString.Length - 3, 2);
                actualResultTreeToString.ToString().ShouldBe(expectedResult);
            }
        }

        public static void VerifyTreeNodeResult(TreeNode actualTree, string expectedTreeToString)
        {
            var actualTreeToString = TraversalTreeByLayer(actualTree);

            actualTreeToString.ShouldBe(expectedTreeToString);
        }

        private static string TraversalTreeByLayer(TreeNode tree)
        {
            var result = new StringBuilder();
            if (tree == null) return result.Append("[]").ToString();

            var queue = new Queue<TreeNode>();
            queue.Enqueue(tree);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                if (node != null)
                {
                    result.Append(string.Format(", {0}", node.val));

                    if (node.left != null || node.right != null)
                    {
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }
                }
                else
                {
                    result.Append(", #");
                }
            }

            return string.Format("[{0}]", result.Remove(0, 2));
        }
    }
}