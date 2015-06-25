using leetCode.Common;
using leetCode._102_BinaryTreeLevelOrderTraversalSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class BinaryTreeLevelOrderTraversalFacts
    {
        private readonly BinaryTreeLevelOrderTraversalSolution solution = new BinaryTreeLevelOrderTraversalSolution();

        [Fact]
        public void should_return_empty_when_tree_is_null()
        {
            solution.LevelOrder(null).Count.ShouldBe(0);
        }

        [Fact]
        public void should_return_0_when_tree_is_0()
        {
            var tree = new TreeNode(0);

            var result = solution.LevelOrder(tree);
            result.Count.ShouldBe(1);
            result[0].Count.ShouldBe(1);
            result[0][0].ShouldBe(0);
        }

        [Fact]
        public void should_return_012_when_tree_is_012()
        {
            var tree = new TreeNode(0){left = new TreeNode(1), right = new TreeNode(2)};

            var result = solution.LevelOrder(tree);
            result.Count.ShouldBe(2);
            result[0].Count.ShouldBe(1);
            result[0][0].ShouldBe(0);
            result[1].Count.ShouldBe(2);
            result[1][0].ShouldBe(1);
            result[1][1].ShouldBe(2);
        }

        [Fact]
        public void should_return_0123_when_tree_is_012__3()
        {
            var tree = new TreeNode(0)
            {
                left = new TreeNode(1), 
                right = new TreeNode(2){left = new TreeNode(3)}
            };

            var result = solution.LevelOrder(tree);
            result.Count.ShouldBe(3);
            result[0].Count.ShouldBe(1);
            result[0][0].ShouldBe(0);
            result[1].Count.ShouldBe(2);
            result[1][0].ShouldBe(1);
            result[1][1].ShouldBe(2);
            result[2].Count.ShouldBe(1);
            result[2][0].ShouldBe(3);
        }
    }
}
