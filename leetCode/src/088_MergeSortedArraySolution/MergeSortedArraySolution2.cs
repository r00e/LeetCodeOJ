using System;

namespace leetCode._088_MergeSortedArraySolution
{
    public class MergeSortedArraySolution2
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var i = m - 1;
            var j = n - 1;
            var tmp = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] < nums2[j])
                {
                    nums1[tmp--] = nums2[j--];
                }
                else
                {
                    nums1[tmp--] = nums1[i--];
                }
            }

            while (j >= 0)
            {
                nums1[tmp--] = nums2[j--];
            }
        }
    }
}