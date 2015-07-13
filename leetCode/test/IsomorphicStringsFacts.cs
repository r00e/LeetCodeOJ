using leetCode._205_IsomorphicString;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class IsomorphicStringsFacts
    {
        // two given string should have the same length
        private readonly IsomorphicStringsSolution solution = new IsomorphicStringsSolution();
        private readonly IsomorphicStringsSolution2 solution2 = new IsomorphicStringsSolution2();

        [Theory]
        [InlineData("", "", true)]
        [InlineData("a", "a", true)]
        [InlineData("a", "b", true)]
        [InlineData("ab", "bc", true)]
        [InlineData("ab", "bb", false)]
        [InlineData("egg", "add", true)]
        [InlineData("foo", "bar", false)]
        [InlineData("paper", "title", true)]
        [InlineData("abba", "abab", false)]
        public void should_judge_whether_2_strings_are_isomorphic(string s, string t, bool expectedValue)
        {
//            solution.IsIsomorphic(s, t).ShouldBe(expectedValue);
            solution2.IsIsomorphic(s, t).ShouldBe(expectedValue);
        }
    }
}