using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace leetCode._078_SubsetsSolution
{
    public class SubsetsBitManipulationSolution
    {
        public IList<IList<int>> Combine(int[] nums)
        {
            if (nums.Length == 0) return new List<IList<int>>();

            var resultsCount = Math.Pow(2, nums.Length);
            var combineResults = new List<IList<int>>();
            for (var i = 0; i < resultsCount; i++)
            {
                combineResults.Add(new List<int>());
            }

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < resultsCount; j++)
                {
                    if ((j >> i & 1) == 1)
                    {
                        combineResults[j].Add(nums[i]);
                    }
                }
            }

            return combineResults;
        }
    }
}