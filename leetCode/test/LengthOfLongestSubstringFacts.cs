using leetCode._03_LengthOfLongestSubstring;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class LengthOfLongestSubstringFacts
    {
        private readonly LengthOfLongestSubstringSolution solution = new LengthOfLongestSubstringSolution();

        [Fact]
        public void should_return_0_when_input_empty_string()
        {
            solution.LengthOfLongestSubstring(string.Empty).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_input_a()
        {
            solution.LengthOfLongestSubstring("a").ShouldBe(1);
        }

        [Fact]
        public void should_return_1_when_input_aa()
        {
            solution.LengthOfLongestSubstring("aa").ShouldBe(1);
        }
    }
}
