using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit.Should;

namespace leetCode.Common
{
    public class CommonMethod
    {
        public static void Swap(ref int latter, ref int former)
        {
            var tmp = latter;
            latter = former;
            former = tmp;
        }

        public static void Reverse(int[] nums, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                Swap(ref nums[startIndex], ref nums[endIndex]);
                startIndex++;
                endIndex--;
            }
        }

        public static void VerifyListNodeResult(ListNode head, string expectedResult)
        {
            var actualResultString = new StringBuilder();

            while (head != null)
            {
                actualResultString.Append(head.val);
                head = head.next;
            }

            actualResultString.ToString().ShouldBe(expectedResult);
        }

        public static void VerifyListStringResult(IList<string> actualResult, string expectedResult)
        {
            var result = new StringBuilder();
            result.Append("[]");
            actualResult.ToList().ForEach(str => result.Insert(result.Length - 1, string.Format(", '{0}'", str)));
            if(result.Length > 2) result.Remove(1, 2);

            result.ToString().ShouldBe(expectedResult);
        }
    }
}