namespace leetCode._172_FactorialTrailingZeroesSolution
{
    public class FactorialTrailingZeroesSolution
    {
        public int TrailingZeroes(int n)
        {
            return n == 0 ? 0 : (n/5 + TrailingZeroes(n/5));
        }
    }
}