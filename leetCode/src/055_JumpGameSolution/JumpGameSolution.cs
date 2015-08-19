namespace leetCode._055_JumpGameSolution
{
    public class JumpGameSolution
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length == 0) return false;

            var last = nums.Length - 1;
            for (var i = nums.Length - 2; i >= 0; i--)
            {
                if (i + nums[i] >= last) last = i;
            }

            return last <= 0;
        }
    }
}