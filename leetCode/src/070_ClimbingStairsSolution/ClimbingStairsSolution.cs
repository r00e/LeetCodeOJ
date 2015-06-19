using System.Runtime.InteropServices;

namespace leetCode._070_ClimbingStairsSolution
{
    public class ClimbingStairsSolution
    {
        // Actually this is a mathmatic problem ^_^
        // For n == 1, you have 1 ways to climb to the top
        // 1
        // For n == 2, you have 2 ways to climb to the top
        // 1, 1
        // 2
        // For n == 3, you have 3 ways to climb to the top
        // 1, 1, 1
        // 2, 1
        // 1, 2
        // For n == 4, you have 5 ways to climb to the top
        // 1, 1, 1, 1
        // 2, 1, 1
        // 1, 2, 1
        // 1, 1, 2
        // 2, 2
        // For n == 5, you have 8 ways to climb to the top
        // 1, 1, 1, 1, 1
        // 2, 1, 1, 1
        // 1, 2, 1, 1
        // 1, 1, 2, 1
        // 1, 1, 1, 2
        // 2, 2, 1
        // 2, 1, 2
        // 1, 2, 2
        // For n ==6, you have 13 ways
        // So it is a Fibonacci
        
        // recursion takes too long time. (Time limeted)
//        public int ClimbingStairs(int n)
//        {
//            if (n == 1) return 1;
//            if (n == 2) return 2;
//
//            return ClimbingStairs(n - 1) + ClimbingStairs(n - 2);
//        }
        public int ClimbingStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            var result = new int[5];

            result[0] = 1;
            result[1] = 2;
            for (var i = 2; i < n; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }
            return result[n - 1];
        }
    }
}