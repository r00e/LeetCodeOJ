using leetCode.Common;
using leetCode._112_PathSumSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class PathSumFacts
    {
        private readonly PathSumSolution solution = new PathSumSolution();

        [Fact]
        public void should_return_fasle_when_tree_is_null_with_any_sum()
        {
            solution.HasPathSum(null, 0).ShouldBeFalse();
        }

        [Fact]
        public void should_return_true_when_tree_is_0_with_sum_0()
        {
            var tree = new TreeNode(0);

            solution.HasPathSum(tree, 0).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_tree_is_0_with_sum_1()
        {
            var tree = new TreeNode(0);

            solution.HasPathSum(tree, 1).ShouldBeFalse();
        }

        [Fact]
        public void should_return_true_when_tree_is_1_with_sum_1()
        {
            var tree = new TreeNode(1);

            solution.HasPathSum(tree, 1).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_tree_is_1234_with_sum_7()
        {
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                },
                right = new TreeNode(3)
            };

            solution.HasPathSum(tree, 7).ShouldBeTrue();
        }
    }
}
