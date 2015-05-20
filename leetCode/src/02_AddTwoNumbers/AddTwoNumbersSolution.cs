namespace leetCode._02_AddTwoNumbers
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sum = (GetVal(l1) + GetVal(l2)) % 10;
            var carry = (GetVal(l1) + GetVal(l2)) / 10;

            var result = new ListNode(sum);

            if (GetNext(l1) == null && GetNext(l2) == null && carry == 0)
            {
                result.next = null;
            }
            else
            {
                var carryNode = new ListNode(carry);
                var twoNumbersSum = AddTwoNumbers(GetNext(l1), GetNext(l2));

                result.next = AddTwoNumbers(twoNumbersSum, carryNode);
            }

            return result;
        }

        private int GetVal(ListNode node)
        {
            return node == null ? 0 : node.val;
        }

        private ListNode GetNext(ListNode node)
        {
            return node == null ? null : node.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
}
