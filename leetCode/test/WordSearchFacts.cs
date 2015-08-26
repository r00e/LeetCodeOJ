using leetCode._079_WordSearchSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class WordSearchFacts
    {
        private readonly WordSearchSolution solution = new WordSearchSolution();

        [Fact]
        public void should_return_false_when_search_empty_string()
        {
            solution.Exist(new char[,]{}, string.Empty).ShouldBeFalse();
            solution.Exist(new[,] { { 'a' } }, string.Empty).ShouldBeFalse();
        }

        [Fact]
        public void should_return_false_when_search_a_in_empty_board()
        {
            solution.Exist(new char[,]{}, "a").ShouldBeFalse();
        }

        [Fact]
        public void should_return_false_when_search_a_in_1x1_board_b()
        {
            solution.Exist(new[,] {{'b'}}, "a").ShouldBeFalse();
        }

        [Fact]
        public void should_return_true_when_search_a_in_1x1_board_a()
        {
            solution.Exist(new[,] {{'a'}}, "a").ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_search_a_in_1x2_board()
        {
            solution.Exist(new[,]
            {
                {'a', 'b'}
            },
                "a").ShouldBeTrue();
        }

        [Fact]
        public void should_return_false_when_search_ab_in_1x2_board_ad()
        {
            solution.Exist(new[,]
            {
                {'a', 'd'}
            },
                "ab").ShouldBeFalse();
        }

        [Fact]
        public void should_return_true_when_search_ab_in_2x1_board()
        {
            solution.Exist(new[,]
            {
                {'a'},
                {'b'}
            },
                "ab").ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_search_ab_in_1x2_board_ba()
        {
            solution.Exist(new[,]
            {
                {'b', 'a'}
            },
                "ab").ShouldBeTrue();
        }

        [Fact]
        public void should_return_true_when_search_ab_in_2x1_board_ba()
        {
            solution.Exist(new[,]
            {
                {'b'}, 
                {'a'}
            },
                "ab").ShouldBeTrue();
        }

        [Fact]
        public void should_return_false_when_search_aaa_in_1x3_board_aa()
        {
            solution.Exist(new[,]
            {
                {'a','a'}
            },
                "aaa").ShouldBeFalse();
        }
    }
}