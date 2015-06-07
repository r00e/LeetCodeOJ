// http://www.cnblogs.com/etcow/archive/2012/09/26/2704855.html

using System;

namespace leetCode._004_FindMedianSortedArrays
{
    class FindMedianSortedArraysSolution2
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var totalLength = nums1.Length + nums2.Length;
            
            if (totalLength%2 == 0)
            {
                return (FindKth(nums1, 0, nums1.Length, nums2, 0, nums2.Length, totalLength/2) +
                    FindKth(nums1, 0, nums1.Length, nums2, 0, nums2.Length, totalLength/2 + 1)) / 2.0;
            }
            
            return FindKth(nums1, 0, nums1.Length, nums2, 0, nums2.Length, totalLength/2 + 1);
        }

        private double FindKth(int[] A, int offsetA, int lengthA, int[] B, int offsetB, int lengthB, int k)
        {
            if (lengthA > lengthB)
                return FindKth(B, offsetB, lengthB, A, offsetA, lengthA, k);

            if (lengthA == 0 && lengthB == 0) return 0.0;
            if (lengthA == 0) return B[offsetB + k - 1];
            if (k == 1) return Math.Min(A[offsetA], B[offsetB]);

            var pA = Math.Min(k/2, lengthA);
            var pB = k - pA;

            if (A[offsetA + pA - 1] <= B[offsetB + pB - 1])
                return FindKth(A, offsetA + pA, lengthA - pA, B, offsetB, lengthB, k - pA);

            return FindKth(A, offsetA, lengthA, B, offsetB + pB, lengthB - pB, k - pB);
        }
    }
}