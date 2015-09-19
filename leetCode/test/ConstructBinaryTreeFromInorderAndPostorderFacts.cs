using leetCode.Common;
using leetCode._106_ConstructBinaryTreeFromInorderAndPostorderIterativeSolution;
using Xunit;

namespace leetCode.test
{
    public class ConstructBinaryTreeFromInorderAndPostorderFacts
    {
        private readonly ConstructBinaryTreeFromInorderAndPostorderIterativeSolution iterativeSolution =
            new ConstructBinaryTreeFromInorderAndPostorderIterativeSolution();

        [Fact]
        public void should_return_empty_for_null()
        {
            var result = iterativeSolution.BuildTree(new int[]{}, new int[]{});

            CommonMethod.VerifyTreeNodeResult(result, "[]");
        }

        [Fact]
        public void should_return_empty_for_1_and_1()
        {
            var result = iterativeSolution.BuildTree(new[]{1}, new[]{1});

            CommonMethod.VerifyTreeNodeResult(result, "[1]");
        }

        [Fact]
        public void should_return_empty_for_12_and_1()
        {
            var result = iterativeSolution.BuildTree(new[]{1, 2}, new[]{1});

            CommonMethod.VerifyTreeNodeResult(result, "[]");
        }

        [Fact]
        public void should_return_empty_for_123_and_213()
        {
            var result = iterativeSolution.BuildTree(new[] {2, 1, 3}, new[] {2, 3, 1});

            CommonMethod.VerifyTreeNodeResult(result, "[1, 2, 3]");
        }

        [Fact]
        public void should_return_empty_for_231_and_321()
        {
            var result = iterativeSolution.BuildTree(new[] {2, 3, 1}, new[] {3, 2, 1});

            CommonMethod.VerifyTreeNodeResult(result, "[1, 2, #, #, 3]");
        }

        [Fact]
        public void should_return_empty_for_42153_and_42531()
        {
            var result = iterativeSolution.BuildTree(new[] {4, 2, 1, 5, 3}, new[] {4, 2, 5, 3, 1});

            CommonMethod.VerifyTreeNodeResult(result, "[1, 2, 3, 4, #, 5, #]");
        }
    }
}