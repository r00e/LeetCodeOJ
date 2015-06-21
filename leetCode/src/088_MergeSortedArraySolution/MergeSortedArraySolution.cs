using System;

namespace leetCode._088_MergeSortedArraySolution
{
    public class MergeSortedArraySolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var i = 0;
            var j = 0;
            var tmp = new int[nums1.Length];
            var tmpIndex = 0;
            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    tmp[tmpIndex++] = nums1[i++];
                }
                else
                {
                    tmp[tmpIndex++] = nums2[j++];
                }
            }

            while (i < m)
            {
                tmp[tmpIndex++] = nums1[i++];
            }
            while (j < n)
            {
                tmp[tmpIndex++] = nums2[j++];
            }

            Array.Copy(tmp, nums1, nums1.Length);
        }
    }
}