
public class Solution {
    public int MaxProfit(int[] prices) {
        int n=prices.Length; int k=2;
        if(n==0)
            return 0;
        int[,] profits = new int[k+1, n]; 
        /* Everyday transaction requires previous day profit either real profit or zero in case of first day transation or first attempt. When the integer default 0. hence we can have an 0th day as first day profit by filling all value as zero. */
        for(int t=1; t<=k; t++){
            int _max= Int32.MinValue; // every start _max profit to be min/low as possible.... that;s negative... not zero
            for(int i=1; i<n; i++){
                _max = Math.Max(_max, profits[t-1,i-1] - prices[i-1] );
                profits[t, i] = Math.Max(profits[t, i-1], _max + prices[i] );
            }
        }
        // return the last calculated value,
        return profits[k, n-1];
        
    }
}