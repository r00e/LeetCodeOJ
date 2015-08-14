using System.Collections.Generic;
using System.Collections.ObjectModel;
using leetCode._049_GroupAnagramsSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class GroupAnagramsFacts
    {
        private readonly GroupAnagramsSolution solution = new GroupAnagramsSolution();

        [Fact]
        public void should_return_empty_for_empty()
        {
            solution.GroupAnagrams(new string[]{}).ShouldBe(new List<IList<string>>());
        }

        [Fact]
        public void should_return_result_for_a()
        {
            solution.GroupAnagrams(new[]{"a"}).ShouldBe(new List<IList<string>> {new List<string> {"a"}});
        }

        [Fact]
        public void should_return_result_for_a_b()
        {
            solution.GroupAnagrams(new[]{"a", "b"}).ShouldBe(
                new List<IList<string>>
                {
                    new List<string> {"a"},
                    new List<string> {"b"}
                });
        }

        [Fact]
        public void should_return_result_for_ab_ba()
        {
            solution.GroupAnagrams(new[]{"ab", "ba"}).ShouldBe(
                new List<IList<string>>
                {
                    new List<string> {"ab", "ba"}
                });
        }

        [Fact]
        public void should_return_result_for_ab_ba_abc()
        {
            solution.GroupAnagrams(new[]{"ba", "ab", "abc"}).ShouldBe(
                new List<IList<string>>
                {
                    new List<string> {"ab", "ba"},
                    new List<string> {"abc"}
                });
        }
    }
}