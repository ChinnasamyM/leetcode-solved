public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int len=colors.Length, cost=neededTime[0],res=0;
        List<int> lcost=new List<int>();// as we need runtime memory alloc to maintain duplicates hence list helps compiler smooth for memory alloc.
        
        int max=neededTime[0];
        for(int i=1; i<len; i++){
            if(colors[i]==colors[i-1]){
                cost +=neededTime[i];
                max = Math.Max(max, neededTime[i]);
            }
            else{
                res += cost - max;
                cost = max = neededTime[i];
            }
        }
        res += cost - max;
        return res;
        /*
        
        // both array length needs to be same otherwise runtime error been thrown
        if( len==0 || len!=neededTime.Length)
            return cost;
        
        if(len<=0)
            return cost;
        else if(len==1)
            return cost;
        else if(len==2){
            if(colors[0]==colors[1]){
                Array.Sort(neededTime);
                cost = neededTime[1];
                return cost;
            }
            else 
                return cost;
        }
        //When items more than 2 counts
        else             
            for(int i=0; i<len-1; i++){
                if(colors[i]==colors[i+1]){
                    lcost.Add(neededTime[i]);
                    lcost.Add(neededTime[i+1]);
                    i++;// we had both items in the array hence skipping one loop.
                }
                else if( lcost.Count>0 && colors[i]==colors[i-1])
                    lcost.Add(neededTime[i]);
                else{
                    cost += calc_cost(lcost);
                    lcost.Clear();// Clear this every operation for next iteration of cost calc
                    Console.Write("{0} ",cost);
                }
            }
    
        // there is a possibility at the end of string might had duplicates hence one final check and cost calc will help result accuracy.
        if(lcost.Count>0)
            cost +=calc_cost(lcost);
        lcost.Clear();
        Console.Write("cost is : {0}", cost);
        
        
        return cost; */
    }
    public int calc_cost(List<int> lcost){
        int cost=0;
        //lcost.Sort();
        // As always we need to take minimum cost of the operation and skip the last one in list/array and sum upto the n-1 duplicates
        for(int i=0; i<lcost.Count-1; i++)
            cost += lcost[i];
        return cost;
    }
}