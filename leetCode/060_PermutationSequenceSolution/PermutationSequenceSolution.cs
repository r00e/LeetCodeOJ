using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._060_PermutationSequenceSolution
{
    public class PermutationSequenceSolution
    {
        // We can group all permutation by the 1st char.
        // Let's say we have n = 3 and k = 5
        //
        // All the permutaion for 3 are as below :
        // 123 |   k = 1,   0/Factorial(2) = 0
        // 132 |__ k = 2,   1/Factorial(2) = 0, this is group 0
        // 213 |   k = 3,   2/Factorial(2) = 1
        // 231 |__ k = 4,   3/Factorial(2) = 1, this is group 1
        // 312 |   k = 5,   4/Factorial(2) = 2
        // 321 |__ k = 6,   5/Factorial(2) = 2, this is group 2
        //
        // For k = 3, it's in group 1
        // From the permutation, we know that we have to put "2" in the 1st postion of result string
        public string GetPermutation(int n, int k)
        {
            if (n == 0 || k == 0) return string.Empty;
            
            var allNums = new List<int>();
            for (var i = 1; i <= n; i++) allNums.Add(i);
            
            var result = new StringBuilder();

            while (n > 1)
            {
                var groupLength = GetFactorial(n - 1);
                var groupIndex = (k - 1)/groupLength;

                result.Append(allNums[groupIndex]);
                allNums.RemoveAt(groupIndex);

                k = k - groupIndex*groupLength;
                n = n - 1;
            }

            result.Append(allNums[0]);
            return result.ToString();
        }

        private int GetFactorial(int n)
        {
            if (n < 0) throw new Exception(string.Format("Error happened when get factorial for: {0}", n));
            if (n == 0 || n == 1) return 1;
            return n*GetFactorial(n - 1);
        }
    }
}