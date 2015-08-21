using System.Collections.Generic;
using leetCode.Common;
using leetCode._061_RotateListSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class RotateListFacts
    {
        private readonly RotateListSolution solution = new RotateListSolution();

        [Fact]
        public void should_return_null_when_k_is_less_than_0()
        {
            var originalList = new ListNode(1);
            var rotatedList = solution.RotateRight(originalList, -1);

            rotatedList.ShouldBeNull();
        }

        [Fact]
        public void should_return_1_for_1_when_k_is_0()
        {
            var originalList = new ListNode(1);
            var rotatedList = solution.RotateRight(originalList, 0);

            var expectedValues = new List<int> {1};
            VerifyList(rotatedList, expectedValues);
        }

        [Fact]
        public void should_return_1_for_1_when_k_is_1()
        {
            var originalList = new ListNode(1);
            var rotatedList = solution.RotateRight(originalList, 1);

            var expectedValues = new List<int> {1};
            VerifyList(rotatedList, expectedValues);
        }

        [Fact]
        public void should_return_21_for_12_when_k_is_1()
        {
            var originalList = new ListNode(1){next = new ListNode(2)};
            var rotatedList = solution.RotateRight(originalList, 1);

            var expectedValues = new List<int> {2, 1};
            VerifyList(rotatedList, expectedValues);
        }

        [Fact]
        public void should_return_12_for_12_when_k_is_2()
        {
            var originalList = new ListNode(1){next = new ListNode(2)};
            var rotatedList = solution.RotateRight(originalList, 2);

            var expectedValues = new List<int> {1, 2};
            VerifyList(rotatedList, expectedValues);
        }

        [Fact]
        public void should_return_21_for_12_when_k_is_3()
        {
            var originalList = new ListNode(1) { next = new ListNode(2) };
            var rotatedList = solution.RotateRight(originalList, 3);

            var expectedValues = new List<int> { 2, 1 };
            VerifyList(rotatedList, expectedValues);
        }

        [Fact]
        public void should_return_12_for_12_when_k_is_4()
        {
            var originalList = new ListNode(1){next = new ListNode(2)};
            var rotatedList = solution.RotateRight(originalList, 4);

            var expectedValues = new List<int> {1, 2};
            VerifyList(rotatedList, expectedValues);
        }

        [Fact]
        public void should_return_231_for_123_when_k_is_2()
        {
            var originalList = new ListNode(1) {next = new ListNode(2) {next = new ListNode(3)}};
            var rotatedList = solution.RotateRight(originalList, 2);

            var expectedValues = new List<int> {2, 3, 1};
            VerifyList(rotatedList, expectedValues);
        }

        [Fact]
        public void should_return_45123_for_12345_when_k_is_2()
        {
            var originalList = new ListNode(1)
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
            var rotatedList = solution.RotateRight(originalList, 2);

            var expectedValues = new List<int> {4, 5, 1, 2, 3};
            VerifyList(rotatedList, expectedValues);
        }

        private void VerifyList(ListNode rotatedList, IList<int> expectedValues)
        {
            var originalListValues = new List<int>();
            while (rotatedList != null)
            {
                originalListValues.Add(rotatedList.val);
                rotatedList = rotatedList.next;
            }

            originalListValues.Count.ShouldBe(expectedValues.Count);
            for (var i = 0; i < expectedValues.Count; i++)
            {
                originalListValues[i].ShouldBe(expectedValues[i]);
            }
        }
    }
}