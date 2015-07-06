namespace leetCode._191_NumberOfOneBitsSolution
{
    public class NumberOfOneBitsSolution
    {
        public int HammingWeight(uint n)
        {
            var result = 0;
            while (n > 0)
            {
                if ((n & 1) == 1) result++;
                n = n - 1;
            }

            return result;

//
//            var result = 0;
//            for (var i = 0; i < 32; i++)
//            {
//                if ((n & 1) == 1) result++;
//                n = n >> 1;
//            }
//
//            return result;
        }
    }
}