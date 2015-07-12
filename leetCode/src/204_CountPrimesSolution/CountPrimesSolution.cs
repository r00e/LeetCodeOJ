using System.Collections;
using System.Linq;

namespace leetCode._204_CountPrimesSolution
{
    public class CountPrimesSolution
    {
        public int CountPrimes(int n)
        {
            if (n < 3) return 0;
            var nIsPrime = new BitArray(n-2, true);

            for (var i = 2; i*i < n; i++)
            {
                if(!nIsPrime[i-2]) continue;
                for (var j = i*i; j < n; j = j + i)
                {
                    nIsPrime[j-2] = false;
                }
            }

            return nIsPrime.OfType<bool>().Count(bit => bit);
        }
    }
}