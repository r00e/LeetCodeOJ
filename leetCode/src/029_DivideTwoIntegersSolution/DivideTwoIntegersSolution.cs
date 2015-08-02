using System;

namespace leetCode._029_DivideTwoIntegersSolution
{
    public class DivideTwoIntegersSolution
    {
        public int Divide(int dividend, int divisor)
        {
            if((divisor == 0) || (dividend == int.MinValue && divisor == -1)) return int.MaxValue;
            if (divisor == 1) return dividend;

            var isMinus = (dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0);
            var count = 1;
            var result = 0;
            var dividendNoSign = (uint)Math.Abs((long)dividend);
            var divisorNoSign = (uint)Math.Abs((long)divisor);
            var tmpDivisor = divisorNoSign;

            while (tmpDivisor <= dividendNoSign)
            {
                if (tmpDivisor << 1 > 0)
                {
                    tmpDivisor = tmpDivisor << 1;
                    count = count << 1;

                    if (tmpDivisor > dividendNoSign)
                    {
                        dividendNoSign -= (tmpDivisor >> 1);
                        result += (count >> 1);
                        count = 1;
                        tmpDivisor = divisorNoSign;
                    }
                }
                else
                {
                    dividendNoSign -= tmpDivisor;
                    result += count;
                    count = 1;
                    tmpDivisor = divisorNoSign;
                }
            }

            return isMinus ? 0 - result : result;
        }
    }
}