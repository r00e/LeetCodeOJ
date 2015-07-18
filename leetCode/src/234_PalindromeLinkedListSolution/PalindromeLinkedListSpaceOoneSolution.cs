using System.Collections.Generic;
using leetCode.Common;
using leetCode.test;

namespace leetCode._234_PalindromeLinkedListSolution
{
    public class PalindromeLinkedListSpaceOoneSolution
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return true;

            var mid = GetMiddleNode(head);
            var half = ReverseLinkedList(mid.next);

            while (half != null)
            {
                if (head.val != half.val) return false;
                head = head.next;
                half = half.next;
            }

            return true;
        }

        private static ListNode ReverseLinkedList(ListNode head)
        {
            ListNode newHead = null;

            while (head != null)
            {
                var next = head.next;
                head.next = newHead;
                newHead = head;
                head = next;
            }

            return newHead;
        }

        private static ListNode GetMiddleNode(ListNode head)
        {
            var slowhead = head;
            var fastHead = head;

            while (fastHead.next != null && fastHead.next.next != null)
            {
                slowhead = slowhead.next;
                fastHead = fastHead.next.next;
            }

            return slowhead;
        }
    }
}