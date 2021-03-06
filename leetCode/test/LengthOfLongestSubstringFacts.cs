﻿using leetCode._003_LengthOfLongestSubstring;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class LengthOfLongestSubstringFacts
    {
        private readonly LengthOfLongestSubstringSolution solution = new LengthOfLongestSubstringSolution();
        private readonly LengthOfLongestSubstringSolution2 solution2 = new LengthOfLongestSubstringSolution2();

        [Fact]
        public void should_return_0_when_input_empty_string()
        {
            solution.LengthOfLongestSubstring(string.Empty).ShouldBe(0);
            solution2.LengthOfLongestSubstring(string.Empty).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_input_a()
        {
            solution.LengthOfLongestSubstring("a").ShouldBe(1);
            solution2.LengthOfLongestSubstring("a").ShouldBe(1);
        }

        [Fact]
        public void should_return_1_when_input_aa()
        {
            solution.LengthOfLongestSubstring("aa").ShouldBe(1);
            solution2.LengthOfLongestSubstring("aa").ShouldBe(1);
        }

        [Fact]
        public void should_return_2_when_input_ab()
        {
            solution.LengthOfLongestSubstring("ab").ShouldBe(2);
            solution2.LengthOfLongestSubstring("ab").ShouldBe(2);
        }

        [Fact]
        public void should_return_2_when_input_aba()
        {
            solution.LengthOfLongestSubstring("aba").ShouldBe(2);
            solution2.LengthOfLongestSubstring("aba").ShouldBe(2);
        }

        [Fact]
        public void should_return_2_when_input_aaaaaaaaaba()
        {
            solution.LengthOfLongestSubstring("aaaaaaaaaba").ShouldBe(2);
            solution2.LengthOfLongestSubstring("aaaaaaaaaba").ShouldBe(2);
        }

        [Fact]
        public void should_return_3_when_input_aaaaaaaaabac()
        {
            solution.LengthOfLongestSubstring("aaaaaaaaabac").ShouldBe(3);
            solution2.LengthOfLongestSubstring("aaaaaaaaabac").ShouldBe(3);
        }

        [Fact]
        public void should_return_4_when_input_aababcdc()
        {
            solution.LengthOfLongestSubstring("aababcdc").ShouldBe(4);
            solution2.LengthOfLongestSubstring("aababcdc").ShouldBe(4);
        }

        [Fact]
        public void should_return_2_when_input_abba()
        {
            solution.LengthOfLongestSubstring("abba").ShouldBe(2);
            solution2.LengthOfLongestSubstring("abba").ShouldBe(2);
        }

        [Fact]
        public void should_return_3_when_input_abbac()
        {
            solution.LengthOfLongestSubstring("abbac").ShouldBe(3);
            solution2.LengthOfLongestSubstring("abbac").ShouldBe(3);
        }

        [Fact]
        public void should_return_3_when_input_abcbac()
        {
            solution.LengthOfLongestSubstring("abcbac").ShouldBe(3);
            solution2.LengthOfLongestSubstring("abcbac").ShouldBe(3);
        }

        [Fact]
        public void should_return_3_when_input_abcbadea()
        {
            solution.LengthOfLongestSubstring("abcbadea").ShouldBe(5);
            solution2.LengthOfLongestSubstring("abcbadea").ShouldBe(5);
        }
    }
}
