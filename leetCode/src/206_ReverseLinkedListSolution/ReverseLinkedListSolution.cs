using leetCode.Common;

namespace leetCode._206_ReverseLinkedListSolution
{
    // iterative
    public class ReverseLinkedListSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode newHead = null;
            while (head != null)
            {
                var nextNode = head.next;
                
                head.next = newHead;
                newHead = head;
                head = nextNode;
            }

            return newHead;
        }
    }
}