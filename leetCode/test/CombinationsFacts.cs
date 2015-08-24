using System.Collections.Generic;
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

    internal class CombinationsSolution
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            if (k == 0 || k > n) return new List<IList<int>>();

            var combineResults = new List<IList<int>>();
            var combineResult = new List<int>();

            Combine(combineResults, combineResult, n, k, 1, 0);

            return combineResults;
        }

        private void Combine(List<IList<int>> combineResults, List<int> combineResult, int totalNum, int wantGet, int start, int count)
        {
            if (count == wantGet)
            {
                var tmp = new List<int>();
                combineResult.ForEach(tmp.Add);
                combineResults.Add(tmp);
                return;
            }
            for (var i = start; i <= totalNum; i++)
            {
                combineResult.Add(i);
                Combine(combineResults, combineResult, totalNum, wantGet, i + 1, count + 1);
                combineResult.Remove(i);
            }
        }
    }
}