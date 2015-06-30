using System;
using System.Collections;
using System.Linq;
using leetCode._155_MinStackSolution;
using Xunit;
using Xunit.Sdk;
using Xunit.Should;

namespace leetCode.test
{
    public class MinStackFacts
    {
        private readonly MinStackSolution minStack = new MinStackSolution();

        [Fact]
        public void should_throw_invalid_operation_exception_when_call_Top_on_empty_stack()
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
        public void should_throw_invalid_operation_exception_when_call_Pop_on_empty_stack()
        {
            Assert.Throws<InvalidOperationException>(() => minStack.Pop())
                .Message.ShouldBe("Stack is empty.");
        }

        [Fact]
        public void should_remove_the_top_element_when_call_Pop()
        {
            minStack.Push(0);
            minStack.Push(1);
            minStack.Pop();
            minStack.Top().ShouldBe(0);
        }

        [Fact]
        public void should_throw_invalid_opertaion_when_call_GetMin_on_emtpy_stack()
        {
            Assert.Throws<InvalidOperationException>(() => minStack.GetMin())
                .Message.ShouldBe("Stack is empty.");
        }

        [Fact]
        public void should_return_0_when_call_GetMin_on_stack_01()
        {
            minStack.Push(0);
            minStack.Push(1);
            minStack.GetMin().ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_call_GetMin_on_stack_213()
        {
            minStack.Push(2);
            minStack.Push(1);
            minStack.Push(3);
            minStack.GetMin().ShouldBe(1);
        }

        [Fact]
        public void should_return_1_when_call_GetMin_after_stack_2130_updated_to_213()
        {
            minStack.Push(2);
            minStack.Push(1);
            minStack.Push(3);
            minStack.Push(0);
            minStack.Pop();
            minStack.GetMin().ShouldBe(1);
        }

        [Fact]
        public void should_return_1_when_call_GetMin_after_stack_3254_updated_to_32506()
        {
            minStack.Push(3);
            minStack.Push(2);
            minStack.Push(5);
            minStack.Push(4);
            minStack.Pop();
            minStack.Push(0);
            minStack.Push(6);
            minStack.GetMin().ShouldBe(0);
        }

        [Fact]
        public void should_return_min_value_in_constant_time_when_call_GetMin()
        {
            for (var i = -10000; i < 5000; i++)
            {
                minStack.Push(i);
            }
            var startTime = DateTime.UtcNow;
            for (var i = -10000; i < 5000; i++)
            {
                minStack.GetMin();
                minStack.Pop();
            }
            var endTime = DateTime.UtcNow;

            (endTime - startTime < new TimeSpan(0, 0, 1)).ShouldBeTrue();
        }
    }
}