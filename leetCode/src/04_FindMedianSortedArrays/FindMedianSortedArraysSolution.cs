using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace leetCode._04_FindMedianSortedArrays
{
    class FindMedianSortedArraysSolution
    {
        public double FindMedianSortedArrays(int[] array1, int[] array2)
        {
            var middle = (array1.Length + array2.Length)/2;
            if ((array1.Length + array2.Length)%2 != 0)
            {
                return array1.Length > middle ? array1[middle] : array2[middle - array1.Length];
            }
            else
            {
                return (double)(array1[0] + array2[0])/2;
            }
        }
    }
}