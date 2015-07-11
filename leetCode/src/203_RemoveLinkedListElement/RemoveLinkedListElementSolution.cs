using leetCode.Common;

namespace leetCode._203_RemoveLinkedListElement
{
    public class RemoveLinkedListElementSolution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var currentHead = head;
            while (currentHead != null && currentHead.val == val)
            {
                currentHead = head.next;
                head = currentHead;
            }
            while (currentHead != null)
            {
                if (currentHead.next == null) break;
                if (currentHead.next.val == val) currentHead.next = currentHead.next.next;
                else currentHead = currentHead.next;
            }

            return head;
        }
    }
}