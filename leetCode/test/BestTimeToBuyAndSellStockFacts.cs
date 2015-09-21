using leetCode._121_BestTimeToBuyAndSellStock;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class BestTimeToBuyAndSellStockFacts
    {
        private readonly BestTimeToBuyAndSellStockSolution solution = new BestTimeToBuyAndSellStockSolution();

        [Fact]
        public void should_return_0_for_stock_empty()
        {
            solution.MaxProfit(new int[]{}).ShouldBe(0);
        }

        [Fact]
        public void should_return_0_for_stock_1()
        {
            solution.MaxProfit(new[] {1}).ShouldBe(0);
        }

        [Fact]
        public void should_return_1_for_stock_12()
        {
            solution.MaxProfit(new[] {1, 2}).ShouldBe(1);
        }

        [Fact]
        public void should_return_2_for_stock_123()
        {
            solution.MaxProfit(new[] {1, 2, 3}).ShouldBe(2);
        }

        [Fact]
        public void should_return_1_for_stock_312()
        {
            solution.MaxProfit(new[] {3, 1, 2}).ShouldBe(1);
        }

        [Fact]
        public void should_return_0_for_stock_321()
        {
            solution.MaxProfit(new[] {3, 2, 1}).ShouldBe(0);
        }

        [Fact]
        public void should_return_2_for_stock_132()
        {
            solution.MaxProfit(new[] {1, 3, 2}).ShouldBe(2);
        }

        [Fact]
        public void should_return_1_for_stock_21201()
        {
            solution.MaxProfit(new[] {2, 1, 2, 0 ,1}).ShouldBe(1);
        }
    }
}