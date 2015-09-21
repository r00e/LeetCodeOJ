using System;

namespace leetCode._121_BestTimeToBuyAndSellStock
{
    public class BestTimeToBuyAndSellStockSolution
    {
        public int MaxProfit(int[] prices)
        {
            if(prices.Length < 2) return 0;

            var maxProfit = 0;
            var curMinPrice = prices[0];

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] > curMinPrice)
                {
                    maxProfit = Math.Max(maxProfit, prices[i] - curMinPrice);
                }
                else
                {
                    curMinPrice = prices[i];
                }
            }

            return maxProfit;
        }
    }
}