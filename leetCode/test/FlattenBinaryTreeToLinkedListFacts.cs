using leetCode.Common;
using leetCode._114_FlattenBinaryTreeToLinkedList;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class FlattenBinaryTreeToLinkedListFacts
    {
        private readonly FlattenBinaryTreeToLinkedListSolution solution = new FlattenBinaryTreeToLinkedListSolution();

        [Fact]
        public void should_return_empty_for_null()
        {
            TreeNode root = null;
            solution.Flatten(root);
            CommonMethod.VerifyTreeNodeResult(root, "[]");
        }

        [Fact]
        public void should_return_empty_for_1()
        {
            var root = new TreeNode(1);
            solution.Flatten(root);
            CommonMethod.VerifyTreeNodeResult(root, "[1]");
        }

        [Fact]
        public void should_return_empty_for_12()
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
            };
            solution.Flatten(root);
            CommonMethod.VerifyTreeNodeResult(root, "[1, #, 2]");
        }

        [Fact]
        public void should_return_empty_for_123()
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };
            solution.Flatten(root);
            CommonMethod.VerifyTreeNodeResult(root, "[1, #, 2, #, 3]");
        }
    }
}