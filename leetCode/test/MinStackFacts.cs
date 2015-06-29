using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Sdk;
using Xunit.Should;

namespace leetCode.test
{
    public class MinStackFacts
    {
        private readonly MinStackSolution minStack = new MinStackSolution();

        [Fact]
        public void should_return_invalid_exception_when_call_Top_for_empty_stack()
        {
            Assert.Throws<InvalidOperationException>(() => minStack.Top())
                .Message.ShouldBe("Stack is empty.");
        }

        [Fact]
        public void should_return_top_element_when_call_Top()
        {
            minStack.Push(0);
            minStack.Top().ShouldBe(0);
        }

        [Fact]
        public void should_return_top_element_without_Pop_when_call_Top()
        {
            minStack.Push(0);
            minStack.Push(1);
            minStack.Top().ShouldBe(1);
            minStack.Top().ShouldNotBe(0);
        }

        [Fact]
        public void should_return_invalid_operation_when_call_Pop_for_empty_stack()
        {
            Assert.Throws<InvalidOperationException>(() => minStack.Pop())
                .Message.ShouldBe("Stack is empty.");
        }

        [Fact]
        public void should_pop_the_top_element_when_call_Pop()
        {
            minStack.Push(0);
            minStack.Push(1);
            minStack.Pop();
            minStack.Top().ShouldBe(0);
        }
    }

    internal class MinStackSolution
    {
        private readonly Stack<int> stack = new Stack<int>();

        public void Push(int x)
        {
            stack.Push(x);
        }

        public void Pop()
        {
            if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");
            stack.Pop();
        }

        public int Top()
        {
            if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");
            return stack.Peek();
        }

        public int GetMin()
        {
            return 0;
        }
    }
}