using leetCode.Common;

namespace leetCode._206_ReverseLinkedListSolution
{
    // recursive
    public class ReverseLinkedListRecursiveSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            return ReverseNode(head, null);
        }

        private ListNode ReverseNode(ListNode firstNode, ListNode secondNode)
        {
            if (firstNode == null) return secondNode;

            var nextNode = firstNode.next;
            firstNode.next = secondNode;
            return ReverseNode(nextNode, firstNode);
        }
    }
}