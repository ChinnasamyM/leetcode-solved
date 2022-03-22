public class Solution {
    public int LongestArithSeqLength(int[] nums) {
        int len =nums.Length;
        if(len<2)
            return 0;
        
        Dictionary<int,int>[] dp = new Dictionary<int,int>[len];
        int ans = 2;
        for (int j = 0; j < len; j++){
            dp[j] = new Dictionary<int,int>();
            for (int i = 0; i < j; i++){
                int diff = nums[j] - nums[i];
                if (dp[i].ContainsKey(diff)){
                    dp[j][diff] = dp[i][diff]+1;
                }
                else {
                    dp[j][diff] = 2;
                }
                ans = Math.Max(ans, dp[j][diff]);
            }
        }
        return ans;
        /*
        // Below sln will mfail with these pattern as we can calc per differemce pattern alone... [83,20,17,43,52,78,68,45] 
        // To make it work we need to add AP-subsequence validation and return the successfull max one.
        Dictionary<int, List<int>> _dt = new Dictionary<int, List<int>>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int max=2;
        for(int i=0; i<len; i++){
            for(int j=0; j<i; j++){ 
                int diff = nums[i] - nums[j]; 
                if(dict.ContainsKey(diff)){
                    dict[diff] +=1;                    
                }
                else{
                    dict.Add(diff, 2);
                }
                max = Math.Max(max, dict[diff]);
            }
        }
        return max;
        */
            
    }
}