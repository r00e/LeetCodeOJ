using leetCode.Common;
using leetCode._237_DeleteNodeInLinkedListSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class DeleteNodeInLinkedListFacts
    {
        private readonly DeleteNodeInLinkedListSolution solution = new DeleteNodeInLinkedListSolution();
            
        [Fact]
        public void should_delete_given_node_from_linked_list()
        {
            var deletedNode = new ListNode(1);
            var linkedList = new ListNode(0)
            {
                next = deletedNode
            };
            deletedNode.next = new ListNode(2);

            solution.DeleteNode(deletedNode);

            linkedList.val.ShouldBe(0);
            linkedList.next.val.ShouldBe(2);
            linkedList.next.next.ShouldBeNull();
        } 
    }
}