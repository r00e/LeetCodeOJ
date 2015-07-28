using System.Collections;
using System.Collections.Generic;
using leetCode._018_fourSumSolution;
using leetCode._219_ContainsDuplicateIISolution;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace leetCode.test
{
    public class FourSumFacts
    {
        private readonly FourSumSolution solution = new FourSumSolution();

        [Fact]
        public void should_return_empty_when_input_empty()
        {
            solution.FourSum(new int[]{}, 0).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_empty_when_input_0000_1()
        {
            solution.FourSum(new int[] {0, 0, 0, 0}, 1).ShouldBe(new List<IList<int>>());
        }

        [Fact]
        public void should_return_0000_when_input_0000_0()
        {
            var nums = new int[] {0, 0, 0, 0};
            const int target = 0;
            var expectedResult = new List<IList<int>>(){new List<int>(){0,0,0,0}};

            solution.FourSum(nums, target).ShouldBe(expectedResult);
        }

        [Fact]
        public void should_return_0001_when_input_00001_1()
        {
            var nums = new int[] {0, 0, 1, 0, 0};
            const int target = 1;
            var expectedResult = new List<IList<int>>(){new List<int>(){0,0,0,1}};

            solution.FourSum(nums, target).ShouldBe(expectedResult);
        }

        [Fact]
        public void should_return_0001_when_input_001001_1()
        {
            var nums = new int[] {0, 0, 1, 0, 0, 1};
            const int target = 1;
            var expectedResult = new List<IList<int>>(){new List<int>(){0,0,0,1}};

            solution.FourSum(nums, target).ShouldBe(expectedResult);
        }

        [Fact]
        public void should_return_1234_when_input_11203040_10()
        {
            var nums = new int[] {1, 1, 2, 0, 3, 0, 4, 0};
            const int target = 10;
            var expectedResult = new List<IList<int>>() {new List<int>() {1, 2, 3, 4}};

            solution.FourSum(nums, target).ShouldBe(expectedResult);
        }

        [Fact]
        public void should_return_m2m112_m2002_m1001_when_input_10m10m22_0()
        {
            var nums = new int[] {1, 0, -1, 0, -2, 2};
            const int target = 0;
            var expectedResult = new List<IList<int>>()
            {
                new List<int>() {-2, -1, 1, 2},
                new List<int>() {-2, 0, 0, 2},
                new List<int>() {-1, 0, 0, 1}
            };

            solution.FourSum(nums, target).ShouldBe(expectedResult);
        }
    }
}