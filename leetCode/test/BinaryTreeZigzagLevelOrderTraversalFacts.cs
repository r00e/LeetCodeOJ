using System.Collections.Generic;
using leetCode.Common;
using leetCode._103_BinaryTreeZigzagLevelOrderTraversalSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class BinaryTreeZigzagLevelOrderTraversalFacts
    {
        private readonly BinaryTreeZigzagLevelOrderTraversalSolution solution =
            new BinaryTreeZigzagLevelOrderTraversalSolution();

        [Fact]
        public void should_return_empty_for_null()
        {
            solution.ZigzagLevelOrder(null).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_result_for_1()
        {
            solution.ZigzagLevelOrder(new TreeNode(1)).ShouldBe(new List<IList<int>> {new List<int> {1}});
        }

        [Fact]
        public void should_return_result_for_12()
        {
            solution.ZigzagLevelOrder(new TreeNode(1)
            {
                left = new TreeNode(2)
            }).ShouldBe(new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {2}
            });
        }

        [Fact]
        public void should_return_result_for_123()
        {
            solution.ZigzagLevelOrder(new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            }).ShouldBe(new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {3, 2}
            });
        }
    }
}