namespace leetCode._002_AddTwoNumbers
{
    public class AddTwoNumbersSolution3
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(0);
            var temp = result;
            var sum = 0;

            while (l1 != null || l2 != null)
            {
                sum = sum/10;

                if (l1 != null)
                {
                    sum = sum + l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum = sum + l2.val;
                    l2 = l2.next;
                }

                temp.next = new ListNode(sum%10);
                temp = temp.next;
            }
            
            if (sum/10 == 1)
            {
                temp.next = new ListNode(1);
            }

            return result.next;
        }
    }
}
