namespace leetCode._09_PalindromeNumber
{
    public class PalindromeNumberSolution2
    {
        public bool IsPanlidrome(int x)
        {
            if (x < 0 || (x != 0 && x%10 == 0)) return false;

            var tmp = 0;
            while (x > tmp)
            {
                tmp = tmp*10 + x%10;
                x = x/10;
            }

            return tmp == x || tmp/10 == x;
        }
    }
}