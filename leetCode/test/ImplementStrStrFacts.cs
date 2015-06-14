using leetCode._028_ImplementStrStrSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ImplementStrStrFacts
    {
        private readonly ImplementStrStrSolution solution = new ImplementStrStrSolution();

        [Theory]
        [InlineData("", "", 0)]
        [InlineData("a", "", 0)]
        [InlineData("a", "b", -1)]
        [InlineData("a", "a", 0)]
        [InlineData("aaa", "aa", 0)]
        [InlineData("cab", "ab", 1)]
        [InlineData("cdefgab", "ab", 5)]
        [InlineData("mississippi", "issip", 4)]
        
        public void should_return_index_of_the_first_occurence_of_needle_in_haystack(string haystack, string needle, int expectIndex)
        {
            solution.StrStr(haystack, needle).ShouldBe(expectIndex);
        }
    }
}