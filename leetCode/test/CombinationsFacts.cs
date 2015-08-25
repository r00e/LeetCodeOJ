using System.Collections.Generic;
using leetCode._077_CombinationsSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class CombinationsFacts
    {
        private readonly CombinationsSolution solution = new CombinationsSolution();

        [Fact]
        public void should_return_empty_for_0_0()
        {
            solution.Combine(0,0).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_empty_for_1_0()
        {
            solution.Combine(1,0).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_1_for_1_1()
        {
            solution.Combine(1,1).ShouldBe(new List<IList<int>>{new List<int>{1}});
        }

        [Fact]
        public void should_return_empty_for_1_2()
        {
            solution.Combine(1,2).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_solution_for_2_1()
        {
            solution.Combine(2,1).ShouldBe(new List<IList<int>>
            {
                new List<int>{1},
                new List<int>{2}
            });
        }

        [Fact]
        public void should_return_solution_for_2_2()
        {
            solution.Combine(2,2).ShouldBe(new List<IList<int>>
            {
                new List<int>{1, 2}
            });
        }
    }
}