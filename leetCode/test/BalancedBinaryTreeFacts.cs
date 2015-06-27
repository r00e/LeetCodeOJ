using leetCode.Common;
using leetCode._110_BalancedBinaryTreeSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class BalancedBinaryTreeFacts
    {
        private readonly BalancedBinaryTreeSolution solution = new BalancedBinaryTreeSolution();

        [Fact]
        public void should_return_true_when_tree_is_null()
        {
            solution.IsBalanced(null).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_tree_is_0()
        {
            var tree = new TreeNode(0);

            solution.IsBalanced(tree).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_tree_is_01()
        {
            var tree = new TreeNode(0){left = new TreeNode(1)};

            solution.IsBalanced(tree).ShouldBeTrue();
        }

        [Fact]
        public void should_return_false_when_tree_is_01_2()
        {
            var tree = new TreeNode(0)
            {
                left = new TreeNode(1) { left = new TreeNode(2)}
            };

            solution.IsBalanced(tree).ShouldBeFalse();
        }

        [Fact]
        public void should_return_false_when_tree_is_0123_4_5()
        {
            var tree = new TreeNode(0)
            {
                left = new TreeNode(1)
                {
                    left = new TreeNode(3) { left = new TreeNode(5)}
                },
                right = new TreeNode(2) { left = new TreeNode(4)}
            };

            solution.IsBalanced(tree).ShouldBeFalse();
        }
    }
}
