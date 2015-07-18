namespace leetCode._231_PowerOfTwoSolution
{
    public class PowerOfTwoSolution
    {
        public bool IsPowerOfTwo(int n)
        {
            if(n < 1) return false;
            return (n & (n - 1)) == 0;
        }
    }
}