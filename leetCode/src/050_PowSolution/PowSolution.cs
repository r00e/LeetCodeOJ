using System;

namespace leetCode._050_PowSolution
{
    public class PowSolution
    {
        public double MyPow(double x, int n)
        {
            if (n == 0 && x.CompareTo(0) != 0) return 1;

            double result = 1, tmpResult = x;
            var isMinus = n <= 0;
            int tmpN;
            if (n != int.MinValue)
            {
                tmpN = Math.Abs(n);
                tmpN--;
            }
            else
            {
                tmpN = Math.Abs(n + 1);
            }
            var offset = 0;

            while (tmpN > 0)
            {
                if (tmpN - (1 << offset) > 0)
                {
                    tmpResult *= tmpResult;
                    tmpN -= (1 << offset);
                    offset++;
                }
                else
                {
                    result *= tmpResult;
                    tmpResult = x;
                    tmpN--;
                    offset = 0;
                }
            }

            result *= tmpResult;
            return isMinus ? 1/result : result;
        }
    }
}