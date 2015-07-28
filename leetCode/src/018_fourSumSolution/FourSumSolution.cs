using System.Collections.Generic;
using System.Linq;

namespace leetCode._018_fourSumSolution
{
    public class FourSumSolution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();

            if (nums.Length < 4) return result;

            var sortedNums = nums.OrderBy(num => num).ToList();

            for (var i = 0; i < sortedNums.Count() - 3; i++)
            {
                if (i != 0 && sortedNums[i] == sortedNums[i - 1]) continue;
                for (var j = i + 1; j < sortedNums.Count() - 2; j++)
                {
                    if (j != i + 1 && sortedNums[j] == sortedNums[j - 1]) continue;

                    var lowIndex = j + 1;
                    var highIndex = sortedNums.Count() - 1;
                    var sum = target - sortedNums[i] - sortedNums[j];
                    while (lowIndex < highIndex)
                    {
                        if (sortedNums[lowIndex] + sortedNums[highIndex] == sum)
                        {
                            result.Add(new List<int>() { sortedNums[i], sortedNums[j], sortedNums[lowIndex], sortedNums[highIndex] });
                            while (lowIndex < highIndex && sortedNums[lowIndex] == sortedNums[lowIndex + 1]) lowIndex++;
                            while (lowIndex < highIndex && sortedNums[highIndex] == sortedNums[highIndex - 1]) highIndex--;
                            lowIndex++;
                            highIndex--;
                        }
                        else if (sortedNums[lowIndex] + sortedNums[highIndex] > sum)
                        {
                            highIndex--;
                        }
                        else
                        {
                            lowIndex++;
                        }
                    }
                }
            }

            return result;
        }
    }
}