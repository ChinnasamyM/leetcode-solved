public class Solution {
    public int MinDifficulty(int[] jobDifficulty, int d) {
        int n=jobDifficulty.Length;
        
        int[,] dp=new int[n, d];
        if(d>n)
            return -1;
        dp[0,0] = jobDifficulty[0];
        for(int i=1; i<n; i++)
            dp[i,0] = Math.Max(dp[i-1, 0], jobDifficulty[i]);
        
        for(int day=1; day<d; day++){
            for(int job=day; job <n; job++){
                dp[job, day] = Int32.MaxValue;
                int find = jobDifficulty[job];
                for(int i=job; i>=day; i--){
                    find = Math.Max(find, jobDifficulty[i]);
                    dp[job, day] = Math.Min(dp[job, day], dp[i-1, day-1]+ find);
                }
            }
        }
        return dp[n-1, d-1];
    }
}