using leetCode.Common;
using leetCode._109_ConvertSortedListToBinarySearchTree;
using Xunit;

namespace leetCode.test
{
    public class ConvertSortedListToBinarySearchTreeFacts
    {
        private readonly ConvertSortedListToBinarySearchTreeSolution solution =
            new ConvertSortedListToBinarySearchTreeSolution();

        [Fact]
        public void should_return_empty_for_null()
        {
            var result = solution.SortedListToBST(null);

            CommonMethod.VerifyTreeNodeResult(result, "[]");
        }

        [Fact]
        public void should_return_result_for_1()
        {
            var result = solution.SortedListToBST(new ListNode(1));

            CommonMethod.VerifyTreeNodeResult(result, "[1]");
        }

        [Fact]
        public void should_return_result_for_12()
        {
            var result = solution.SortedListToBST(new ListNode(1){next = new ListNode(2)});

            CommonMethod.VerifyTreeNodeResult(result, "[1, #, 2]");
        }

        [Fact]
        public void should_return_result_for_123()
        {
            var result = solution.SortedListToBST(new ListNode(1){next = new ListNode(2) {next = new ListNode(3)}});

            CommonMethod.VerifyTreeNodeResult(result, "[2, 1, 3]");
        }
    }
}