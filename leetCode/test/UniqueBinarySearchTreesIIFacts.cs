using leetCode.Common;
using leetCode._095_UniqueBinarySearchTreesII;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class UniqueBinarySearchTreesIIFacts
    {
        private readonly UniqueBinarySearchTreesIISolution solution = new UniqueBinarySearchTreesIISolution();
            
        [Fact]
        public void should_return_empty_for_0()
        {
            var result = solution.GenerateTrees(0);
            CommonMethod.VerifyTreeNodeResult(result, "[[]]");
        }

        [Fact]
        public void should_return_BST_for_1()
        {
            var result = solution.GenerateTrees(1);
            CommonMethod.VerifyTreeNodeResult(result, "[[1]]");
        }

        [Fact]
        public void should_return_BST_for_2()
        {
            var result = solution.GenerateTrees(2);
            CommonMethod.VerifyTreeNodeResult(result, "[[1, #, 2], [2, 1, #]]");
        }

        [Fact]
        public void should_return_BST_for_3()
        {
            var result = solution.GenerateTrees(3);
            CommonMethod.VerifyTreeNodeResult(result,
                "[[1, #, 2, #, 3], [1, #, 3, 2, #], [2, 1, 3], [3, 1, #, #, 2], [3, 2, #, 1, #]]");
        }
    }
}