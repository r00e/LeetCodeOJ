using leetCode._100_SameTreeSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SameTreeFacts
    {
        private readonly SameTreeSolution solution = new SameTreeSolution();

        [Fact]
        public void should_return_true_when_oneNodetree1_is_same_with_oneNodetree2()
        {
            var oneNodeTree1 = new TreeNode(0);
            var oneNodeTree2 = new TreeNode(0);

            solution.IsSameTree(oneNodeTree1, oneNodeTree2).ShouldBeTrue();
        }

        [Fact]
        public void should_return_false_when_oneNodeTree1_is_NOT_same_with_oneNodeTree2()
        {
            var oneNodeTree1 = new TreeNode(0);
            var oneNodeTree2 = new TreeNode(1);

            solution.IsSameTree(oneNodeTree1, oneNodeTree2).ShouldBeFalse();
        }

        [Fact]
        public void should_return_true_when_twoNodeTree1_is_same_with_twoNodeTree2_on_both_value_and_structure()
        {
            var twoNodeTree1 = new TreeNode(0) {left = new TreeNode(1)};
            var twoNodeTree2 = new TreeNode(0) {left = new TreeNode(1)};

            solution.IsSameTree(twoNodeTree1, twoNodeTree2).ShouldBeTrue();
        }

        [Fact]
        public void should_return_false_when_twoNodeTree1_is_same_with_twoNodeTree2_on_value_but_different_on_structure()
        {
            var twoNodeTree1 = new TreeNode(0) {left = new TreeNode(1)};
            var twoNodeTree2 = new TreeNode(0) {right = new TreeNode(1)};

            solution.IsSameTree(twoNodeTree1, twoNodeTree2).ShouldBeFalse();
        }
    }
}
