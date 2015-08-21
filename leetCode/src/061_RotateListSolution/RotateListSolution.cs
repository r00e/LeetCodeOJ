using leetCode.Common;

namespace leetCode._061_RotateListSolution
{
    public class RotateListSolution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if(k < 0 || head == null) return null;
            if (head.next == null) return head;

            var listLength = 1;
            var last = head;
            while (last.next != null)
            {
                last = last.next;
                listLength++;
            }

            k = k % listLength;

            if(k == 0) return head;
            
            var preNewHead = new ListNode(int.MinValue){next = head};
            while (listLength - k > 0)
            {
                k++;
                preNewHead = preNewHead.next;
            }

            last.next = head;
            head = preNewHead.next;
            preNewHead.next = null;

            return head;
        }
    }
}