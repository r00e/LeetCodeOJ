using leetCode._029_DivideTwoIntegersSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class DivideTwoIntegersFacts
    {
        private readonly DivideTwoIntegersSolution solution = new DivideTwoIntegersSolution();

        [Fact]
        public void should_return_max_int_for_overflow()
        {
            solution.Divide(1, 0).ShouldBe(int.MaxValue);
            solution.Divide(int.MinValue, -1).ShouldBe(int.MaxValue);
        }

        [Fact]
        public void should_return_3_for_3_1()
        {
            solution.Divide(3, 1).ShouldBe(3);
        }

        [Fact]
        public void should_return_5_for_5_1()
        {
            solution.Divide(5, 1).ShouldBe(5);
        }

        [Fact]
        public void should_return_0_for_0_1()
        {
            solution.Divide(0, 1).ShouldBe(0);
        }

        [Fact]
        public void should_return_0_for_0_3()
        {
            solution.Divide(0, 3).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_for_3_2()
        {
            solution.Divide(3, 2).ShouldBe(1);
        }

        [Fact]
        public void should_return_2_for_4_2()
        {
            solution.Divide(4, 2).ShouldBe(2);
        }

        [Fact]
        public void should_return_3_for_11_3()
        {
            solution.Divide(11, 3).ShouldBe(3);
        }

        [Fact]
        public void should_return_m1_for_1_m1()
        {
            solution.Divide(1, -1).ShouldBe(-1);
        }

        [Fact]
        public void should_return_m2_for_5_m2()
        {
            solution.Divide(5, -2).ShouldBe(-2);
        }

        [Fact]
        public void should_return_1073741823_for_int_max_2()
        {
            solution.Divide(int.MaxValue, 2).ShouldBe(int.MaxValue/2);
        }

        [Fact]
        public void should_return_m1073741824_for_int_min_2()
        {
            solution.Divide(int.MinValue, 2).ShouldBe(int.MinValue/2);
        }
    }
}