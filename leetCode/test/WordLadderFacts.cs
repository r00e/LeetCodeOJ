using System.Collections.Generic;
using leetCode._127_WordLadder;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class WordLadderFacts
    {
//        private readonly WordLadderSolution solution = new WordLadderSolution();
        private readonly WordLadderAnotherSolution solution = new WordLadderAnotherSolution();

        [Fact]
        public void should_return_0_for_empty_word_list()
        {
            solution.LadderLength("", "", new HashSet<string>()).ShouldBe(0);
        }

        [Fact]
        public void should_return_0_when_begin_word_equals_to_end_word()
        {
            solution.LadderLength("a", "a", new HashSet<string>{"a"}).ShouldBe(0);
        }

        [Fact]
        public void should_return_2_for_a_b_and_word_list_b()
        {
            solution.LadderLength("a", "b", new HashSet<string>{"b"}).ShouldBe(2);
        }

        [Fact]
        public void should_return_2_for_a_c_and_word_list_a_b_c()
        {
            solution.LadderLength("a", "c", new HashSet<string>{"a", "b", "c"}).ShouldBe(2);
        }

        [Fact]
        public void should_return_3_for_a_b_and_word_list_c()
        {
            solution.LadderLength("a", "b", new HashSet<string>{"c"}).ShouldBe(3);
        }

        [Fact]
        public void should_return_2_for_ab_cb_and_word_list_cb()
        {
            solution.LadderLength("ab", "cb", new HashSet<string>{"cb"}).ShouldBe(2);
        }

        [Fact]
        public void should_return_3_for_ab_cb_and_word_list_xb()
        {
            solution.LadderLength("ab", "cb", new HashSet<string>{"xb"}).ShouldBe(3);
        }

        [Fact]
        public void should_return_5_for_ab_zy_and_word_list_ad_xd_xy()
        {
            solution.LadderLength("ab", "zy", new HashSet<string>{"ad", "xd", "xy"}).ShouldBe(5);
        }
    }
}