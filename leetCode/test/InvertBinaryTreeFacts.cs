using leetCode.Common;
using leetCode._226_InvertBinaryTreeSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class InvertBinaryTreeFacts
    {
        private readonly InvertBinaryTreeSolution solution = new InvertBinaryTreeSolution();

        [Fact]
        public void should_return_null_when_tree_is_null()
        {
            solution.InvertTree(null).ShouldBeNull();
        }

        [Fact]
        public void should_return_1_when_tree_is_1()
        {
            var tree = new TreeNode(1);

            solution.InvertTree(tree).val.ShouldBe(1);
        }

        [Fact]
        public void should_return_1_2_when_tree_is_12()
        {
            //    1        1
            //   /    to    \
            //  2            2 
            var tree = new TreeNode(1){left = new TreeNode(2)};

            var result = solution.InvertTree(tree);
            result.val.ShouldBe(1);
            result.left.ShouldBeNull();
            result.right.val.ShouldBe(2);
        }

        [Fact]
        public void should_return_1325__4_when_tree_is_1234__5()
        {
            //    1          1
            //   / \  to    / \
            //  2   3      3   2 
           //  /     \    /     \
           // 4       5  5      4
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(5)
                }
            };

            var result = solution.InvertTree(tree);
            result.val.ShouldBe(1);
            result.left.val.ShouldBe(3);
            result.right.val.ShouldBe(2);
            result.left.left.val.ShouldBe(5);
            result.left.right.ShouldBeNull();
            result.right.left.ShouldBeNull();
            result.right.right.val.ShouldBe(4);
        }
    }
}