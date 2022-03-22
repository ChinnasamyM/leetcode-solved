public class Solution {
    public int LongestArithSeqLength(int[] nums) {
        
        
        int[] A =nums;
        Dictionary<int,int>[] dp = new Dictionary<int,int>[A.Length];
        int ans = 2;
        for (int j = 0; j < A.Length; j++){
            dp[j] = new Dictionary<int,int>();
            for (int i = 0; i < j; i++){
                int d = A[j] - A[i];
                if (dp[i].ContainsKey(d)){
                    dp[j][d] = dp[i][d]+1;
                }
                else {
                    dp[j][d] = 2;
                }
                ans = Math.Max(ans, dp[j][d]);
            }
        }
        return ans;
        /*
                int len = nums.Length;
        if(len<2)
            return 0;
        
        Dictionary<int, List<int>> _ = new Dictionary<int, List<int>>();
        Array.Sort(nums);
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int max=Int32.MinValue, num=0;
        for(int i=0; i<len; i++){
            for(int j=i+1; j<len; j++){ //len && i!=j
                int diff = nums[j] - nums[i]; //Math.Abs(nums[j] - nums[i] );
                int val=0;
                if(dict.TryGetValue(diff, out val)){
                    dict[diff] +=1;
                    
                    List<int> __ = _[diff];
                    __.Add(nums[j]);
                    _[diff] = __;
                    
                }
                else{
                    dict.Add(diff, 2);
                    
                    List<int> t_ =new List<int>();                    
                    t_.Add(nums[i]);
                    t_.Add(nums[j]);
                    _.Add(diff, t_);
                }
                max = Math.Max(max, dict[diff]);
            }
            
        }
        foreach(KeyValuePair<int, List<int>> kv in _ ){
            for(int i=0; i<kv.Value.Count; i++)
                Console.Write("{0}, ", kv.Value[i]);
            Console.WriteLine(" -> {0}", kv.Key);
        }
        //Console.WriteLine("num={0}, max={1}", num, max);
        return max;
        */
            
    }
}