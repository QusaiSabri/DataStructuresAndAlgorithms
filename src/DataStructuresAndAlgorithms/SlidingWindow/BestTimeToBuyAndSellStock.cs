namespace DataStructuresAndAlgorithms.SlidingWindow
{
    public class BestTimeToBuyAndSellStock
    {
        // Input: prices = [7,1,5,3,6,4]
        // Output: 5
        public int MaxProfit(int[] prices)
        {
            var minPrice = int.MaxValue;
            var maxProfit = 0;

            foreach(var price in prices)
            {
                if(price < minPrice)
                {
                    minPrice = price;
                } else
                {
                    maxProfit = Math.Max(maxProfit, price - minPrice);
                }
            }

            return maxProfit;
        }
    }
}
