using System;
using leetCode._04_FindMedianSortedArrays;
using Xunit;

namespace leetCode.test
{
    public class FindMedianSortedArraysFacts
    {
        private readonly FindMedianSortedArraysSolution solution = new FindMedianSortedArraysSolution();

        [Fact]
        public void should_return_0_when_arrays_are_0_and_0()
        {
            solution.FindMedianSortedArrays(new int[] {0}, new int[] {0});
        }
    }
}
