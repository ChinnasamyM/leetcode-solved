public class Solution {
    public int Trap(int[] height) {
        int len = height.Length;
        if(len<2)
            return 0;
        
        //int[] dp=new int[len];
        //dp[0] =0;
        //dp[1] = Math.Abs(height[1] - height[0]);
        int[] left=new int[len];
        int[] right= new int[len];
        
        left[0] = height[0];
        for(int i=1; i<len; i++){
            left[i] = Math.Max(left[i-1], height[i] );
        }
        
        right[len-1] = height[len-1];
        for(int j=len-2; j>=0; j--){
            right[j] = Math.Max(right[j+1], height[j]);
        }
        
        int ans=0;
        for(int k=0; k<len; k++)
            ans += Math.Min(left[k], right[k]) - height[k];
        
        return ans;
    }
}