using System.Linq;
using leetCode._123_BestTimeToBuyAndSellStockIIISolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class BestTimeToBuyAndSellStockIIIFacts
    {
        private readonly BestTimeToBuyAndSellStockIIISolution solution = new BestTimeToBuyAndSellStockIIISolution();

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
        public void should_return_2_for_stock_132()
        {
            solution.MaxProfit(new[] {1, 3, 2}).ShouldBe(2);
        }

        [Fact]
        public void should_return_3_for_stock_1234()
        {
            solution.MaxProfit(new[] {1, 2, 3, 4}).ShouldBe(3);
        }

        [Fact]
        public void should_return_4_for_stock_1214()
        {
            solution.MaxProfit(new[] {1, 2, 1, 4}).ShouldBe(4);
        }

        [Fact]
        public void should_return_5_for_stock_12145()
        {
            solution.MaxProfit(new[] {1, 2, 1, 4, 5}).ShouldBe(5);
        }

        [Fact]
        public void should_return_7_for_stock_121415()
        {
            solution.MaxProfit(new[] {1, 2, 1, 4, 1, 5}).ShouldBe(7);
        }

        [Fact]
        public void should_return_7_for_stock_613247()
        {
            solution.MaxProfit(new[] {6, 1, 3, 2, 4, 7}).ShouldBe(7);
        }

        [Fact]
        public void should_return_7_for_stock_242515()
        {
            solution.MaxProfit(new[] {2, 4, 2, 5, 1, 5}).ShouldBe(7);
        }
    }
}