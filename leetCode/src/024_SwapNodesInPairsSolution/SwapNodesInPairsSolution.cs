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

//          a shorter solution
//            if (head == null || head.next == null) return head;
//
//            var left = head;
//            var right = head.next;
//            var newHead = right;
//
//            while (left != null && right != null)
//            {
//                var tmp = right.next;
//                right.next = left;
//                left.next = tmp == null ? tmp : tmp.next;
//                right = left.next;
//                left = tmp;
//            }
//
//            return newHead;
        }
    }
}