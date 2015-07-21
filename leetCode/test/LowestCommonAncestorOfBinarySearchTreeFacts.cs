using leetCode.Common;
using leetCode._235_LowestBinaryCommonAncestorOfBinarySearchTreeSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class LowestCommonAncestorOfBinarySearchTreeFacts
    {
//        private readonly LowestCommonAncestorOfBinarySearchTreeSolution solution = new LowestCommonAncestorOfBinarySearchTreeSolution();

        private readonly LowestCommonAncestorOfBinarySearchTreeIterativeSolution solution =
            new LowestCommonAncestorOfBinarySearchTreeIterativeSolution();
            
        [Fact]
        public void should_return_6_for_3_and_7_in_tree637()
        {
            var p = new TreeNode(3);
            var q = new TreeNode(7);
            var tree = new TreeNode(6){left = p, right = q};

            solution.LowestCommonAncestor(tree, p, q).ShouldBe(tree);
        }
            
        [Fact]
        public void should_return_2_for_2_and_4_in_tree62804()
        {
            var q = new TreeNode(4);
            var p = new TreeNode(2){left = new TreeNode(0), right = q};
            var tree = new TreeNode(6)
            {
                left = p, 
                right = new TreeNode(8)
            };

            solution.LowestCommonAncestor(tree, p, q).ShouldBe(p);
        }
            
        [Fact]
        public void should_return_8_for_7_and_9_in_tree628__79()
        {
            var p = new TreeNode(7);
            var q = new TreeNode(9);
            var resultNode = new TreeNode(8) {left = p, right = q};
            var tree = new TreeNode(6)
            {
                left = new TreeNode(2), 
                right = resultNode
            };

            solution.LowestCommonAncestor(tree, p, q).ShouldBe(resultNode);
        }
    }
}