using System.Collections.Generic;
using leetCode._131_PalindromePartitioningSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class PalindromePartitioningFacts
    {
        private readonly PalindromePartitioningSolution solution = new PalindromePartitioningSolution();

        [Fact]
        public void should_return_empty_list_for_empty_string()
        {
            solution.Partition(string.Empty).ShouldBe(new List<IList<string>>());
        }

        [Fact]
        public void should_return_a_for_a()
        {
            solution.Partition("a").ShouldBe(new List<IList<string>>
            {
                new List<string> {"a"}
            });
        }

        [Fact]
        public void should_return_b_for_b()
        {
            solution.Partition("b").ShouldBe(new List<IList<string>>
            {
                new List<string> {"b"}
            });
        }

        [Fact]
        public void should_return_a_a_aa_for_aa()
        {
            solution.Partition("aa").ShouldBe(new List<IList<string>>
            {
                new List<string> {"a", "a"},
                new List<string> {"aa"}
            });
        }

        [Fact]
        public void should_return_a_b_for_ab()
        {
            solution.Partition("ab").ShouldBe(new List<IList<string>>
            {
                new List<string> {"a", "b"}
            });
        }
    }
}