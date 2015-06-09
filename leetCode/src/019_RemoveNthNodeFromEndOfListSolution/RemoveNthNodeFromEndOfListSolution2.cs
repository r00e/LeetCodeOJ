namespace leetCode._019_RemoveNthNodeFromEndOfListSolution
{
    public class RemoveNthNodeFromEndOfListSolution2
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var tmpHead = new ListNode(0);
            tmpHead.next = head;

            var front = tmpHead;
            var back = tmpHead;

            while (n > 0)
            {
                front = front.next;
                n--;
            }

            while (front.next != null)
            {
                front = front.next;
                back = back.next;
            }

            back.next = back.next.next;

            return tmpHead.next;
        }
    }
}