using System;
using System.Collections.Generic;

namespace leetCode._155_MinStackSolution
{
    public class MinStackSolution
    {
        private readonly Stack<int> stack = new Stack<int>();
        private readonly Stack<int> min = new Stack<int>();

        public void Push(int x)
        {
            if(stack.Count == 0 || x <= min.Peek()) min.Push(x);
            stack.Push(x);
        }

        public void Pop()
        {
            try {
                var pop = stack.Pop();
                if (pop == min.Peek()) min.Pop();
            }
            catch(InvalidOperationException e)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        public int Top()
        {
            try
            {
                return stack.Peek();
            }
            catch(InvalidOperationException e)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        public int GetMin()
        {
            try
            {
                return min.Peek();
            }
            catch (InvalidOperationException e)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }
    }
}