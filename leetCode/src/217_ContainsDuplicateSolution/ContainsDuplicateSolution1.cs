using System.Collections.Generic;
using System.Linq;

namespace leetCode._217_ContainsDuplicateSolution
{
    public class ContainsDuplicateSolution1
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if(nums == null) return false;

            var distinctNum = new HashSet<int>();
            foreach (var num in nums)
            {
                if (distinctNum.Contains(num)) return true;
                distinctNum.Add(num);
            }

            return false;
        }
    }
}