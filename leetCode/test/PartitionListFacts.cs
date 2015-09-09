using leetCode.Common;
using leetCode._086_PartitionListSolution;
using Xunit;

namespace leetCode.test
{
    public class PartitionListFacts
    {
        private readonly PartitionListSolution solution = new PartitionListSolution();
            
        [Fact]
        public void should_return_empty_for_empty_list()
        {
            var result = solution.Partition(null, 0);
            CommonMethod.VerifyListResult(result, string.Empty);
        }
            
        [Fact]
        public void should_return_1_when_partition_1_with_0()
        {
            var result = solution.Partition(new ListNode(1), 0);
            CommonMethod.VerifyListResult(result, "1");
        }
            
        [Fact]
        public void should_return_1_when_partition_1_with_1()
        {
            var result = solution.Partition(new ListNode(1), 1);
            CommonMethod.VerifyListResult(result, "1");
        }
            
        [Fact]
        public void should_return_1_when_partition_1_with_2()
        {
            var result = solution.Partition(new ListNode(1), 2);
            CommonMethod.VerifyListResult(result, "1");
        }
            
        [Fact]
        public void should_return_21_when_partition_21_with_1()
        {
            var result = solution.Partition(new ListNode(2){next = new ListNode(1)}, 1);
            CommonMethod.VerifyListResult(result, "21");
        }
            
        [Fact]
        public void should_return_12_when_partition_21_with_2()
        {
            var result = solution.Partition(new ListNode(2){next = new ListNode(1)}, 2);
            CommonMethod.VerifyListResult(result, "12");
        }
            
        [Fact]
        public void should_return_21_when_partition_21_with_3()
        {
            var result = solution.Partition(new ListNode(2){next = new ListNode(1)}, 3);
            CommonMethod.VerifyListResult(result, "21");
        }
            
        [Fact]
        public void should_return_2113_when_partition_2131_with_3()
        {
            var result = solution.Partition(new ListNode(2)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(1)
                    }
                }
            }, 3);
            CommonMethod.VerifyListResult(result, "2113");
        }
    }
}