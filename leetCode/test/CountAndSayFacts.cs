using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using leetCode._036_ValidSudokuSolution;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class CountAndSayFacts
    {
        private readonly CountAndSaySolution solution = new CountAndSaySolution();

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "11")]
        [InlineData(3, "21")]
        [InlineData(4, "1211")]
        [InlineData(5, "111221")]
        public void should_return_integer(int num, string expectedValue)
        {
            solution.CountAndSay(num).ShouldBe(expectedValue);
        }
    }

    internal class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            var result = "1";

            for (var i = 1; i < n; i++)
            {
                result = Helper(result);
            }

            return result;
        }

        private static string Helper(string str)
        {
            var result = new StringBuilder();
                
            var say = str.First();
            var count = 0;

            foreach (char c in str)
            {
                if (c == say)
                {
                    count++;
                }
                else
                {
                    result.Append(count);
                    result.Append(say);
                    say = c;
                    count = 1;
                }
            }

            result.Append(count);
            result.Append(say);
            return result.ToString();
        }
    }
}
