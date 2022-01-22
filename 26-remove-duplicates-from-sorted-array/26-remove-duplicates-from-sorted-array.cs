public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> set =new HashSet<int>();
        int index=0;
        for(int i=0; i<nums.Length; i++){
            if(!set.Contains(nums[i])){
                set.Add(nums[i]); 
                nums[index]=nums[i];
                index +=1;
            }
        }
        return set.Count;
    }
}