using leetCode._101_SymmetricTreeSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SymmetricTreeFacts
    {
        // Here's an example:
        //   1
        //  / \
        // 2   3
        //    /
        //   4
        //    \
        //     5
        // The above binary tree is serialized as "{1,2,3,#,#,4,#,#,5}".

//        private readonly SymmetricTreeSolution solution = new SymmetricTreeSolution();
        private readonly SymmetricTreeIterativeSolution solution = new SymmetricTreeIterativeSolution();

        [Fact]
        public void should_return_true_when_tree_is_null()
        {
            solution.IsSymmetric(null).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_tree_has_one_node()
        {
            var tree = new TreeNode(0);

            solution.IsSymmetric(tree).ShouldBeTrue();
        }

        [Fact]
        public void should_return_false_when_tree_is_0_1()
        {
            var tree = new TreeNode(0) {left = new TreeNode(1)};

            solution.IsSymmetric(tree).ShouldBeFalse();
        }

        [Fact]
        public void should_return_false_when_tree_is_0_1_1()
        {
            var tree = new TreeNode(0) {left = new TreeNode(1), right = new TreeNode(1)};

            solution.IsSymmetric(tree).ShouldBeTrue();
        }

        [Fact]
        public void should_return_false_when_tree_is_0_1_1_1()
        {
            var tree = new TreeNode(0)
            {
                left = new TreeNode(1){left = new TreeNode(1)}, 
                right = new TreeNode(1)
            };

            solution.IsSymmetric(tree).ShouldBeFalse();
        }

        [Fact]
        public void should_return_false_when_tree_is_1_2_3_3_null_2_null()
        {
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2) {left = new TreeNode(3)},
                right = new TreeNode(3) {left = new TreeNode(2)}
            };

            solution.IsSymmetric(tree).ShouldBeFalse();
        }
    }
}
