using leetCode._080_RemoveDuplicatesFromSortedArrayIISolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class RemoveDuplicatesFromSortedArrayIIFacts
    {
        private readonly RemoveDuplicatesFromSortedArrayIISolution solution = new RemoveDuplicatesFromSortedArrayIISolution();

        [Fact]
        public void should_return_0_for_empty()
        {
            solution.RemoveDuplicates(new int[]{}).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_for_0()
        {
            solution.RemoveDuplicates(new int[]{0}).ShouldBe(1);
        }

        [Fact]
        public void should_return_2_for_01()
        {
            solution.RemoveDuplicates(new int[] {0, 1}).ShouldBe(2);
        }

        [Fact]
        public void should_return_3_for_112()
        {
            solution.RemoveDuplicates(new int[] {1, 1, 2}).ShouldBe(3);
        }

        [Fact]
        public void should_return_3_for_0111()
        {
            solution.RemoveDuplicates(new int[] {0, 1, 1, 1}).ShouldBe(3);
        }

        [Fact]
        public void should_return_3_for_012()
        {
            solution.RemoveDuplicates(new int[] {0, 1, 2}).ShouldBe(3);
        }

        [Fact]
        public void should_return_3_for_1112()
        {
            solution.RemoveDuplicates(new int[] {1, 1, 1, 2}).ShouldBe(3);
        }
    }
}