public class Solution {
    public int[] ProductExceptSelf(int[] nums) {        
        int len = nums.Length;
        int[] res=new int[len];       
        res[0] =1;
        for(int i=1; i<len; i++){
            res[i] = nums[i-1] * res[i-1];
        }
        int val=1;
        for(int j=len-1; j>=0; j--){
            res[j] = res[j] * val;
            val *=nums[j];
        }
        return res;
    }
}