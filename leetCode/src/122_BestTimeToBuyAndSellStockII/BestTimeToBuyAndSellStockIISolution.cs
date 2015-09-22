namespace leetCode._122_BestTimeToBuyAndSellStockII
{
    public class BestTimeToBuyAndSellStockIISolution
    {
        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;

            for (var i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[i])
                {
                    maxProfit += prices[i + 1] - prices[i];
                }
            }

            return maxProfit;
        }
    }
}