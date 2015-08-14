using System;

namespace leetCode._050_PowSolution
{
    public class PowSolutionRecursive
    {
        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;

            double tmpResult = x;
            tmpResult = MyPow(x, n/2);
            if (n%2 == 0)
            {
                return tmpResult*tmpResult;
            }
            else
            {
                if (n > 0) return tmpResult*tmpResult*x;
                else return tmpResult*tmpResult/x;
            }
        }
    }
}