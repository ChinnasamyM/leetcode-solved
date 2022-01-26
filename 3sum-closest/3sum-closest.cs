public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int len = nums.Length, res=0;
        if(len<=2)
            return res;
        
        Array.Sort(nums);
        res = nums[0] + nums[1] + nums[2];
        
        for(int i=0; i<len-2; ++i){
            int j =i+1, k = len-1; // to make two pointer approach
            while(j<k){ // run until end-pointer meets start pointer ie. collision point
                int find = nums[i] + nums[j] + nums[k];
                if( Math.Abs(find - target) < Math.Abs(res - target) )
                    res = find;
                
                //pointers increments
                // move start-pointer if the absolute diff is lesser than target
                if(find < target)
                    j++;
                else if(find > target) // move end-pointer if abs diff is greater
                    k--;
                else
                    return res;                
            }
        }
        return res;
    }
}