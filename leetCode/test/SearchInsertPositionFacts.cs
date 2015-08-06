using leetCode._035_SearchInsertPosition;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SearchInsertPositionFacts
    {
        private readonly SearchInsertPositionSolution solution = new SearchInsertPositionSolution();

        [Fact]
        public void should_return_0_when_insert_0_in_empty()
        {
            solution.SearchInsert(new int[] {}, 0).ShouldBe(0);
        }

        [Fact]
        public void should_return_0_when_insert_0_in_0()
        {
            solution.SearchInsert(new int[] {0}, 0).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_insert_1_in_0()
        {
            solution.SearchInsert(new int[] {0}, 1).ShouldBe(1);
        }

        [Fact]
        public void should_return_0_when_insert_0_in_12()
        {
            solution.SearchInsert(new int[] {1, 2}, 0).ShouldBe(0);
        }

        [Fact]
        public void should_return_2_when_insert_4_in_13()
        {
            solution.SearchInsert(new int[] {1, 3}, 4).ShouldBe(2);
        }

        [Fact]
        public void should_return_1_when_insert_2_in_13()
        {
            solution.SearchInsert(new int[] {1, 3}, 2).ShouldBe(1);
        }

        [Fact]
        public void should_return_1_when_insert_2_in_12()
        {
            solution.SearchInsert(new int[] {1, 2}, 2).ShouldBe(1);
        }

        [Fact]
        public void should_return_2_when_insert_3_in_123()
        {
            solution.SearchInsert(new int[] {1, 2, 3}, 3).ShouldBe(2);
        }

        [Fact]
        public void should_return_0_when_insert_1_in_123()
        {
            solution.SearchInsert(new int[] {1, 2, 3}, 1).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_insert_2_in_123()
        {
            solution.SearchInsert(new int[] {1, 2, 3}, 2).ShouldBe(1);
        }
    }
}