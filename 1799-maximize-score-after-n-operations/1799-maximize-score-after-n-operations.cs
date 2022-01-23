public class Solution {
    public int gcd(int a, int b){
        return b==0? a: gcd(b, a%b);
    }
    /*
    Below are the concepts used in this problem
    
        1. Bitwise ie., shift operations 
        2. Dynammic programming 
        3. Depth First Search or DFS
    */
    public int dfs(int[] n, int[,] dp, int i, int mask){
        if(i > n.Length/2 )
            return 0;
        if(dp[i,mask] ==0)
            for(int j=0; j<n.Length; j++)
                for(int k=j+1; k<n.Length; k++){
                    int t_mask = (1<<j) + (1 <<k);
                    if((mask & t_mask) == 0)
                        dp[i,mask] = Math.Max( dp[i,mask], i*gcd(n[j], n[k]) + dfs(n, dp, i+1, mask+t_mask) );
                }
        return dp[i,mask];
    }
    
    public int MaxScore(int[] nums) {
        int x= nums.Length/2+1, y = 1<<nums.Length; // ie., len/2+1, len*2
        int[,] dp = new int[x,y];
        return dfs(nums, dp, 1, 0);
    }
}