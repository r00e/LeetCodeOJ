using System.Collections.Generic;
using leetCode._228_SummaryRangesSolution;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class SummaryRangesFacts
    {
        private readonly SummaryRangesSolution solution = new SummaryRangesSolution();
        private List<string> expectedValue = new List<string>();
            
        [Theory]
        [PropertyData("MyTestData")]
        public void should_return_ranges(int[] nums, IList<string> ranges)
        {
            solution.SummaryRanges(nums).ShouldBe(ranges);
        }

        public static IEnumerable<object[]> MyTestData
        {
            get
            {
                return new[]
                {
                    new object[] {null, null},
                    new object[] {new int[]{}, new List<string>{}},
                    new object[] {new int[]{1}, new List<string>{"1"}},
                    new object[] {new int[]{1, 3}, new List<string>{"1", "3"}},
                    new object[] {new int[]{1, 2, 3}, new List<string>{"1->3"}},
                    new object[] {new int[]{1, 2, 3, 5, 7, 8}, new List<string>{"1->3", "5", "7->8"}},
                };
            }
        }
    }
}