using leetCode.Common;
using leetCode._094_BinaryTreeInorderTraversalSolution;
using Xunit;

namespace leetCode.test
{
    public class BinaryTreeInorderTraversalRecursiveFacts
    {
        private readonly BinaryTreeInorderTraversalRecursiveSolution recursiveSolution = new BinaryTreeInorderTraversalRecursiveSolution();
            
        [Fact]
        public void should_return_empty_for_null()
        {
            var result = recursiveSolution.InorderTraversal(null);
            CommonMethod.VerifyTreeNodeResult(result, "[]");
        }
            
        [Fact]
        public void should_return_1_for_1()
        {
            var result = recursiveSolution.InorderTraversal(new TreeNode(1));
            CommonMethod.VerifyTreeNodeResult(result, "[1]");
        }
            
        [Fact]
        public void should_return_21_for_12()
        {
            var result = recursiveSolution.InorderTraversal(new TreeNode(1){left = new TreeNode(2)});
            CommonMethod.VerifyTreeNodeResult(result, "[21]");
        }
            
        [Fact]
        public void should_return_213_for_123()
        {
            var result = recursiveSolution.InorderTraversal(new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            });
            CommonMethod.VerifyTreeNodeResult(result, "[213]");
        }
            
        [Fact]
        public void should_return_213_for_1_23()
        {
            var result = recursiveSolution.InorderTraversal(new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            });
            CommonMethod.VerifyTreeNodeResult(result, "[132]");
        }
    }

    public class BinaryTreeInorderTraversalIterativeFacts
    {
        private readonly BinaryTreeInorderTraversalIterativeSolution iterativeSolution = new BinaryTreeInorderTraversalIterativeSolution();

        [Fact]
        public void should_return_empty_for_null()
        {
            var result = iterativeSolution.InorderTraversal(null);
            CommonMethod.VerifyTreeNodeResult(result, "[]");
        }

        [Fact]
        public void should_return_1_for_1()
        {
            var result = iterativeSolution.InorderTraversal(new TreeNode(1));
            CommonMethod.VerifyTreeNodeResult(result, "[1]");
        }

        [Fact]
        public void should_return_21_for_12()
        {
            var result = iterativeSolution.InorderTraversal(new TreeNode(1) { left = new TreeNode(2) });
            CommonMethod.VerifyTreeNodeResult(result, "[21]");
        }

        [Fact]
        public void should_return_213_for_123()
        {
            var result = iterativeSolution.InorderTraversal(new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            });
            CommonMethod.VerifyTreeNodeResult(result, "[213]");
        }

        [Fact]
        public void should_return_213_for_1_23()
        {
            var result = iterativeSolution.InorderTraversal(new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            });
            CommonMethod.VerifyTreeNodeResult(result, "[132]");
        }
    }
}