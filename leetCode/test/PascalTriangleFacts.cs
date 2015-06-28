using leetCode._118_PascalTriangleSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class PascalTriangleFacts
    {
        private readonly PascalTriangleSolution solution = new PascalTriangleSolution();

        [Fact]
        public void should_return_empty_array_when_numRows_is_0()
        {
            solution.Generate(0).Count.ShouldBe(0);
        }

        [Fact]
        public void should_return_1_array_when_numRows_is_1()
        {
            var result = solution.Generate(1);
            result.Count.ShouldBe(1);
            result[0].Count.ShouldBe(1);
            result[0][0].ShouldBe(1);
        }

        [Fact]
        public void should_return_1_11_array_when_numRows_is_2()
        {
            var result = solution.Generate(2);
            result.Count.ShouldBe(2);
            result[0].Count.ShouldBe(1);
            result[0][0].ShouldBe(1);
            result[1].Count.ShouldBe(2);
            result[1][0].ShouldBe(1);
            result[1][1].ShouldBe(1);
        }

        [Fact]
        public void should_return_1_11_121_array_when_numRows_is_3()
        {
            var result = solution.Generate(3);
            result.Count.ShouldBe(3);
            result[0].Count.ShouldBe(1);
            result[0][0].ShouldBe(1);
            result[1].Count.ShouldBe(2);
            result[1][0].ShouldBe(1);
            result[1][1].ShouldBe(1);
            result[2].Count.ShouldBe(3);
            result[2][0].ShouldBe(1);
            result[2][1].ShouldBe(2);
            result[2][2].ShouldBe(1);
        }

        [Fact]
        public void should_return_1_11_121_1331_array_when_numRows_is_4()
        {
            var result = solution.Generate(4);
            result.Count.ShouldBe(4);
            result[0].Count.ShouldBe(1);
            result[0][0].ShouldBe(1);
            result[1].Count.ShouldBe(2);
            result[1][0].ShouldBe(1);
            result[1][1].ShouldBe(1);
            result[2].Count.ShouldBe(3);
            result[2][0].ShouldBe(1);
            result[2][1].ShouldBe(2);
            result[2][2].ShouldBe(1);
            result[3].Count.ShouldBe(4);
            result[3][0].ShouldBe(1);
            result[3][1].ShouldBe(3);
            result[3][2].ShouldBe(3);
            result[3][3].ShouldBe(1);
        }
    }
}