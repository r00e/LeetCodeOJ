using leetCode._096_UniqueBinarySearchTrees;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class UniqueBinarySearchTreesFacts
    {
        private readonly UniqueBinarySearchTreesSolution solution = new UniqueBinarySearchTreesSolution();
            
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        public void should_return_BST_trees_number_for_given_number(int givenNumber, int treesNumber)
        {
            solution.NumTrees(givenNumber).ShouldBe(treesNumber);
        }
    }
}