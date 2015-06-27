using leetCode.Common;
using leetCode._111_MinimumDepthOfBinaryTreeSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class MinimumDepthOfBinaryTreeFacts
    {
        private readonly MinimumDepthOfBinaryTreeSolution solution = new MinimumDepthOfBinaryTreeSolution();

        [Fact]
        public void should_return_0_when_tree_is_null()
        {
            solution.MinDepth(null).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_tree_is_0()
        {
            var tree = new TreeNode(0);

            solution.MinDepth(tree).ShouldBe(1);
        }

        [Fact]
        public void should_return_2_when_tree_is_01()
        {
            var tree = new TreeNode(0) {left = new TreeNode(1)};

            solution.MinDepth(tree).ShouldBe(2);
        }

        [Fact]
        public void should_return_2_when_tree_is_012()
        {
            var tree = new TreeNode(0)
            {
                left = new TreeNode(1), 
                right = new TreeNode(2)
            };

            solution.MinDepth(tree).ShouldBe(2);
        }

        [Fact]
        public void should_return_3_when_tree_is_0123()
        {
            var tree = new TreeNode(0)
            {
                left = new TreeNode(1){left = new TreeNode(3)}, 
                right = new TreeNode(2)
            };

            solution.MinDepth(tree).ShouldBe(2);
        }

        [Fact]
        public void should_return_3_when_tree_is_012345_6____7()
        {
            var tree = new TreeNode(0)
            {
                left = new TreeNode(1)
                {
                    left = new TreeNode(3)
                    {
                        left = new TreeNode(6)
                    },
                    right = new TreeNode(4)
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(5)
                    {
                        right = new TreeNode(7)
                    }
                }
            };

            solution.MinDepth(tree).ShouldBe(3);
        }
    }
}
