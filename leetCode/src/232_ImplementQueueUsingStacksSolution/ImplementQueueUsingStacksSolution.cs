using System.Collections.Generic;

namespace leetCode._232_ImplementQueueUsingStacksSolution
{
    public class ImplementQueueUsingStacksSolution
    {
        private Stack<int> stack = new Stack<int>();

        // Push element x to the back of queue.
        public void Push(int x)
        {
            if (stack.Count == 0) stack.Push(x);
            else
            {
                var tmp = new Stack<int>();
                while(stack.Count != 0) tmp.Push(stack.Pop());
                stack.Push(x);
                while(tmp.Count != 0) stack.Push(tmp.Pop());
            }
        }

        // Removes the element from front of queue.
        public void Pop()
        {
            stack.Pop();
        }

        // Get the front element.
        public int Peek()
        {
            return stack.Peek();
        }

        // Return whether the queue is empty.
        public bool Empty()
        {
            return stack.Count == 0;
        }
    }
}