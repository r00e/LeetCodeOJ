using leetCode.Common;
using leetCode._105_ConstructBinaryTreeFromPreorderAndInorderRecursiveSolution;
using Xunit;

namespace leetCode.test
{
    public class ConstructBinaryTreeFromPreorderAndInorderFacts
    {
//        private readonly ConstructBinaryTreeFromPreorderAndInorderRecursiveSolution recursiveSolution =
//            new ConstructBinaryTreeFromPreorderAndInorderRecursiveSolution();

        private readonly ConstructBinaryTreeFromPreorderAndInorderIterativeSolution recursiveSolution =
            new ConstructBinaryTreeFromPreorderAndInorderIterativeSolution();

        [Fact]
        public void should_return_empty_for_null()
        {
            var result = recursiveSolution.BuildTree(new int[]{}, new int[]{});

            CommonMethod.VerifyTreeNodeResult(result, "[]");
        }

        [Fact]
        public void should_return_empty_for_1_and_1()
        {
            var result = recursiveSolution.BuildTree(new[]{1}, new[]{1});

            CommonMethod.VerifyTreeNodeResult(result, "[1]");
        }

        [Fact]
        public void should_return_empty_for_12_and_1()
        {
            var result = recursiveSolution.BuildTree(new[]{1, 2}, new[]{1});

            CommonMethod.VerifyTreeNodeResult(result, "[]");
        }

        [Fact]
        public void should_return_empty_for_123_and_213()
        {
            var result = recursiveSolution.BuildTree(new[] {1, 2, 3}, new[] {2, 1, 3});

            CommonMethod.VerifyTreeNodeResult(result, "[1, 2, 3]");
        }

        [Fact]
        public void should_return_empty_for_12435_and_42153()
        {
            var result = recursiveSolution.BuildTree(new[] {1, 2, 4, 3, 5}, new[] {4, 2, 1, 5, 3});

            CommonMethod.VerifyTreeNodeResult(result, "[1, 2, 3, 4, #, 5, #]");
        }
    }
}