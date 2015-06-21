using leetCode._088_MergeSortedArraySolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class MergeSortedArrayFacts
    {
        private readonly MergeSortedArraySolution solution = new MergeSortedArraySolution();
        private readonly MergeSortedArraySolution2 solution2 = new MergeSortedArraySolution2();

        [Fact]
        public void should_merge_nums2_into_nums1_for_solution()
        {
            var nums1 = new int[10];
            nums1[0] = 3;
            nums1[1] = 5;
            nums1[2] = 8;
            nums1[3] = 9;
            var m = 4;
            var nums2 = new int[5];
            nums2[0] = 2;
            nums2[1] = 3;
            nums2[2] = 6;
            nums2[3] = 10;
            var n = 4;
            solution2.Merge(nums1, m, nums2, n);
            nums1[0].ShouldBe(2);
            nums1[1].ShouldBe(3);
            nums1[2].ShouldBe(3);
            nums1[3].ShouldBe(5);
            nums1[4].ShouldBe(6);
            nums1[5].ShouldBe(8);
            nums1[6].ShouldBe(9);
            nums1[7].ShouldBe(10);
        }

        [Fact]
        public void should_merge_nums2_into_nums1_solution2()
        {
            var nums1 = new int[10];
            nums1[0] = 3;
            nums1[1] = 5;
            nums1[2] = 8;
            nums1[3] = 9;
            var m = 4;
            var nums2 = new int[5];
            nums2[0] = 2;
            nums2[1] = 3;
            nums2[2] = 6;
            nums2[3] = 10;
            var n = 4;
            solution2.Merge(nums1, m, nums2, n);
            nums1[0].ShouldBe(2);
            nums1[1].ShouldBe(3);
            nums1[2].ShouldBe(3);
            nums1[3].ShouldBe(5);
            nums1[4].ShouldBe(6);
            nums1[5].ShouldBe(8);
            nums1[6].ShouldBe(9);
            nums1[7].ShouldBe(10);
        }
    }
}
