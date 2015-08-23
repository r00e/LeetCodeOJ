using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    internal class SimplifyPathSolution
    {
        public string SimplifyPath(string givenPath)
        {
            var stack = new Stack<string>();

            givenPath.Split('/').ToList().ForEach(s =>
            {
                if (!string.IsNullOrEmpty(s)) stack.Push(s);
            });

            var reverseStack = new Stack<string>();
            while(stack.Count != 0) reverseStack.Push(stack.Pop());

            var simplifiedPath = new List<string>();
            while (reverseStack.Count != 0)
            {
                var str = reverseStack.Pop();
                if(str == ".") continue;
                if (str == "..")
                {
                    if (simplifiedPath.Count != 0) simplifiedPath.RemoveAt(simplifiedPath.Count - 1);
                    continue;
                }
                simplifiedPath.Add(str);
            }

            var result = new StringBuilder();
            simplifiedPath.ForEach(s => result.Append("/").Append(s));

            return result.Length == 0 ? "/" : result.ToString();
        }
    }
}