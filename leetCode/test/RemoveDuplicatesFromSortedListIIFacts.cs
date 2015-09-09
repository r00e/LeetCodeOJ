using System;
using System.Text;
using leetCode.Common;
using leetCode._082_RemoveDuplicatesFromSortedListII;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class RemoveDuplicatesFromSortedListIIFacts
    {
        private readonly RemoveDuplicatesFromSortedListIISolution solution = new RemoveDuplicatesFromSortedListIISolution();
            
        [Fact]
        public void should_return_empty_for_empty_list()
        {
            var result = solution.DeleteDuplicates(null);
            VerifyResult(result, string.Empty);
        }

        [Fact]
        public void should_return_1_for_list_1()
        {
            var result = solution.DeleteDuplicates(new ListNode(1));
            VerifyResult(result, "1");
        }
            
        [Fact]
        public void should_return_empty_for_list_11()
        {
            var result = solution.DeleteDuplicates(new ListNode(1)
            {
                next = new ListNode(1)
            });

            VerifyResult(result, string.Empty);
        }

        [Fact]
        public void should_return_2_for_list_112()
        {
            var result = solution.DeleteDuplicates(new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                }
            });

            VerifyResult(result, "2");
        }
            
        [Fact]
        public void should_return_null_for_list_1122()
        {
            var result = solution.DeleteDuplicates(new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(2)
                    }
                }
            });

            VerifyResult(result, string.Empty);
        }
            
        [Fact]
        public void should_return_0_for_list_01122()
        {
            var result = solution.DeleteDuplicates(new ListNode(0)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(2)
                        }
                    }
                }
            });

            VerifyResult(result, "0");
        }
            
        [Fact]
        public void should_return_02_for_list_011233()
        {
            var result = solution.DeleteDuplicates(new ListNode(0)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(3)
                            {
                                next = new ListNode(3)
                            }
                        }
                    }
                }
            });

            VerifyResult(result, "02");
        }
            
        [Fact]
        public void should_return_03_for_list_011223()
        {
            var result = solution.DeleteDuplicates(new ListNode(0)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(2)
                            {
                                next = new ListNode(3)
                            }
                        }
                    }
                }
            });

            VerifyResult(result, "03");
        }

        void VerifyResult(ListNode actualResult, string expectedResult)
        {
            var actualResultString = new StringBuilder();

            while (actualResult != null)
            {
                actualResultString.Append(actualResult.val);
                actualResult = actualResult.next;
            }

            actualResultString.ToString().ShouldBe(expectedResult);
        }
    }
}