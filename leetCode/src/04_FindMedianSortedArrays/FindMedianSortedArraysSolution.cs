// http://articles.leetcode.com/2011/01/find-k-th-smallest-element-in-union-of.html

using System;

namespace leetCode._04_FindMedianSortedArrays
{
    class FindMedianSortedArraysSolution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length, len2 = nums2.Length;
            var totalLen = len1 + len2;
            var midIndex = (len1 + len2) / 2;
            var mid = FindKth(nums1, 0, len1 - 1, nums2, 0, len2 - 1, midIndex);

            if (totalLen % 2 != 0)
            {
                return mid;
            }
            else
            {
                mid = mid + FindKth(nums1, 0, len1-1, nums2, 0, len2-1, midIndex - 1);
                mid = mid / 2;
            }

            return mid;
        }

        private double FindKth(int[] nums1, int l1, int r1, int[] nums2, int l2, int r2, int k)
        {
            var len1 = r1 - l1 + 1;
            var len2 = r2 - l2 + 1;

            if (len1 == 0) return nums2[l2 + k];
            if (len2 == 0) return nums1[l1 + k];
            if (k == 0) return Math.Min(nums1[l1], nums2[l2]);

            var i = k*(len1)/(len1 + len2);
            var j = k - i;

            var numPreI = i <= 0 ? int.MinValue : nums1[l1 + i - 1];
            var numPreJ = j <=0 ? int.MinValue : nums2[l2 + j - 1];
            var numI = i == len1 ? int.MaxValue : nums1[l1 + i];
            var numJ = j == len2 ? int.MaxValue : nums2[l2 + j];

            if (numPreJ <= numI && numI <= numJ) return numI;
            if (numPreI <= numJ && numJ <= numI) return numJ;

            if (numI <= numJ) return FindKth(nums1, l1 + i + 1, r1, nums2, l2, (l2 + j - 1) < l2 ? l2 - 1 : j - 1, k - i - 1);
            else return FindKth(nums1, l1, (l1 + i - 1) < l1 ? l1 - 1 : i - 1, nums2, l2 + j + 1, r2, k - j - 1);
        }
    }
}