using System.Collections.Generic;
using System.Linq;
using leetCode._089_GrayCodeSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class GrayCodeFacts
    {
        private readonly GrayCodeSolution solution = new GrayCodeSolution();
            
        [Fact]
        public void should_return_0_for_0()
        {
            solution.GrayCode(0).ShouldBe(new List<int>{0});
        }
            
        [Fact]
        public void should_return_01_for_1()
        {
            solution.GrayCode(1).ShouldBe(new List<int>{0, 1});
        }
            
        [Fact]
        public void should_return_0132_for_2()
        {
            solution.GrayCode(2).ShouldBe(new List<int> {0, 1, 3, 2});
        }
            
        [Fact]
        public void should_return_01326754_for_3()
        {
            solution.GrayCode(3).ShouldBe(new List<int> {0, 1, 3, 2, 6, 7, 5, 4});
        }
    }
}