using leetCode.Common;
using leetCode._104_MaximumDepthOfBinaryTreeSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class MaximumDepthOfBinaryTreeFacts
    {
        private readonly MaximumDepthOfBinaryTreeSolution solution = new MaximumDepthOfBinaryTreeSolution();

        [Fact]
        public void should_return_empty_when_tree_is_null()
        {
            solution.MaxDepth(null).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_tree_is_0()
        {
            var tree = new TreeNode(0);
            solution.MaxDepth(tree).ShouldBe(1);
        }

        [Fact]
        public void should_return_2_when_tree_is_01()
        {
            var tree = new TreeNode(0){left = new TreeNode(1)};
            solution.MaxDepth(tree).ShouldBe(2);
        }

        [Fact]
        public void should_return_2_when_tree_is_0_1()
        {
            var tree = new TreeNode(0){right = new TreeNode(1)};
            solution.MaxDepth(tree).ShouldBe(2);
        }

        [Fact]
        public void should_return_3_when_tree_is_0_1_2()
        {
            var tree = new TreeNode(0)
            {
                right = new TreeNode(1) { right = new TreeNode(2)}
            };
            solution.MaxDepth(tree).ShouldBe(3);
        }
    }
}
