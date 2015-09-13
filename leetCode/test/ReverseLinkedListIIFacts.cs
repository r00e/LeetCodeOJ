using leetCode.Common;
using leetCode._092_ReverseLinkedListIISolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class ReverseLinkedListIIFacts
    {
        private readonly ReverseLinkedListIISolution solution = new ReverseLinkedListIISolution();
            
        [Fact]
        public void should_return_1_for_list_1_m_1_n_1()
        {
            var result = solution.ReverseBetween(new ListNode(1), 1, 1);

            CommonMethod.VerifyListNodeResult(result, "1");
        }
            
        [Fact]
        public void should_return_21_for_list_12_m_1_n_2()
        {
            var result = solution.ReverseBetween(new ListNode(1){next = new ListNode(2)}, 1, 2);

            CommonMethod.VerifyListNodeResult(result, "21");
        }
            
        [Fact]
        public void should_return_213_for_list_123_m_1_n_2()
        {
            var result = solution.ReverseBetween(
                new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                    }
                }, 1, 2);

            CommonMethod.VerifyListNodeResult(result, "213");
        }
            
        [Fact]
        public void should_return_321_for_list_123_m_1_n_3()
        {
            var result = solution.ReverseBetween(
                new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                    }
                }, 1, 3);

            CommonMethod.VerifyListNodeResult(result, "321");
        }
            
        [Fact]
        public void should_return_1324_for_list_1234_m_2_n_3()
        {
            var result = solution.ReverseBetween(
                new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                        }
                    }
                }, 2, 3);

            CommonMethod.VerifyListNodeResult(result, "1324");
        }
    }
}