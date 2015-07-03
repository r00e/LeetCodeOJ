using leetCode._165_CompareVersionNumber;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class CompareVersionNumbersFacts
    {
        private readonly CompareVersionNumbersSolution solution = new CompareVersionNumbersSolution();

        [Fact]
        public void should_return_1_when_compare_1_and_0()
        {
            solution.CompareVersion("1", "0").ShouldBe(1);
        }

        [Fact]
        public void should_return_minus_1_when_compare_0_and_1()
        {
            solution.CompareVersion("0", "1").ShouldBe(-1);
        }

        [Fact]
        public void should_return_0_when_compare_0_and_0()
        {
            solution.CompareVersion("0", "0").ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_compare_0p1_and_0()
        {
            solution.CompareVersion("0.1", "0").ShouldBe(1);
        }

        [Fact]
        public void should_return_minus_1_when_compare_0p1_and_1()
        {
            solution.CompareVersion("0.1", "1").ShouldBe(-1);
        }

        [Fact]
        public void should_return_0_when_compare_01_and_1()
        {
            solution.CompareVersion("01", "1").ShouldBe(0);
        }

        [Fact]
        public void should_return_1_when_compare_0p1p1_and_0p1()
        {
            solution.CompareVersion("0.1.1", "0.1").ShouldBe(1);
        }

        [Fact]
        public void should_return_minus_1_when_compare_0p1p1_and_0p13()
        {
            solution.CompareVersion("0.1.1", "0.13").ShouldBe(-1);
        }

        [Fact]
        public void should_return_0_when_compare_1p0_and_1()
        {
            solution.CompareVersion("1.0", "1").ShouldBe(0);
        }
    }
}