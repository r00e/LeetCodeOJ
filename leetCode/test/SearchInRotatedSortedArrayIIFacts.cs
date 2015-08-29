using leetCode._081_SearchInRotatedSortedArrayIISolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SearchInRotatedSortedArrayIIFacts
    {
        private readonly SearchInRotatedSortedArrayIISolution solution = new SearchInRotatedSortedArrayIISolution();

        [Fact]
        public void should_return_false_for_empty()
        {
            solution.Search(new int[] {}, 0).ShouldBeFalse();
        }

        [Fact]
        public void should_return_false_when_search_0_in_1()
        {
            solution.Search(new int[] {1}, 0).ShouldBeFalse();
        }

        [Fact]
        public void should_return_true_when_search_1_in_1()
        {
            solution.Search(new int[] {1}, 1).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_search_1_in_11()
        {
            solution.Search(new int[] {1, 1}, 1).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_search_1_in_011()
        {
            solution.Search(new int[] {0, 1, 1}, 1).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_search_1_in_10()
        {
            solution.Search(new int[] {1, 0}, 1).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_search_1_in_2301()
        {
            solution.Search(new int[] {2, 3, 0, 1}, 1).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_search_1_in_2233001()
        {
            solution.Search(new int[] {2, 2, 3, 3, 0, 0, 1}, 1).ShouldBeTrue();
        }

        [Fact]
        public void should_return_false_when_search_5_in_2233001()
        {
            solution.Search(new int[] {2, 2, 3, 3, 0, 0, 1}, 5).ShouldBeFalse();
        }

        [Fact]
        public void should_return_true_when_search_0_in_2202()
        {
            solution.Search(new int[] {2, 2, 0, 2}, 0).ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_search_1_in_31()
        {
            solution.Search(new int[] {3, 1}, 1).ShouldBeTrue();
        }
    }
}