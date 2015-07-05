using leetCode._190_ReverseBitsSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class ReverseBitsFacts
    {
        private readonly ReverseBitsSolution solution = new ReverseBitsSolution();

        [Fact]
        public void should_return_964176192_when_input_is_43261596()
        {
            solution.ReverseBits(43261596).ShouldBe((uint)964176192);
        }
    }
}