using leetCode.Common;
using leetCode._108_ConvertSortedArrayToBinarySearchTreeSolution;
using Xunit;

namespace leetCode.test
{
    public class ConvertSortedArrayToBinarySearchTreeFacts
    {
        private readonly ConvertSortedArrayToBinarySearchTreeSolution solution =
            new ConvertSortedArrayToBinarySearchTreeSolution();

        [Fact]
        public void should_return_empty_for_empty()
        {
            var result = solution.SortedArrayToBST(new int[]{});

            CommonMethod.VerifyTreeNodeResult(result, "[]");
        }

        [Fact]
        public void should_return_result_for_1()
        {
            var result = solution.SortedArrayToBST(new int[]{1});

            CommonMethod.VerifyTreeNodeResult(result, "[1]");
        }

        [Fact]
        public void should_return_result_for_12()
        {
            var result = solution.SortedArrayToBST(new int[] {1, 2});

            CommonMethod.VerifyTreeNodeResult(result, "[1, #, 2]");
        }

        [Fact]
        public void should_return_result_for_123()
        {
            var result = solution.SortedArrayToBST(new int[] {1, 2, 3});

            CommonMethod.VerifyTreeNodeResult(result, "[2, 1, 3]");
        }

        [Fact]
        public void should_return_result_for_122()
        {
            var result = solution.SortedArrayToBST(new int[] {1, 2, 2});

            CommonMethod.VerifyTreeNodeResult(result, "[2, 1, 2]");
        }

        [Fact]
        public void should_return_result_for_222()
        {
            var result = solution.SortedArrayToBST(new int[] {2, 2, 2});

            CommonMethod.VerifyTreeNodeResult(result, "[2, 2, 2]");
        }

        [Fact]
        public void should_return_result_for_2222()
        {
            var result = solution.SortedArrayToBST(new int[] {2, 2, 2, 2});

            // This is right. But my verify code cannot differentiate binary trees as below:
            //     2               2
            //    / \             / \
            //   2   2           2   2
            //    \                   \
            //     2                   2
            // In this case, the last one is what we get.
            // I won't change my verify code because the other TCs are required to transfer binary in this way
            CommonMethod.VerifyTreeNodeResult(result, "[2, 2, 2, #, 2]");
        }
    }
}