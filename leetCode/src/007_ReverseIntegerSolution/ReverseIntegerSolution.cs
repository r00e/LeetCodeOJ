namespace leetCode._007_ReverseIntegerSolution
{
    public class ReverseIntegerSolution
    {
        public int Reverse(int x)
        {
            int result = 0;

            while (x != 0)
            {
                if (result != result*10/10) return 0;
                result = result*10 + x%10;
                x = x/10;
            }
            
            return result;
        }
    }
}