// just a try. Don't use this because ListNode could be very large number.
using System.Collections.Generic;
using System.Linq;

namespace leetCode._002_AddTwoNumbers
{
    public class AddTwoNumbersSolution2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            long num1 = transferNodeToNumber(l1);
            long num2 = transferNodeToNumber(l2);

            return transferNumberToNode(num1 + num2);
        }

        private ListNode transferNumberToNode(long num)
        {
            var result = new ListNode((int)(num%10))
            {
                next = num/10 != 0 ? transferNumberToNode(num/10) : null
            };

            return result;
        }

        private long transferNodeToNumber(ListNode node)
        {
            var nodeVals = new List<int>();

            while (node != null)
            {
                nodeVals.Add(node.val);
                node = node.next;
            }

            nodeVals.Reverse();

            return nodeVals.Aggregate<int, long>(0, (current, val) => current*10 + val);
        }
    }
}
