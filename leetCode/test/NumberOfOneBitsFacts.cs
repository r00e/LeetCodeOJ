using leetCode._191_NumberOfOneBitsSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class NumberOfOneBitsFacts
    {
        private readonly NumberOfOneBitsSolution solution = new NumberOfOneBitsSolution();

        [Theory]
        [InlineData((uint)1, 1)]
        [InlineData((uint)2, 1)]
        [InlineData((uint)3, 2)]
        public void should_return_number_of_1_bits_for_unsigned_integer(uint n, int oneBitsCount)
        {
            solution.HammingWeight(n).ShouldBe(oneBitsCount);
        }
    }
}