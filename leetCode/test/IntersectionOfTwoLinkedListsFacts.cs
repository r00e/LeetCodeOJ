using leetCode.Common;
using leetCode._160_IntersectionOfTwoLinkedListsSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class IntersectionOfTwoLinkedListsFacts
    {
        private readonly IntersectionOfTwoLinkedListsSolution solution = 
            new IntersectionOfTwoLinkedListsSolution();

        [Fact]
        public void should_null_when_both_2_lists_are_null()
        {
            solution.GetIntersectionNode(null, null).ShouldBeNull();
        }

        [Fact]
        public void should_null_when_anyone_of_lists_is_null()
        {
            solution.GetIntersectionNode(null, new ListNode(0)).ShouldBeNull();
        }

        [Fact]
        public void should_return_intersection_point_when_2_lists_length_are_same()
        {
//          A: a1
//               ↘
//                c1
//               ↗            
//          B: b1
            var listC = new ListNode(0);
            var listA = new ListNode(0) {next = listC};
            var listB = new ListNode(0) {next = listC};

            solution.GetIntersectionNode(listA, listB).ShouldBeSameAs(listC);
        }

        [Fact]
        public void should_return_intersection_point_when_2_lists_length_are_not_same()
        {
//          A:      a1
//                    ↘
//                     c1
//                    ↗            
//          B: b1 → b2
            var listC = new ListNode(0);
            var listA = new ListNode(0) {next = listC};
            var listB = new ListNode(0) {next = new ListNode(1) {next = listC}};

            solution.GetIntersectionNode(listA, listB).ShouldBeSameAs(listC);
        }

        [Fact]
        public void should_return_null_when_2_lists_length_has_no_intersection()
        {
//          A: a1 → a2
//          B: b1 → b2
            var listA = new ListNode(0) {next = new ListNode(1)};
            var listB = new ListNode(0) {next = new ListNode(1)};

            solution.GetIntersectionNode(listA, listB).ShouldBeSameAs(null);
        }
    }
}