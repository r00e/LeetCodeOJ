using System.Collections.ObjectModel;

namespace leetCode._202_HappyNumberSolution
{
    public class HappyNumberSolution1
    {
        // we can use one fast pointer and one slow pointer to judge whether a link has a cycle
        // we can also use this method on this problem
        public bool IsHappy(int n)
        {
            var fast = n;
            var slow = n;
            while (slow != 1)
            {
                slow = DigitsSquareSum(slow);
                fast = DigitsSquareSum(fast);
                fast = DigitsSquareSum(fast);

                if(slow == fast && slow != 1) return false;
            }

            return true;
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