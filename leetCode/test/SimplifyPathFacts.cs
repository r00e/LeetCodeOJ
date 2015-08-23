using System;
using leetCode._071_SimplifyPathSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class SimplifyPathFacts
    {
        private readonly SimplifyPathSolution solution = new SimplifyPathSolution();

        [Theory]
        [InlineData("/", "/")]
        [InlineData("//", "/")]
        [InlineData("/a", "/a")]
        [InlineData("/a//b", "/a/b")]
        [InlineData("/a/", "/a")]
        [InlineData("/a/./b", "/a/b")]
        [InlineData("/a/../b", "/b")]
        [InlineData("/./", "/")]
        [InlineData("/../", "/")]
        [InlineData("//a/./b/../../c/", "/c")]
        public void should_return_simplified_path_for_given_path(string givenPath, string simplifiedPath)
        {
            solution.SimplifyPath(givenPath).ShouldBe(simplifiedPath);
        }
    }
}