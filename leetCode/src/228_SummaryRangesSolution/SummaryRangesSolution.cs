using System.Collections.Generic;

namespace leetCode._228_SummaryRangesSolution
{
    public class SummaryRangesSolution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            if(nums == null) return null;

            var result = new List<string>();
            if(nums.Length == 1) result.Add(nums[0].ToString());

            var rangeStartIndex = 0;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1] + 1)
                {
                    result.Add(rangeStartIndex == i - 1
                        ? nums[i - 1].ToString()
                        : string.Format("{0}->{1}", nums[rangeStartIndex], nums[i - 1])
                        );

                    rangeStartIndex = i;                    
                }

                if (i == nums.Length - 1)
                {
                    result.Add(nums[i] == nums[i - 1] + 1
                        ? string.Format("{0}->{1}", nums[rangeStartIndex], nums[i])
                        : nums[i].ToString()
                        );
                }
            }

            return result;
        }
    }
}