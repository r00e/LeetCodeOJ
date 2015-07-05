using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class RotateArrayFacts
    {
        private readonly RotateArraySolution solution = new RotateArraySolution();

        [Fact]
        public void should_return_1_when_rotate_array_1_by_0()
        {
            var nums = new int[] {1};
            solution.Rotate(nums, 0);
            nums.ShouldBe(new int[]{1});
        }

        [Fact]
        public void should_return_1_when_rotate_array_1_by_1()
        {
            var nums = new int[] {1};
            solution.Rotate(nums, 1);
            nums.ShouldBe(new int[]{1});
        }

        [Fact]
        public void should_return_1_when_rotate_array_1_by_2()
        {
            var nums = new int[] {1};
            solution.Rotate(nums, 2);
            nums.ShouldBe(new int[]{1});
        }

        [Fact]
        public void should_return_21_when_rotate_array_12_by_1()
        {
            var nums = new int[] {1, 2};
            solution.Rotate(nums, 1);
            nums.ShouldBe(new int[]{2, 1});
        }

        [Fact]
        public void should_return_12_when_rotate_array_12_by_2()
        {
            var nums = new int[] {1, 2};
            solution.Rotate(nums, 2);
            nums.ShouldBe(new int[] {1, 2});
        }

        [Fact]
        public void should_return_312_when_rotate_array_123_by_1()
        {
            var nums = new int[] {1, 2, 3};
            solution.Rotate(nums, 1);
            nums.ShouldBe(new int[] {3, 1, 2});
        }

        [Fact]
        public void should_return_231_when_rotate_array_123_by_2()
        {
            var nums = new int[] {1, 2, 3};
            solution.Rotate(nums, 2);
            nums.ShouldBe(new int[] {2, 3, 1});
        }
    }

    internal class RotateArraySolution
    {
        public void Rotate(int[] nums, int k)
        {
//        [1 2, 3 4 5]  k = 3
//           ↑      ↑
// formerPointer  laterPointer
//            var tmpArray = nums;
//            var laterPointer = nums.Length - 1;
//            var formerPointer = nums.Length - k%nums.Length - 1;
//            while (laterPointer > 0 && nums.Length - laterPointer + 1 > k)
//            {
//                var tmp = nums[laterPointer];
//                nums[laterPointer] = nums[formerPointer];
//                nums[formerPointer] = tmp;
//                laterPointer--;
//                formerPointer = formerPointer != 0 ? formerPointer - 1 : (nums.Length - k%nums.Length - 1);
//            }

// O(n) space
            var tmpArray = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                tmpArray[i] = nums[i];
            }
            for (int i = 0, step = k % nums.Length; step > 0; i++, step--)
            {
                nums[i] = tmpArray[nums.Length - step];
            }
            for (int i = 0, step = k % nums.Length; i < nums.Length - step; i++)
            {
                nums[i + step] = tmpArray[i];
            }
        }
    }
}