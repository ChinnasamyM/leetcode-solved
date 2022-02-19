public class Solution {
    public int Tribonacci(int n) {
        if(n<=1)
            return n;
        else if(n==2)
            return n-1;
        int[] cache = new int[n+1];
        cache[1] = 1; // cache[0] is 0 by default
        cache[2] = 1;
        
        for(int i=3; i<=n; i++)
            cache[i] = cache[i-1] + cache[i-2] + cache[i-3];
        return cache[n];
    }
}