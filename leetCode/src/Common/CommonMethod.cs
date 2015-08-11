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
    }
}