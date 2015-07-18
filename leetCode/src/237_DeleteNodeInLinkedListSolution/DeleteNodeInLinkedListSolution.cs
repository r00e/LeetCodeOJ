using leetCode.Common;

namespace leetCode._237_DeleteNodeInLinkedListSolution
{
    public class DeleteNodeInLinkedListSolution
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}