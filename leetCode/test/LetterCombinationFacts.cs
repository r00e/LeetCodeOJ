using System.Collections.Generic;
using System.Globalization;
using System.Text;
using leetCode._017_letterCombinationSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class LetterCombinationFacts
    {
        private readonly LetterCombinationSolution solution = new LetterCombinationSolution();

        [Fact]
        public void should_return_empty_when_no_digits_input()
        {
            solution.LetterCombinations(string.Empty).ShouldBe(new List<string>());
        }

        [Fact]
        public void should_return_abc_when_input_2()
        {
            solution.LetterCombinations("2").ShouldBe(new List<string>() {"a", "b", "c"});
        }

        [Fact]
        public void should_return_def_when_input_3()
        {
            var expectedResult = new List<string>() {"d", "e", "f"};
            
            solution.LetterCombinations("3").ShouldBe(expectedResult);
        }

        [Fact]
        public void should_return_aa_ab_ac_ba_bb_bc_ca_cb_cc_when_input_22()
        {
            var expectedResult = new List<string>()
            {
                "aa",
                "ab",
                "ac",
                "ba",
                "bb",
                "bc",
                "ca",
                "cb",
                "cc"
            };

            solution.LetterCombinations("22").ShouldBe(expectedResult);
        }

        [Fact]
        public void should_return_ag_ah_ai_bg_bh_bi_cg_ch_ci_when_input_24()
        {
            var expectedResult = new List<string>()
            {
                "ag",
                "ah",
                "ai",
                "bg",
                "bh",
                "bi",
                "cg",
                "ch",
                "ci"
            };

            solution.LetterCombinations("24").ShouldBe(expectedResult);
        }
    }
}
