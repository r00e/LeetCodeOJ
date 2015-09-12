using leetCode.Common;

namespace leetCode._092_ReverseLinkedListIISolution
{
    public class ReverseLinkedListIISolution
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (m == n) return head;

            var count = 1;
            var currentNode = head;
            var newHead = new ListNode(0);
            var nodesBeforePositionM = PickNodesBeforePositionM(m, ref count, newHead, ref currentNode);

            var reverseTail = currentNode;
            var reverseHead = ReversePositiomMtoPositionN(n, count, ref currentNode, null);

            nodesBeforePositionM.next = reverseHead;
            reverseTail.next = currentNode;

            return newHead.next;
        }

        private static ListNode ReversePositiomMtoPositionN(int n, int count, ref ListNode probe, ListNode reverseHead)
        {
            while (count <= n)
            {
                var nodeNextProbe = probe.next;
                probe.next = reverseHead;
                reverseHead = probe;
                probe = nodeNextProbe;
                count++;
            }

            return reverseHead;
        }

        private static ListNode PickNodesBeforePositionM(int m, ref int count, ListNode newHead, ref ListNode probe)
        {
            var tail = newHead;

            while (count < m)
            {
                tail.next = probe;
                probe = probe.next;
                tail = tail.next;
                tail.next = null;
                count++;
            }

            return tail;
        }
    }
}