using leetCode.Common;

namespace leetCode._203_RemoveLinkedListElement
{
    public class RemoveLinkedListElementSolution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var preNode = new ListNode(0){next = head};
            var listHead = preNode;

            while (preNode.next != null)
            {
                if (preNode.next.val == val) preNode.next = preNode.next.next;
                else preNode = preNode.next;
            }

            return listHead.next;
        }
    }
}