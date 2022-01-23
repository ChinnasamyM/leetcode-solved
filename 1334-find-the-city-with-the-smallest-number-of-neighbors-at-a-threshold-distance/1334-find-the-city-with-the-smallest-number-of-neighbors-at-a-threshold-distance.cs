public class Solution {
    public int FindTheCity(int n, int[][] edges, int distanceThreshold) {
     // using floyd warshal alg
        
        // create an DP table 
        int[,] dp = new int[n,n];
        // Fill the DP with default values as, we find minumum we will the max values as default. To avoid memeory overflow when we dp additional arith ops. Let's add Max-value/2
        for(int i=0; i<n; i++)
            for(int j=0; j<n; j++){
                if(i==j)
                    dp[i,j]=0; //As no cyclic loop to same element then fill its weight is zero
                else
                    dp[i,j] = Int32.MaxValue/2; // divide by 2 is not required if start use with Long array with Max int32. This csae int is enough per 2 <= n <= 100
            }
        // As the given graph is a bi-directional, hence we need to fill its both the dirrectios of wight. if not given the same weigh for both dirs
        foreach(int[] e in edges){// As the reverse direction is not given hence filling its forward diorection weight for reverse position too
            dp[e[0], e[1]] = e[2];
            dp[e[1], e[0]] = e[2];
        }
       
        // All path pairs Floyd Warshall algorithm 
        // ********************************************************************************************
        for(int s=0; s<n; s++ ) // this for loop is to maintain its start postion and track from there every elemnt move.
            for(int i=0; i<n; i++) // these i , j foor loop is to position in dp table of their element.
                for(int j=0; j<n; j++){
                    if(dp[i,j] > dp[i,s] + dp[s,j]){ // ie, formulae - i to s -> s to j : i, j with s intermediate nodes hence the formaula is [i, s] then [s,j]
                        dp[i,j] = dp[i,s] + dp[s,j];
                        dp[j,i] = dp[i,s] + dp[s,j];
                    }
                }
        // ********************************************************************************************
        int max = Int32.MaxValue;
        int ans =-1;
        
        // finding the smallest 
        for(int i=0; i<n; i++){
            int t=0;
            for(int j=0; j<n; j++){
                if(dp[i,j]<=distanceThreshold)
                    t++;
            }
            if(t<max || (t==max && i>ans) ){
                max=t;
                ans=i;
            }
        }
        
        return ans;
    }
}