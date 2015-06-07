using System;

namespace leetCode._09_PalindromeNumber
{
    public class PalindromeNumberSolution
    {
        public bool IsPanlidrome(int x)
        {
            if (x < 0) return false;

            var numLength = (int)Math.Floor(Math.Log(x, 10)) + 1;
            var index = 1;

            while (index <= numLength/2)
            {
                var lowDigit = FindNthDigit(x, index);
                var highDigit = FindNthDigit(x, numLength - index + 1);

                if (lowDigit == highDigit) index++;
                else return false;
            }

            return true;
        }

        private int FindNthDigit(int num, int nth)
        {
            num = num/(int)Math.Pow(10, nth-1);
            return num%10;
        }
    }
}