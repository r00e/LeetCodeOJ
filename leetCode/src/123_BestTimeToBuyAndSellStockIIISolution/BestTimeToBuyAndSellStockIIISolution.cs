using System;

namespace leetCode._123_BestTimeToBuyAndSellStockIIISolution
{
    public class BestTimeToBuyAndSellStockIIISolution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) return 0;

            // save the profits of transactions 0, 1, 2
            var profits = new int[3, prices.Length];

            for (var transaction = 1; transaction < 3; transaction++)
            {
                var curMaxProfit = profits[transaction - 1, 0] - prices[0];

                for (var day = 1; day < prices.Length; day++)
                {
                    profits[transaction, day] = Math.Max(profits[transaction, day - 1], prices[day] + curMaxProfit);
                    curMaxProfit = Math.Max(curMaxProfit, profits[transaction - 1, day] - prices[day]);
                }
            }

            return profits[profits.GetLength(0) - 1, profits.GetLength(1) - 1];
        }
    }
}