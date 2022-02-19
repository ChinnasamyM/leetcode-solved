public class Solution {
    public int Fib(int n) {
        int res=0;
        if(n<=1)
            return n;        
        /* Below line do teh math everty iteration ie., re-computing every run*/
        //return res += Fib(n-1);
        
        int[] cache = new int[n+1];
        cache[1] = 1; // cache[0] defaulted to 0 as its an integer.
        for(int i=2; i<=n; i++)
            cache[i] = cache[i-1] + cache[i-2];
        
        return cache[n];
    }
}