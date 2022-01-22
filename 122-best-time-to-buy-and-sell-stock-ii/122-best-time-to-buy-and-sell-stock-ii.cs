public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length< 2)
            return 0;
        else if (prices.Length==2)
            return prices[1] - prices[0]>0 ? prices[1]-prices[0] : 0;
        int[,] profit = new int[prices.Length, 2]; // buy and sell =2 transactions
            
            profit[0, 0]=0-prices[0]; // cant sell at first day but we can buy, as we have 0 in our value hence 0-price
            profit[0, 1] = 0;// We cant sell anything on first day
            
            for(int i=1; i<prices.Length; i++){
                profit[i, 0] = Math.Max(profit[i-1, 0], profit[i-1, 1] - prices[i] );
                profit[i, 1] = Math.Max(profit[i-1, 1], prices[i] + profit[i-1, 0] );
            }
        
        return profit[prices.Length-1, 1]>0 ? profit[prices.Length-1, 1] : 0;
    }
}