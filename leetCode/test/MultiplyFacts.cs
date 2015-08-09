using leetCode._043_MultiplySolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class MultiplyFacts
    {
        private readonly MultiplySolution solution = new MultiplySolution();

        [Fact]
        public void should_return_0_when_one_number_is_0()
        {
            solution.Multiply("0", "0").ShouldBe("0");
            solution.Multiply("1", "0").ShouldBe("0");
        }

        [Fact]
        public void should_return_number_itself_when_the_other_number_is_1()
        {
            solution.Multiply("1", "5").ShouldBe("5");
            solution.Multiply("3", "1").ShouldBe("3");
        }

        [Fact]
        public void should_return_6_when_num_are_2_and_3()
        {
            solution.Multiply("3", "2").ShouldBe("6");
        }

        [Fact]
        public void should_return_4294967294_when_num_are_2147483647_and_2()
        {
            solution.Multiply("2147483647", "2").ShouldBe("4294967294");
        }

        [Fact]
        public void should_return_4294967294_when_num_are_2_and_2147483647()
        {
            solution.Multiply("2", "2147483647").ShouldBe("4294967294");
        }

        [Fact]
        public void should_return_19327352823_when_num_are_9_and_2147483647()
        {
            solution.Multiply("9", "2147483647").ShouldBe("19327352823");
        }

        [Fact]
        public void should_return_21474836470_when_num_are_2147483647_and_10()
        {
            solution.Multiply("2147483647", "10").ShouldBe("21474836470");
        }

        [Fact]
        public void should_return_21474836470_when_num_are_10_and_2147483647()
        {
            solution.Multiply("10", "2147483647").ShouldBe("21474836470");
        }

        [Fact]
        public void should_return_23622320117_when_num_are_11_and_2147483647()
        {
            solution.Multiply("11", "2147483647").ShouldBe("23622320117");
        }

        [Fact]
        public void should_return_56088_when_num_are_123_and_456()
        {
            solution.Multiply("123", "456").ShouldBe("56088");
        }
    }
}