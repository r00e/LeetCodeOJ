namespace leetCode._069_SqrtXSolution
{
    public class SqrtXSolution
    {
        // Actually this is NOT a well structed Square Root question.
        // Because the return value is an integer number, we can just return the approximation for given number
        // For example:
        // 1 for 1
        // 1 for 2
        // 1 for 3
        // 2 for 4
        // 2 for 5

        public int MySqrt(int x)
        {
            if (x <= 0) return 0;

            var left = 1;
            var right = x;
            var mid = (left + right)/2;

            while (left <= right)
            {
                if (mid > x/mid)
                {
                    right = mid - 1;
                    mid = (left + right) / 2;
                }
                else
                {
                    left = mid + 1;
                    mid = (left + right) / 2;
                }                
            }

            return mid;
        }
    }
}