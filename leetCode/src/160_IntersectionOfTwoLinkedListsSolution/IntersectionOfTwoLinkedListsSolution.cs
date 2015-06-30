using leetCode.Common;

namespace leetCode._160_IntersectionOfTwoLinkedListsSolution
{
    public class IntersectionOfTwoLinkedListsSolution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if(headA == null || headB == null) return null;
            var hA = headA;
            var hB = headB;
            while (hA != hB)
            {
                hA = hA == null ? headB : hA.next;
                hB = hB == null ? headA : hB.next;
            }
            return hA;
        }
    }
}