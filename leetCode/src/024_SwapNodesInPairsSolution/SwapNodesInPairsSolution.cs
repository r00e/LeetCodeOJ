using leetCode.Common;

namespace leetCode._024_SwapNodesInPairsSolution
{
    public class SwapNodesInPairsSolution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if(head == null) return null;
            if (head.next == null) return head;

            var newHead = new ListNode(0)
            {
                next = head
            };

            head = head.next;

            while (newHead != null && newHead.next != null && newHead.next.next != null)
            {
                var tmpNode = newHead.next.next;
                newHead.next.next = tmpNode.next;
                tmpNode.next = newHead.next;
                newHead.next = tmpNode;
                newHead = tmpNode.next;
            }

            return head;
        }
    }
}