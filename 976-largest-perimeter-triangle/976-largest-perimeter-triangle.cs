public class Solution {
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums); 
        //Per the largest triangle permieter sum of two side is greater than or equal to largest area of other side.
        for(int i=nums.Length-3; i>=0; i--)
            if(nums[i]+nums[i+1] > nums[i+2])
                return nums[i] + nums[i+1] + nums[i+2];
        return 0;
    }
}