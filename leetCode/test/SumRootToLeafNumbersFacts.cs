using leetCode.Common;
using leetCode._129_SumRootToLeafNumbers;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SumRootToLeafNumbersFacts
    {
        private readonly SumRootToLeafNumbersSolution solution = new SumRootToLeafNumbersSolution();

        [Fact]
        public void should_return_0_for_null()
        {
            solution.SumNumbers(null).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_for_1()
        {
            solution.SumNumbers(new TreeNode(1)).ShouldBe(1);
        }

        [Fact]
        public void should_return_12_for_1_2()
        {
            solution.SumNumbers(
                new TreeNode(1)
                {
                    left = new TreeNode(2)
                }).ShouldBe(12);
        }

        [Fact]
        public void should_return_12_for_1__2()
        {
            solution.SumNumbers(
                new TreeNode(1)
                {
                    right = new TreeNode(2)
                }).ShouldBe(12);
        }

        [Fact]
        public void should_return_25_for_1_23()
        {
            solution.SumNumbers(
                new TreeNode(1)
                {
                    left = new TreeNode(2),
                    right = new TreeNode(3)
                }).ShouldBe(25);
        }

        [Fact]
        public void should_return_259_for_1_23_4__5()
        {
            solution.SumNumbers(
                new TreeNode(1)
                {
                    left = new TreeNode(2)
                    {
                        left = new TreeNode(4)
                    },
                    right = new TreeNode(3)
                    {
                        right = new TreeNode(5)
                    }
                }).ShouldBe(259);
        }
    }
}