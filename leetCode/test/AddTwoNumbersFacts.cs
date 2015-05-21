using leetCode._02_AddTwoNumbers;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class AddTwoNumbersFacts
    {
        private ListNode node1 = new ListNode(1);
        private ListNode node2 = new ListNode(9) { next = new ListNode(9) };
        private ListNode expectedResult = new ListNode(0)
        {
            next = new ListNode(0)
            {
                next = new ListNode(1)
            }
        };

        [Fact]
        public void should_return_0_0_1_when_input_are_1_and_9_9()
        {
            var addTwoNumbersSolution = new AddTwoNumbersSolution();

            var actualResult = addTwoNumbersSolution.AddTwoNumbers(node1, node2);

            actualResult.val.ShouldBe(expectedResult.val);
            actualResult.next.val.ShouldBe(expectedResult.next.val);
            actualResult.next.next.val.ShouldBe(expectedResult.next.next.val);
            actualResult.next.next.next.ShouldBeNull();
        }

        [Fact]
        public void should_return_18_when_input_are_0_and_18_for_solution2()
        {
            var addTwoNumbersSolution2 = new AddTwoNumbersSolution2();
            var actualResult2 = addTwoNumbersSolution2.AddTwoNumbers(
                new ListNode(1){next = new ListNode(8)}, 
                new ListNode(0)
            );
            var newExpectedResult = new ListNode(1) {next = new ListNode(8)};

            actualResult2.val.ShouldBe(newExpectedResult.val);
            actualResult2.next.val.ShouldBe(newExpectedResult.next.val);
            actualResult2.next.next.ShouldBeNull();
        }

        [Fact]
        public void should_return_00000000001_when_input_are_9_and_199999999_for_solution2()
        {
            var addTwoNumbersSolution2 = new AddTwoNumbersSolution2();
            var actualResult2 = addTwoNumbersSolution2.AddTwoNumbers(
                new ListNode(9),
                new ListNode(1)
                {
                    next = new ListNode(9)
                    {
                        next = new ListNode(9)
                        {
                            next = new ListNode(9)
                            {
                                next = new ListNode(9)
                                {
                                    next = new ListNode(9)
                                    {
                                        next = new ListNode(9)
                                        {
                                            next = new ListNode(9)
                                            {
                                                next = new ListNode(9)
                                                {
                                                    next = new ListNode(9)
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            );
            var newExpectedResult = new ListNode(0)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(0)
                    {
                        next = new ListNode(0)
                        {
                            next = new ListNode(0)
                            {
                                next = new ListNode(0)
                                {
                                    next = new ListNode(0)
                                    {
                                        next = new ListNode(0)
                                        {
                                            next = new ListNode(0)
                                            {
                                                next = new ListNode(0)
                                                {
                                                    next = new ListNode(1)
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            actualResult2.val.ShouldBe(newExpectedResult.val);
            actualResult2.next.val.ShouldBe(newExpectedResult.next.val);
        }

        [Fact]
        public void should_return_18_when_input_are_18_and_0_for_solution3()
        {
            var addTwoNumbersSolution3 = new AddTwoNumbersSolution3();
            var actualResult3 = addTwoNumbersSolution3.AddTwoNumbers(
                new ListNode(1) { next = new ListNode(8) },
                new ListNode(0)
            );
            var newExpectedResult = new ListNode(1) { next = new ListNode(8) };

            actualResult3.val.ShouldBe(newExpectedResult.val);
            actualResult3.next.val.ShouldBe(newExpectedResult.next.val);
            actualResult3.next.next.ShouldBeNull();
        }
    }
}
