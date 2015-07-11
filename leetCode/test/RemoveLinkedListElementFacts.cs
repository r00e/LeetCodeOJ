using leetCode.Common;
using leetCode._203_RemoveLinkedListElement;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class RemoveLinkedListElementFacts
    {
        private readonly RemoveLinkedListElementSolution solution = new RemoveLinkedListElementSolution();

        [Fact]
        public void should_return_null_when_remove_1_from_1()
        {
            var linkedList = new ListNode(1);
            var result = solution.RemoveElements(linkedList, 1);
            result.ShouldBeNull();
        }

        [Fact]
        public void should_return_2_when_remove_1_from_12()
        {
            var linkedList = new ListNode(1){next = new ListNode(2)};
            var result = solution.RemoveElements(linkedList, 1);
            result.val.ShouldBe(new ListNode(2).val);
            result.next.ShouldBeNull();
        }

        [Fact]
        public void should_return_2_when_remove_1_from_11112()
        {
            var linkedList = new ListNode(1){next = new ListNode(2)};
            var result = solution.RemoveElements(linkedList, 1);
            result.val.ShouldBe(new ListNode(2).val);
            result.next.ShouldBeNull();
        }

        [Fact]
        public void should_return_13_when_remove_2_from_123()
        {
            var linkedList = new ListNode(1){next = new ListNode(2){next = new ListNode(3)}};
            var result = solution.RemoveElements(linkedList, 2);
            
            result.val.ShouldBe(new ListNode(1).val);
            result = result.next;
            result.val.ShouldBe(new ListNode(3).val);
            result.next.ShouldBeNull();
        }

        [Fact]
        public void should_return_13_when_remove_2_from_122223()
        {
            var linkedList = new ListNode(1){next = new ListNode(2){next = new ListNode(3)}};
            var result = solution.RemoveElements(linkedList, 2);
            
            result.val.ShouldBe(new ListNode(1).val);
            result = result.next;
            result.val.ShouldBe(new ListNode(3).val);
            result.next.ShouldBeNull();
        }

        [Fact]
        public void should_return_12_when_remove_3_from_123()
        {
            var linkedList = new ListNode(1){next = new ListNode(2){next = new ListNode(3)}};
            var result = solution.RemoveElements(linkedList, 3);
            
            result.val.ShouldBe(new ListNode(1).val);
            result = result.next;
            result.val.ShouldBe(new ListNode(2).val);
            result.next.ShouldBeNull();
        }

        [Fact]
        public void should_return_11_when_remove_2_from_1221()
        {
            var linkedList = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(1)
                    }
                }
            };
            var result = solution.RemoveElements(linkedList, 2);
            
            result.val.ShouldBe(new ListNode(1).val);
            result = result.next;
            result.val.ShouldBe(new ListNode(1).val);
            result.next.ShouldBeNull();
        }
    }
}