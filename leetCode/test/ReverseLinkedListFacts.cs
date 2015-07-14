using leetCode.Common;
using leetCode._206_ReverseLinkedListSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class ReverseLinkedListFacts
    {
        private readonly ReverseLinkedListSolution solution = new ReverseLinkedListSolution();
        private readonly ReverseLinkedListRecursiveSolution recursiveSolution = new ReverseLinkedListRecursiveSolution();

        [Fact]
        public void should_return_null_when_reverse_null_list()
        {
            solution.ReverseList(null).ShouldBeNull();
            recursiveSolution.ReverseList(null).ShouldBeNull();
        }

        [Fact]
        public void should_return_1_when_reverse_list_1()
        {
            solution.ReverseList(new ListNode(1)).val.ShouldBe(1);
            recursiveSolution.ReverseList(new ListNode(1)).val.ShouldBe(1);
        }

        [Fact]
        public void should_return_21_when_reverse_list_12()
        {
            var result = solution.ReverseList(new ListNode(1) {next = new ListNode(2)});
            result.val.ShouldBe(2);
            result = result.next;
            result.val.ShouldBe(1);
            var recursiveResult = recursiveSolution.ReverseList(new ListNode(1) {next = new ListNode(2)});
            recursiveResult.val.ShouldBe(2);
            recursiveResult = recursiveResult.next;
            recursiveResult.val.ShouldBe(1);
        }
    }
}