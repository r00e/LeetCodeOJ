using System;
using System.Collections;
using System.Collections.Generic;

namespace leetCode._225_ImplementStackUsingQueueSolution
{
    public class ImplementStackUsingQueueSolution
    {
        private readonly Queue<int> queueMain = new Queue<int>();
        private readonly Queue<int> queueTemp = new Queue<int>();

        // Push element x onto stack.
        public void Push(int x)
        {
            queueMain.Enqueue(x);
        }

        // Removes the element on top of the stack.
        public void Pop()
        {
            while (queueMain.Count > 1)
            {
                queueTemp.Enqueue(queueMain.Dequeue());
            }

            queueMain.Dequeue();

            while(queueTemp.Count > 0) queueMain.Enqueue(queueTemp.Dequeue());
        }

        // Get the top element.
        public int Top()
        {
            while (queueMain.Count > 1)
            {
                queueTemp.Enqueue(queueMain.Dequeue());
            }

            var top = queueMain.Dequeue();

            queueTemp.Enqueue(top);

            while (queueTemp.Count > 0) queueMain.Enqueue(queueTemp.Dequeue());

            return top;
        }

        // Return whether the stack is empty.
        public bool Empty()
        {
            return queueMain.Count == 0;
        }
    }
}