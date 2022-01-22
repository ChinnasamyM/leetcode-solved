public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int i=0;
        foreach(int n in nums){
            int c=0;
            if(dict.TryGetValue(target-n, out c)){
                return new int[]{c,i};
            }
            else if(!dict.TryGetValue(n, out c))
                dict.Add(n, i);
            i++;                
        }
        return new int[2];
    }
}