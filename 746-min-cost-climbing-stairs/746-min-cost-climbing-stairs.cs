public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int small=0, smallest=0;
        for(int i=2; i< cost.Length+1; i++){
            int temp = smallest;
            smallest = Math.Min( smallest + cost[i-1], small + cost[i-2] );
            small = temp;
        }
        return smallest;
    }
}