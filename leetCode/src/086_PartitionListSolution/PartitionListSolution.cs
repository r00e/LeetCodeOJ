using leetCode.Common;

namespace leetCode._086_PartitionListSolution
{
    public class PartitionListSolution
    {
        public ListNode Partition(ListNode head, int x)
        {
            var firstPart = new ListNode(0);
            var firstProbe = firstPart;
            var secondPart = new ListNode(0);
            var secondProbe = secondPart;

            while (head != null)
            {
                if (head.val < x)
                {
                    firstProbe.next = head;
                    firstProbe = firstProbe.next;
                    head = head.next;
                    firstProbe.next = null;
                }
                else
                {
                    secondProbe.next = head;
                    secondProbe = secondProbe.next;
                    head = head.next;
                    secondProbe.next = null;
                }
            }

            firstProbe.next = secondPart.next;

            return firstPart.next;
        }
    }
}