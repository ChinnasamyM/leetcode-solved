public class Solution {
    public void MoveZeroes(int[] nums) {
        int len=nums.Length, i=0, curr=0, numops=0;
        while(i < len){
            if(nums[i]==0) 
                numops++;            
            if(nums[i] !=0 && numops>0){
                //Console.Write("Element:{0}, curr:{1} ", nums[i], curr);
                nums[curr]=nums[i];
                nums[i] =0;
                curr++;                
            }
            else if(nums[i]!=0 && numops<=0) // Possibility when first element is not zero and requires to maintain the curr position
                curr++;
            i++;
        }
        //Console.WriteLine(" {0}, {1}, {2}", i, curr, numops);
        
    }
}