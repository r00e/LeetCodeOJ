using leetCode._08_StringToInteger;
using Xunit.Extensions;
using Xunit.Sdk;
using Xunit.Should;

namespace leetCode.test
{
    public class PalindromeFacts
    {
        private readonly PalindromeSolution solution = new PalindromeSolution();

        [Theory]
        [InlineData(1, true)]
        public void should_return_(int input, bool value)
        {
            solution.IsPanlidrome(input).ShouldBe(value);
        }
    }

    public class PalindromeSolution
    {
        public bool IsPanlidrome(int x)
        {
            return true;
        }
    }
}
