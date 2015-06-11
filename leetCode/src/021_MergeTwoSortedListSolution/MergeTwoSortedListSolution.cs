using System.Collections.Generic;

namespace leetCode._021_MergeTwoSortedListSolution
{
    public class MergeTwoSortedListSolution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var newHead = new ListNode(0);
            var tmp = newHead;

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    tmp.next = l2;
                    break;
                }
                else if (l2 == null)
                {
                    tmp.next = l1;
                    break;
                }
                else if (l1.val <= l2.val)
                {
                    tmp.next = l1;
                    tmp = tmp.next;
                    l1 = l1.next;
                }
                else
                {
                    tmp.next = l2;
                    tmp = tmp.next;
                    l2 = l2.next;
                }
            }

            return newHead.next;
        }
    }
}