using System.Collections.Generic;
using System.Linq;
using leetCode.Common;
using leetCode._022_GenerateParenthesesSolution;
using leetCode._024_SwapNodesInPairsSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SwapNodesInPairsFacts
    {
        private readonly SwapNodesInPairsSolution solution = new SwapNodesInPairsSolution();

        [Fact]
        public void should_return_null_for_null()
        {
            solution.SwapPairs(null).ShouldBe(null);
        }

        [Fact]
        public void should_return_1_for_1()
        {
            var inputList = new ListNode(1);
            var expectedList = new ListNode(1);

            solution.SwapPairs(inputList).val.ShouldBe(expectedList.val);
        }

        [Fact]
        public void should_return_21_for_12()
        {
            var inputList = new ListNode(1){next = new ListNode(2)};
            var expectedListValues = new List<int> {2, 1};

            GetValueFromResult(solution.SwapPairs(inputList)).ShouldBe(expectedListValues);
        }

        [Fact]
        public void should_return_213_for_123()
        {
            var inputList = new ListNode(1){next = new ListNode(2){next = new ListNode(3)}};
            var expectedListValues = new List<int> {2, 1, 3};

            GetValueFromResult(solution.SwapPairs(inputList)).ShouldBe(expectedListValues);
        }

        [Fact]
        public void should_return_2143_for_1234()
        {
            var inputList = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                    }
                }
            };
            var expectedListValues = new List<int> {2, 1, 4, 3};

            GetValueFromResult(solution.SwapPairs(inputList)).ShouldBe(expectedListValues);
        }

        [Fact]
        public void should_return_21435_for_12345()
        {
            var inputList = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            var expectedListValues = new List<int> {2, 1, 4, 3, 5};

            GetValueFromResult(solution.SwapPairs(inputList)).ShouldBe(expectedListValues);
        }

        [Fact]
        public void should_return_214365_for_123456()
        {
            var inputList = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(6)
                            }
                        }
                    }
                }
            };
            var expectedListValues = new List<int> {2, 1, 4, 3, 6, 5};

            GetValueFromResult(solution.SwapPairs(inputList)).ShouldBe(expectedListValues);
        }

        private static IList<int> GetValueFromResult(ListNode result)
        {
            var resultValues = new List<int>();

            while (result != null)
            {
                resultValues.Add(result.val);
                result = result.next;
            }

            return resultValues;
        }
    }
}