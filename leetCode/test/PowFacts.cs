using System.Collections.Generic;
using leetCode._050_PowSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class PowFacts
    {
//        private readonly PowSolution solution = new PowSolution();
        private readonly PowSolutionRecursive solution = new PowSolutionRecursive();

        [Fact]
        public void should_return_0_for_0_power_1()
        {
            solution.MyPow((double) 0, 1).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_for_1_power_0()
        {
            solution.MyPow((double) 1, 0).ShouldBe(1);
        }

        [Fact]
        public void should_return_1_for_1_power_1()
        {
            solution.MyPow((double) 1, 1).ShouldBe(1);
        }

        [Fact]
        public void should_return_4_for_2_power_2()
        {
            solution.MyPow((double) 2, 2).ShouldBe(4);
        }

        [Fact]
        public void should_return_1024_for_2_power_10()
        {
            solution.MyPow((double) 2, 10).ShouldBe(1024);
        }

        [Fact]
        public void should_return_0p5_for_2_power_m1()
        {
            solution.MyPow((double) 2, -1).ShouldBe(0.5);
        }

        [Fact]
        public void should_return_0p25_for_2_power_m2()
        {
            solution.MyPow((double) 2, -2).ShouldBe(0.25);
        }
    }
}