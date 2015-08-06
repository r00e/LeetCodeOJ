using leetCode._034_SearchForARangeSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SearchForARangeFacts
    {
//        private readonly SearchForARangeSolution solution = new SearchForARangeSolution();
        private readonly SearchForARangeRealLogNSolution solution = new SearchForARangeRealLogNSolution();

        [Fact]
        public void should_get_m1_m1_when_target_not_in_nums()
        {
            solution.SearchRange(new int[] {}, 0).ShouldBe(new int[] {-1, -1});
        }

        [Fact]
        public void should_get_0_0_when_search_0_in_0()
        {
            solution.SearchRange(new int[] {0}, 0).ShouldBe(new int[] {0, 0});
        }

        [Fact]
        public void should_get_0_0_when_search_0_in_01()
        {
            solution.SearchRange(new int[] {0, 1}, 0).ShouldBe(new int[] {0, 0});
        }

        [Fact]
        public void should_get_1_1_when_search_1_in_01()
        {
            solution.SearchRange(new int[] {0, 1}, 1).ShouldBe(new int[] {1, 1});
        }

        [Fact]
        public void should_get_m1_m1_when_search_2_in_01()
        {
            solution.SearchRange(new int[] {0, 1}, 2).ShouldBe(new int[] {-1, -1});
        }

        [Fact]
        public void should_get_m1_m1_when_search_1_in_02()
        {
            solution.SearchRange(new int[] {0, 2}, 1).ShouldBe(new int[] {-1, -1});
        }

        [Fact]
        public void should_get_0_1_when_search_0_in_001()
        {
            solution.SearchRange(new int[] {0, 0, 1}, 0).ShouldBe(new int[] {0, 1});
        }

        [Fact]
        public void should_get_1_2_when_search_1_in_011()
        {
            solution.SearchRange(new int[] {0, 1, 1}, 1).ShouldBe(new int[] {1, 2});
        }

        [Fact]
        public void should_get_2_2_when_search_2_in_012()
        {
            solution.SearchRange(new int[] {0, 1, 2}, 2).ShouldBe(new int[] {2, 2});
        }

        [Fact]
        public void should_get_1_2_when_search_1_in_0112()
        {
            solution.SearchRange(new int[] {0, 1, 1, 2}, 1).ShouldBe(new int[] {1, 2});
        }
    }
}