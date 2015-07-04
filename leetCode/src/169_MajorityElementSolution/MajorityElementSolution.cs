using System.Collections.Generic;
using System.Linq;

namespace leetCode._169_MajorityElementSolution
{
    public class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            var result = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (result.ContainsKey(num))
                {
                    result[num] += 1;
                    if (result[num] > nums.Length/2) return num;
                }
                else result.Add(num, 1);
            }

            return result.First().Key;
        }
    }
}