public class Solution {
    public int Search(int[] nums, int target) {
        int n=nums.Length;
        if(n==0)
            return -1;
        if(n==1 && nums[0]==target)
            return 0;
        int left=0, right=n-1;
        int mid = left + (right-left)/2;
        while(left < right){
            if(nums[mid]==target)
                return mid;
            if(nums[left] <= nums[mid]){
                if(target >=nums[left] && target <nums[mid])
                    right = mid -1;
                else
                    left = mid+1; // element is not in the sub array.
            }
            else {
                if(target >nums[mid] && target <=nums[right])
                    left = mid +1;
                else
                    right = mid-1; // condition to skip out
            }
            mid = left + (right - left)/2;
            
        }
        
        return target == nums[mid]? mid : -1;
        
    }
}