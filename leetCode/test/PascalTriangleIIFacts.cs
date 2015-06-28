using leetCode._119_PascalTriangleIISolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class PascalTriangleIIFacts
    {
        private readonly PascalTriangleSolutionII solution = new PascalTriangleSolutionII();

        [Fact]
        public void should_return_1_when_input_is_0()
        {
            var result = solution.GetRow(0);
            result.Count.ShouldBe(1);
            result[0].ShouldBe(1);
        }

        [Fact]
        public void should_return_11_when_input_is_1()
        {
            var result = solution.GetRow(1);
            result.Count.ShouldBe(2);
            result[0].ShouldBe(1);
            result[1].ShouldBe(1);
        }

        [Fact]
        public void should_return_121_when_input_is_2()
        {
            var result = solution.GetRow(2);
            result.Count.ShouldBe(3);
            result[0].ShouldBe(1);
            result[1].ShouldBe(2);
            result[2].ShouldBe(1);
        }
    }
}