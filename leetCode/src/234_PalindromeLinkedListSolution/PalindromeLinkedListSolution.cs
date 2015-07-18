using System.Collections.Generic;
using leetCode.Common;

namespace leetCode._234_PalindromeLinkedListSolution
{
    public class PalindromeLinkedListSolution
    {
        public bool IsPalindrome(ListNode head)
        {
            var valOflinkedList = new List<int>();
            while (head != null)
            {
                valOflinkedList.Add(head.val);
                head = head.next;
            }

            for (var i = 0; i < valOflinkedList.Count/2; i++)
            {
                if(valOflinkedList[i] != valOflinkedList[valOflinkedList.Count - 1 - i]) 
                    return false;
            }

            return true;
        }
    }
}