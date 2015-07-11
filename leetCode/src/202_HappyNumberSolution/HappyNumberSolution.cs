using System.Collections.ObjectModel;

namespace leetCode._202_HappyNumberSolution
{
    public class HappyNumberSolution
    {
        public bool IsHappy(int n)
        {
            var existedSum = new Collection<int>();

            while (n != 1 && !existedSum.Contains(n))
            {
                existedSum.Add(n);
                var sum = DigitsSquareSum(n);
                n = sum;
            }

            return n == 1;
        }

        private static int DigitsSquareSum(int num)
        {
            var sum = 0;

            while (num > 0)
            {
                var digit = num%10;
                sum = sum + digit*digit;
                num = num/10;
            }
            return sum;
        }
    }
}