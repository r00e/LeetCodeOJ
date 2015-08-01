using System.Collections.Generic;
using System.Linq;
using leetCode._022_GenerateParenthesesSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class GenerateParenthesesFacts
    {
        private readonly GenerateParenthesesSolution solution = new GenerateParenthesesSolution();

        [Fact]
        public void should_return_empty_when_input_0()
        {
            solution.GenerateParenthesis(0).ShouldBe(new List<string>());
        }

        [Fact]
        public void should_return_expected_result_when_input_1()
        {
            var expectedResult = new List<string>() {"()"};
            solution.GenerateParenthesis(1).ShouldBe(expectedResult);
        }

        [Fact]
        public void should_return_expected_result_when_input_2()
        {
            var expectedResult = new List<string>() {"()()", "(())"};
            
            var result = solution.GenerateParenthesis(2);
            result.Count.ShouldBe(expectedResult.Count);
            result.ToList().ForEach(r => expectedResult.Contains(r).ShouldBeTrue());
        }

        [Fact]
        public void should_return_expected_result_when_input_3()
        {
            var expectedResult = new List<string>() {"()()()", "((()))", "(()())", "()(())", "(())()"};
            
            var result = solution.GenerateParenthesis(3);
            result.Count.ShouldBe(expectedResult.Count);
            result.ToList().ForEach(r => expectedResult.Contains(r).ShouldBeTrue());
        }
    }
}