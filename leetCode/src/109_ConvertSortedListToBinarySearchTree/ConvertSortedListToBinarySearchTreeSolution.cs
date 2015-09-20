using leetCode.Common;

namespace leetCode._109_ConvertSortedListToBinarySearchTree
{
    public class ConvertSortedListToBinarySearchTreeSolution
    {
        private ListNode list;

        public TreeNode SortedListToBST(ListNode head)
        {
            if(head == null) return null;

            list = head;

            var length = 0;
            var probe = head;
            while (probe != null)
            {
                length++;
                probe = probe.next;
            }

            return Helper(0, length - 1);
        }

        private TreeNode Helper(int start, int end)
        {
            if (start > end) return null;

            var mid = (start + end)/2;
            var tree = new TreeNode(0);

            tree.left = Helper(start, mid - 1);
            tree.val = list.val;
            list = list.next;
            tree.right = Helper(mid + 1, end);

            return tree;
        }
    }
}