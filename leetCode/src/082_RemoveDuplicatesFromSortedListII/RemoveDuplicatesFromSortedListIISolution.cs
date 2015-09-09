using leetCode.Common;

namespace leetCode._082_RemoveDuplicatesFromSortedListII
{
    public class RemoveDuplicatesFromSortedListIISolution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var newHead = new ListNode(0);
            var slow = newHead;

            while (head != null)
            {
                var fast = head.next;
                while (fast != null && fast.val == head.val)
                {
                    fast = fast.next;
                }
                if (head.next == fast)
                {
                    slow.next = head;
                    slow = head;
                    slow.next = null;
                }

                head = fast;
            }

            return newHead.next;
        }
    }
}