using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using leetCode._090_SubsetsIISolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class SubsetsIIFacts
    {
        readonly SubsetsIISolution solution = new SubsetsIISolution();

        [Fact]
        public void should_return_subsets_for_empty()
        {
            solution.SubsetsWithDup(new int[]{}).ShouldBe(new List<IList<int>>{new List<int>()});
        }
            
        [Fact]
        public void should_return_subsets_for_0()
        {
            var result = solution.SubsetsWithDup(new int[] {0}); 
            
            result.Count.ShouldBe(2);
            result.ShouldContain(new List<int>());
            result.ShouldContain(new List<int> {0});
        }
            
        [Fact]
        public void should_return_subsets_for_12()
        {
            var result = solution.SubsetsWithDup(new int[] {1, 2});
            
            result.Count.ShouldBe(4);
            result.ShouldContain(new List<int>());
            result.ShouldContain(new List<int> {1});
            result.ShouldContain(new List<int> {1, 2});
            result.ShouldContain(new List<int> {2});
        }
            
        [Fact]
        public void should_return_subsets_for_123()
        {
            var result = solution.SubsetsWithDup(new int[] {1, 2, 3});
            
            result.Count.ShouldBe(8);
            result.ShouldContain(new List<int>());
            result.ShouldContain(new List<int> {1});
            result.ShouldContain(new List<int> {1, 2});
            result.ShouldContain(new List<int> {1, 2, 3});
            result.ShouldContain(new List<int> {1, 2});
            result.ShouldContain(new List<int> {2});
            result.ShouldContain(new List<int> {2, 3});
            result.ShouldContain(new List<int> {3});
        }
            
        [Fact]
        public void should_return_subsets_for_11()
        {
            var result = solution.SubsetsWithDup(new int[] {1, 1});
            
            result.Count.ShouldBe(3);
            result.ShouldContain(new List<int>());
            result.ShouldContain(new List<int> {1});
            result.ShouldContain(new List<int> {1, 1});
        }
    }
}