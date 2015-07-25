using System.Collections.Generic;
using System.Linq;

namespace leetCode._015_3SumSolution
{
    public class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();

            if (nums == null || nums.Length < 3) return result;

            var sortedNums = nums.OrderBy(num => num).ToList();

            for (var i = 0; i < sortedNums.Count(); i++)
            {
                if (i == 0 || sortedNums[i] != sortedNums[i - 1])
                {
                    for (var j = i + 1; j < sortedNums.Count(); j++)
                    {
                        if (j - 1 == i || sortedNums[j] != sortedNums[j - 1])
                        {
                            for (var k = j + 1; k < sortedNums.Count(); k++)
                            {
                                if (sortedNums[i] + sortedNums[j] + sortedNums[k] == 0)
                                {
                                    result.Add(new List<int>() { sortedNums[i], sortedNums[j], sortedNums[k] });
                                    break;
                                }
                                if (sortedNums[i] + sortedNums[j] + sortedNums[k] > 0)
                                {
                                    break;
                                }
                            }
                        }

                    }
                }

            }

            return result;
        }
    }
}