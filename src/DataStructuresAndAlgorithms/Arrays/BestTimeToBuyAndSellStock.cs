namespace DataStructuresAndAlgorithms.Arrays
{
    /// <summary>
    ///  Best Time to Buy and Sell Stock --> https://leetcode.com/problems/best-time-to-buy-and-sell-stock
    ///  You are given an array prices where prices[i] is the price of a given stock on the ith day.
    ///  You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    ///  Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
    ///
    ///  Example:
    ///  Input: prices = [7,1,5,3,6,4]
    ///  Output: 5
    ///  Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    /// </summary>
    public class BestTimeToBuyAndSellStock
    {
        /// <summary>
        /// Calculates the maximum profit that can be made from buying and selling in an array of stock prices.
        /// <para>Time complexity: O(n), where n is the number of days (length of the prices array), because we make a single pass through the array.</para>
        /// <para>Space complexity: O(1), because only a constant amount of space is used, regardless of the size of the input array.</para>
        /// </summary>

        public int MaxProfit(int[] prices)
        {
            // left = the buy day (cheapest price seen so far)
            // right = today (the potential sell day, always ahead of or equal to left)
            int left = 0, right = 1;
            int maxProfit = 0;

            // Walk right across the array one day at a time.
            while (right < prices.Length)
            {
                // Valid transaction: today's price is higher than our buy day.
                if (prices[left] < prices[right])
                {
                    // Compute profit for this buy/sell pair and keep the best seen.
                    int profit = prices[right] - prices[left];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                {
                    // Today is cheaper than (or equal to) our current buy day —
                    // it's a better buying opportunity, so move left here.
                    left = right;
                }

                // Advance today forward regardless.
                right++;
            }

            return maxProfit;
        }
    }
}
