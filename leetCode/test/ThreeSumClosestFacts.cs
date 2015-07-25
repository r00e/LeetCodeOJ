using System.Collections.Generic;
using leetCode._016_3SumClosestSolution;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class ThreeSumClosestFacts
    {
        private readonly ThreeSumClosestSolution solution = new ThreeSumClosestSolution();

        [Theory]
        [PropertyData("MyTestData")]
        public void should_return_closest_sum_of_3_numbers_for_input(int[] nums, int target, int expectedValue)
        {
            solution.ThreeSumClosest(nums, target).ShouldBe(expectedValue);
        }

        public static IEnumerable<object[]> MyTestData
        {
            get
            {
                return new[]
                {
                    new object[] {new int[] {0, 0, 0}, 0, 0},
                    new object[] {new int[] {0, 0, 0}, 1, 0},
                    new object[] {new int[] {0, 0, 1}, 1, 1},
                    new object[] {new int[] {0, 2, 1}, 1, 3},
                    new object[] {new int[] {0, 2, 1, 0}, 1, 1},
                    new object[] {new int[] {0, 2, 1, -1}, 1, 1},
                    new object[] {new int[] {0, 2, 2, 2, 1, -1}, 1, 1},
                    new object[] {new int[] {-4, 1, 2, -1}, 1, 2},
                };
            }
        }
    }
}
