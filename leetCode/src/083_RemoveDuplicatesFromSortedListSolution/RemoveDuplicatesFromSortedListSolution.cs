namespace leetCode._083_RemoveDuplicatesFromSortedListSolution
{
    public class RemoveDuplicatesFromSortedListSolution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var tmp = head;
            if (tmp == null) return head;

            while (tmp.next != null)
            {
                if (tmp.val == tmp.next.val) tmp.next = tmp.next.next;
                else tmp = tmp.next;
            }

            return head;
        }
    }
}