using System.Linq;

namespace leetCode._217_ContainsDuplicateSolution
{
    public class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if(nums == null || nums.Length == 0 || nums.Length == 1) return false;
            return nums.Length != nums.Distinct().Count();
        }
    }
}