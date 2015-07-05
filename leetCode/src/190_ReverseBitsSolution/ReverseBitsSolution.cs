namespace leetCode._190_ReverseBitsSolution
{
    public class ReverseBitsSolution
    {
        public uint ReverseBits(uint n)
        {
            var result = (uint) 0;
            for (var i = 0; i < 32; i++)
            {
                result = result << 1;
                result = result | (n & 1);
                n = n >> 1;
            }

            return result;
        }
    }
}