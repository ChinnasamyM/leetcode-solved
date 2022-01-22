public class Solution {
    public int ClimbStairs(int n) {
        if(n<=1)
            return n;
        int[] dp=new int[n+1];
        //base values
        dp[1]=1;//dp[0] is defaulted to zero and no oth steps possible.
        dp[2]=2;
        for(int i=3; i<=n; i++)
            dp[i] = dp[i-1] + dp[i-2];        
        return dp[n];
    }
}