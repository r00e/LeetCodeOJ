using System.Collections.Generic;
using leetCode.Common;
using leetCode._113_PathSumII;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class PathSumIIFacts
    {
        private readonly PathSumIISolution solution = new PathSumIISolution();

        [Fact]
        public void should_return_empty_for_null()
        {
            solution.PathSum(null, 0).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_result_for_tree_1_and_sum_0()
        {
            solution.PathSum(new TreeNode(1), 0).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_result_for_tree_1_and_sum_1()
        {
            solution.PathSum(new TreeNode(1), 1).ShouldBe(new List<IList<int>> {new List<int> {1}});
        }

        [Fact]
        public void should_return_result_for_tree_122_and_sum_3()
        {
            solution.PathSum(
                new TreeNode(1)
                {
                    left = new TreeNode(2),
                    right = new TreeNode(2)
                }, 3
            ).ShouldBe(new List<IList<int>>
            {
                new List<int> {1, 2},
                new List<int> {1, 2}
            });
        }

        [Fact]
        public void should_return_result_for_tree_132_and_sum_3()
        {
            solution.PathSum(
                new TreeNode(1)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(2)
                }, 3
            ).ShouldBe(new List<IList<int>>
            {
                new List<int> {1, 2}
            });
        }

        [Fact]
        public void should_return_result_for_tree_m1_m2_and_sum_m3()
        {
            solution.PathSum(
                new TreeNode(-1)
                {
                    right = new TreeNode(-2)
                }, -3
            ).ShouldBe(new List<IList<int>>
            {
                new List<int> {-1, -2}
            });
        }
    }
}