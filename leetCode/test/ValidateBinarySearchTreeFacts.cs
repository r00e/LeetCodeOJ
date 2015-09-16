using System.Linq;
using leetCode.Common;
using leetCode._098_ValidateBinarySearchTree;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class ValidateBinarySearchTreeFacts
    {
        private readonly ValidateBinarySearchTreeSolution solution = new ValidateBinarySearchTreeSolution();
            
        [Fact]
        public void should_return_true_for_null()
        {
            solution.IsValidBST(null).ShouldBeTrue();
        }
            
        [Fact]
        public void should_return_true_for_1()
        {
            solution.IsValidBST(new TreeNode(1)).ShouldBeTrue();
        }
            
        [Fact]
        public void should_return_false_for_11()
        {
            solution.IsValidBST(new TreeNode(1)
            {
                left = new TreeNode(1)
            }).ShouldBeFalse();
        }
            
        [Fact]
        public void should_return_false_for_1_1()
        {
            solution.IsValidBST(new TreeNode(1)
            {
                right = new TreeNode(1)
            }).ShouldBeFalse();
        }
            
        [Fact]
        public void should_return_true_for_213()
        {
            solution.IsValidBST(new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(3)
            }).ShouldBeTrue();
        }
            
        [Fact]
        public void should_return_false_for_859__1()
        {
            solution.IsValidBST(new TreeNode(8)
            {
                left = new TreeNode(5),
                right = new TreeNode(9) { left = new TreeNode(1)}
            }).ShouldBeFalse();
        }
    }
}