using leetCode._04_FindMedianSortedArrays;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class FindMedianSortedArraysFacts
    {
        private readonly FindMedianSortedArraysSolution solution = new FindMedianSortedArraysSolution();
        private readonly FindMedianSortedArraysSolution2 solution2 = new FindMedianSortedArraysSolution2();

        [Theory]
        [InlineData(new int[] {0}, new int[] {}, 0)]
        [InlineData(new int[] {}, new int[] {0}, 0)]
        [InlineData(new int[] {0, 1}, new int[] {}, 0.5)]
        [InlineData(new int[] {}, new int[] {0, 1}, 0.5)]
        [InlineData(new int[] {0}, new int[] {0}, 0)]
        [InlineData(new int[] {0}, new int[] {1}, 0.5)]
        [InlineData(new int[] {100001}, new int[] {100000}, 100000.5)]
        [InlineData(new int[] {0}, new int[] {1, 2}, 1)]
        [InlineData(new int[] {1, 2}, new int[] { 0 }, 1)]
        [InlineData(new int[] {1, 2, 3}, new int[] {0}, 1.5)]
        [InlineData(new int[] {1, 3}, new int[] {2, 4}, 2.5)]
        [InlineData(new int[] {1, 3}, new int[] {2, 4, 5}, 3)]
        [InlineData(new int[] {1, 1}, new int[] {1, 1}, 1)]
        [InlineData(new int[] {1, 2}, new int[] {2, 3}, 2)]
        [InlineData(new int[] {1, 2, 3}, new int[] {2, 3}, 2)]
        [InlineData(new int[] {1, 6, 7, 8, 9}, new int[] {2, 3, 4, 5, 10}, 5.5)]
        public void should_return_median(int[] array1, int[] array2, double median)
        {
            solution.FindMedianSortedArrays(array1, array2).ShouldBe(median);
            solution2.FindMedianSortedArrays(array1, array2).ShouldBe(median);
        }
    }
}
