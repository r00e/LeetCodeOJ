using System.Collections.Generic;
using System.Linq;
using System.Text;
using leetCode.Common;

namespace leetCode._046_PermutationSolution
{
    public class PermutationsSolution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            if(nums.Length == 0 || nums.Length == 1) return new List<IList<int>>{nums.ToList()};

            var str = new StringBuilder();
            nums.ToList().ForEach(n => str.Append(n));

            var result = new Dictionary<string, IList<int>> {{str.ToString(), nums.ToList()}};

            var resultLength = 0;

            while (resultLength != result.Count)
            {
                str.Clear();
                resultLength = result.Count;
                var nextPermute = GetNextPermute(nums);
                nextPermute.ToList().ForEach(n => str.Append(n));
                if (!result.ContainsKey(str.ToString()))
                {
                    result.Add(str.ToString(), nextPermute);
                }
            }

            return result.Values.ToList();
        }

        private static IList<int> GetNextPermute(int[] nums)
        {
            int former = nums.Length - 2, latter = nums.Length - 1;
            
            while (former >= 0 && nums[former] >= nums[former + 1]) former--;
            if (former >= 0)
            {
                while (nums[former] >= nums[latter]) latter--;
                CommonMethod.Swap(ref nums[former], ref nums[latter]);
            }

            CommonMethod.Reverse(nums, former + 1, nums.Length - 1);

            return nums.ToList();
        }
    }
}