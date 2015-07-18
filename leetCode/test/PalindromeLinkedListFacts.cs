using System.Collections.Generic;
using System.Text;
using leetCode.Common;
using leetCode._234_PalindromeLinkedListSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class PalindromeLinkedListFacts
    {
        private readonly PalindromeLinkedListSolution solution = new PalindromeLinkedListSolution();
        private readonly PalindromeLinkedListSpaceOoneSolution spaceOoneSolution = new PalindromeLinkedListSpaceOoneSolution();
            
        [Theory]
        [PropertyData("MyTestData")]
        public void should_judge_whether_input_is_power_of_two(ListNode head, bool expectedValue)
        {
            solution.IsPalindrome(head).ShouldBe(expectedValue);
            spaceOoneSolution.IsPalindrome(head).ShouldBe(expectedValue);
        }

        public static IEnumerable<object[]> MyTestData
        {
            get
            {
                return new[]
                {
                    new object[]{null, true}, 
                    new object[]{new ListNode(0), true}, 
                    new object[]{new ListNode(0){next = new ListNode(1)}, false}, 
                    new object[]{new ListNode(0){next = new ListNode(0)}, true}, 
                    new object[]{new ListNode(-1){next = new ListNode(-1)}, true}, 
                    new object[]{new ListNode(0){ next = new ListNode(1) { next = new ListNode(0) }}, true} 
                };
            }
        } 
    }
}