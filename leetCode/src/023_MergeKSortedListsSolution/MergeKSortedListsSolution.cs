using System.Collections.Generic;
using System.Linq;
using leetCode.Common;

namespace leetCode._023_MergeKSortedListsSolution
{
    public class MergeKSortedListsSolution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var result = new ListNode(0);
            var tmpHead = result;
            var heap = BuildMinHeap(lists.ToList());
            while (heap.Count != 0)
            {
                var node = PickMinFromHeap(heap);
                tmpHead.next = node;
                tmpHead = tmpHead.next;
            }

            return result.next;
        }

        private List<ListNode> BuildMinHeap(IList<ListNode> lists)
        {
            lists = lists.Where(list => list != null).ToList();
            var len = lists.Count();

            for (var i = (len - 2) / 2; i >= 0; i--)
            {
                PercolateDown(lists, i, len - 1);
            }

            return lists.ToList();
        }

        private int LeftChild(int x)
        {
            return x * 2 + 1;
        }

        private void PercolateDown(IList<ListNode> lists, int start, int end)
        {
            ListNode tmpNode;
            int child;
            for (tmpNode = lists[start]; LeftChild(start) <= end; start = child)
            {
                child = LeftChild(start);
                if (child + 1 <= end && lists[child + 1].val < lists[child].val)
                {
                    child = child + 1;
                }
                if (lists[child].val < tmpNode.val)
                {
                    lists[start] = lists[child];
                }
                else
                {
                    break;
                }
            }
            lists[start] = tmpNode;
        }

        private ListNode PickMinFromHeap(IList<ListNode> heap)
        {
            var minNode = heap[0];
            DeleteMinFromHeapAndReBuild(heap);
            return minNode;
        }

        private void DeleteMinFromHeapAndReBuild(IList<ListNode> heap)
        {
            var len = heap.Count;

            var tmpNode = heap[0];
            heap[0] = heap[len - 1];
            heap[len - 1] = tmpNode;

            PercolateDown(heap, 0, len - 2);
            if (heap[len - 1] == null || heap[len - 1].next == null)
            {
                heap.RemoveAt(len - 1);
            }
            else
            {
                heap[len - 1] = heap[len - 1].next;
                PercolateUp(heap, 0, len - 1);
            }
        }

        private int Parent(int x)
        {
            if (x == 0) return -1;
            return (x - 1) / 2;
        }

        private void PercolateUp(IList<ListNode> lists, int start, int end)
        {
            var tmpNode = lists[end];

            for (; Parent(end) >= start; end = Parent(end))
            {
                var parent = Parent(end);
                if (lists[parent].val > tmpNode.val)
                {
                    lists[end] = lists[parent];
                }
                else
                {
                    break;
                }
            }

            lists[end] = tmpNode;
        }
    }
}