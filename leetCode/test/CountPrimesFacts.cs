using leetCode._204_CountPrimesSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class CountPrimesFacts
    {
        private readonly CountPrimesSolution solution = new CountPrimesSolution();

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(3, 1)]
        [InlineData(5, 2)]
        [InlineData(7, 3)]
        public void should_return_the_amount_of_primes_which_are_less_than_n(int n, int amount)
        {
            solution.CountPrimes(n).ShouldBe(amount);
        }
    }
}