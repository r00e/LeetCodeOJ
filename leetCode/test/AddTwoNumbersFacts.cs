using System.Collections.Generic;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class AddTwoNumbersFacts
    {
        [Fact]
        public void should_return_0_0_1_when_input_are_1_and_9_9()
        {
            var addTwoNumbersSolution = new AddTwoNumbersSolution();
            var node1 = new ListNode(1);
            var node2 = new ListNode(9) {next = new ListNode(9)};

            var actualResult = addTwoNumbersSolution.AddTwoNumbers(node1, node2);
            
            var expectedResult = new ListNode(0)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(1)
                }
            };

            actualResult.val.ShouldBe(expectedResult.val);
            actualResult.next.val.ShouldBe(expectedResult.next.val);
            actualResult.next.next.val.ShouldBe(expectedResult.next.next.val);
            actualResult.next.next.next.ShouldBeNull();
        }
    }
}
