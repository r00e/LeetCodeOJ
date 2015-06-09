namespace leetCode._019_RemoveNthNodeFromEndOfListSolution
{
    public class RemoveNthNodeFromEndOfListSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var length = 0;
            var tmp = head;

            while (tmp != null)
            {
                length = length + 1;
                tmp = tmp.next;
            }

            if (n == length) return head.next;

            tmp = head;
            var count = length - n - 1;
            while (count > 0)
            {
                tmp = tmp.next;
                count--;
            }
            tmp.next = tmp.next.next;

            return head;
        }
    }
}