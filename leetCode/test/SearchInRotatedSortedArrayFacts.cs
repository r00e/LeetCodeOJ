using System.Linq;
using leetCode._033_SearchInRotatedSortedArraySolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SearchInRotatedSortedArrayFacts
    {
        private readonly SearchInRotatedSortedArraySolution solution = new SearchInRotatedSortedArraySolution();

        [Fact]
        public void should_return_m1_for_empty()
        {
            solution.Search(new int[] {}, 0).ShouldBe(-1);
        }

        [Fact]
        public void should_return_0_when_search_0_in_0()
        {
            solution.Search(new[] {0}, 0).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_search_1_in_01()
        {
            solution.Search(new[] {0, 1}, 1).ShouldBe(1);
        }

        [Fact]
        public void should_return_1_when_search_1_in_012()
        {
            solution.Search(new[] {0, 1, 2}, 1).ShouldBe(1);
        }

        [Fact]
        public void should_return_2_when_search_1_in_3012()
        {
            solution.Search(new[] {3, 0, 1, 2}, 1).ShouldBe(2);
        }

        [Fact]
        public void should_return_m1_when_search_4_in_3012()
        {
            solution.Search(new[] {3, 0, 1, 2}, 4).ShouldBe(-1);
        }

        [Fact]
        public void should_return_m1_when_search_2_in_1()
        {
            solution.Search(new[] {1}, 2).ShouldBe(-1);
        }

        [Fact]
        public void should_return_m1_when_search_0_in_31()
        {
            solution.Search(new[] {3, 1}, 0).ShouldBe(-1);
        }

        [Fact]
        public void should_return_m1_when_search_0_in_13()
        {
            solution.Search(new[] {1, 3}, 0).ShouldBe(-1);
        }
    }
}